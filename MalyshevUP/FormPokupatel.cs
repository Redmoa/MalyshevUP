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
                
                string KodMebeli = textBoxKodMebeli.Text.Trim();
                string Kolich = textBoxKolich.Text.Trim();
                string Login = Settings.Default["RememberLogin"].ToString();
                int KodKlienta = 1;
                SqlConnection con2 = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True");
                con2.Open();
                SqlCommand command = new SqlCommand("SELECT Код_пользователя FROM Пользователи WHERE Логин = @Login", con2);
                command.Parameters.AddWithValue("@Login", Login);
                SqlCommand command1 = new SqlCommand("SELECT * FROM Клиенты JOIN Пользователи ON Клиенты.Код_пользователя = Пользователи.Код_пользователя WHERE Код_клиента = @KodKlienta");
                command1.Parameters.AddWithValue("@KodKlienta", KodKlienta);
                if (KodKlienta > 0)
                {
                    string insertquery = "INSERT INTO Заказы (Код_мебели, Код_клиента, Количество, Дата_заказа, Статус) VALUES ('" + KodMebeli + "','" + KodKlienta + "','" + Kolich + "','" + DateTime.Today.ToString("yyyy-MM-dd") +"','" + "В обработке" + "')";
                    SqlCommand command2 = new SqlCommand(insertquery, con2);
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Заказ добавлен!");
                }
                else
                {
                    MessageBox.Show("Заказ не удалось добавить.");
                }
                con2.Close();
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
    }
}

