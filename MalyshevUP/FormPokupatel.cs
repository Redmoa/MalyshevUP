using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MalyshevUP.Properties;
using System.Collections;

namespace MalyshevUP
{
    public partial class FormPokupatel : Form
    {
        public FormPokupatel()
        {
            InitializeComponent();
        }


        private void FormPokupatel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSet.Мебели". При необходимости она может быть перемещена или удалена.
            this.мебелиTableAdapter.Fill(this.mebelnayaMalyshevDataSet.Мебели);


        }

        //фильтр "В наличии"
        private void radioButtonCheck_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains("True"))
                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }
        //фильтр "Нет в наличии"
        private void radioButtonUncheck_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains("False"))
                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }
        //фильтр "Все"
        private void radioButtonViewAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = true;
            }
        }
        //назад к форме авторизации
        private void buttonBackTo_Click(object sender, EventArgs e)
        {
            FormAuthorization frm = new FormAuthorization();
            frm.Show();
            this.Close();
        }
        //добавление записи в таблицу Заказы
        private void buttonToOrder_Click(object sender, EventArgs e)
        {
            if (textBoxKodMebeli.Text != "" && textBoxKolich.Text != "")
            {
                // Подключение к базе данных
                using (SqlConnection con = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True"))
                {
                    // Запрос на получение значения поля Наличие из таблицы Мебели для заданного кода мебели
                    string KodMebeli = textBoxKodMebeli.Text.Trim();
                    string query = "SELECT Наличие FROM Мебели WHERE Код_мебели=@KodMebeli";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@KodMebeli", KodMebeli);
                        con.Open();
                        bool furnitureAvailable = (bool)command.ExecuteScalar();
                        con.Close();

                        // Если мебели нет в базе данных, выводим сообщение об ошибке
                        if (!furnitureAvailable)
                        {
                            MessageBox.Show("Данная мебель отсутствует в наличии. Пожалуйста подождите, или же выберите другую мебель.");
                            return;
                        }
                    }

                    // Получение кода клиента по логину пользователя
                    string Login = Settings.Default["RememberLogin"].ToString();
                    int KodP = GetUserCode(Login);
                    int KodKlienta = GetCustomerCode(KodP);

                    // Если код клиента не найден, выводим сообщение об ошибке
                    if (KodKlienta == 0)
                    {
                        MessageBox.Show("Не удалось получить код клиента.");
                        return;
                    }

                    // Запрос на добавление заказа в таблицу Заказы
                    string Kolich = textBoxKolich.Text.Trim();
                    query = "INSERT INTO Заказы (Код_мебели, Код_клиента, Количество, Дата_заказа, Статус) VALUES (@KodMebeli, @KodKlienta, @Kolich, @Date, @Status)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        // Добавляем параметры для запроса
                        command.Parameters.AddWithValue("@KodMebeli", KodMebeli);
                        command.Parameters.AddWithValue("@KodKlienta", KodKlienta);
                        command.Parameters.AddWithValue("@Kolich", Kolich);
                        command.Parameters.AddWithValue("@Date", DateTime.Today);
                        command.Parameters.AddWithValue("@Status", "В обработке");
                        con.Open();
                        // Выполняем запрос на добавление
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Заказ добавлен!");
                        }
                        else
                        {
                            MessageBox.Show("Заказ не удалось добавить.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }
        //поиск информации в таблице
        private void buttonFind_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxFind.Text.ToLower()))
                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }

        private int GetCustomerCode(int KodP)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Код_клиента FROM Клиенты WHERE Код_пользователя = @KodP";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KodP", KodP);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Код клиента не найдена!");
                    }
                }
            }
        }

        private int GetUserCode(string Login)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Код_пользователя FROM Пользователи WHERE Логин = @Login";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", Login);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Код пользователя не найдена!");
                    }
                }
            }
        }
    }
}

