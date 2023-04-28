using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalyshevUP
{
    public partial class Prodaja : Form
    {
        public Prodaja()
        {
            InitializeComponent();
        }

        private void Prodaja_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSet1.Мебели". При необходимости она может быть перемещена или удалена.
            this.мебелиTableAdapter.Fill(this.mebelnayaMalyshevDataSet1.Мебели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSet1.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.mebelnayaMalyshevDataSet1.Заказы);

        }
        //добавление записи в таблицу Продажи
        private void buttonSale_Click(object sender, EventArgs e)
        {
            // Получаем код заказа из текстового поля
            int orderCode = int.Parse(textBoxKodZ.Text);

            // Получаем код мебели из таблицы "Заказы" по коду заказа
            int furnitureCode = GetFurnitureCode(orderCode);

            // Получаем количество мебели, доступной для продажи, по ее коду из таблицы "Заказы"
            int furnitureQuantity = GetFurnitureQuantity(furnitureCode);

            // Получаем цену мебели по ее коду из таблицы "Мебель"
            decimal furniturePrice = GetFurniturePrice(furnitureCode);

            // Вычисляем количество мебели, проданной в текущей продаже
            int quantity = GetFurnitureQuantity(furnitureCode);


            // Вычисляем общую стоимость продажи
            decimal saleAmount = quantity * furniturePrice;

            // Получаем дату продажи
            DateTime saleDate = DateTime.Today;
            string formattedDate = saleDate.ToString("yyyy-MM-dd");

            // Добавляем запись о продаже в таблицу "Продажи"
            string connectionString = @"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Продажи (КодЗаказа, КодМебели, Количество, ЦенаЗаединицу, ОбщаяЦена, ДатаПродажи) " +
                               "VALUES (@OrderCode, @FurnitureCode, @Quantity, @Price, @Amount, @SaleDate)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderCode", orderCode);
                    command.Parameters.AddWithValue("@FurnitureCode", furnitureCode);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", furniturePrice);
                    command.Parameters.AddWithValue("@Amount", saleAmount);
                    command.Parameters.AddWithValue("@SaleDate", formattedDate);
                    command.ExecuteNonQuery();
                }
            }

            // Обновляем статус заказа в таблице "Заказы"
            string status = "Выполнен";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Заказы SET Статус = @Status WHERE Код = @OrderCode";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@OrderCode", orderCode);
                    command.ExecuteNonQuery();
                }
            }

            // Выводим сообщение об успешной продаже
            MessageBox.Show("Продажа успешно завершена.");
        }
        //назад к форме изготовителя
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormIzgotovitel frm = new FormIzgotovitel();
            frm.Show();
            this.Close();
        }

        private int GetFurnitureCode(int orderCode)
        {
            string connectionString = @"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(Код_мебели) FROM Мебели";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        private decimal GetFurniturePrice(int furnitureCode)
        {
            string connectionString = @"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Цена FROM Мебели WHERE Код_мебели = @FurnitureCode";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FurnitureCode", furnitureCode);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToDecimal(result);
                    }
                    else
                    {
                        throw new Exception("Цена мебели не найдена");
                    }
                }
            }
        }

        private int GetFurnitureQuantity(int furnitureCode)
        {
            string connectionString = @"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Количество FROM Заказы WHERE Код_мебели = @FurnitureCode";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FurnitureCode", furnitureCode);
                    int furnitureQuantity = (int)command.ExecuteScalar();
                    return furnitureQuantity;
                }
            }
        }



    }
}
