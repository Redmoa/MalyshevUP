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

            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSet1.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.mebelnayaMalyshevDataSet1.Заказы);

        }
        //добавление записи в таблицу Продажи
        private void buttonSale_Click(object sender, EventArgs e)
        {
            if (textBoxKodZ.Text != "")
            {
                // Получаем код заказа из текстового поля
                int orderCode = int.Parse(textBoxKodZ.Text);
                // Получаем код мебели из таблицы "Заказы" по коду заказа
                int furnitureCode = GetFurnitureCode(orderCode);
                // Получаем цену мебели по ее коду из таблицы "Мебель"
                float furniturePrice = GetFurniturePrice(furnitureCode);
                // Вычисляем количество мебели, проданной в текущей продаже
                int quantity = GetFurnitureQuantity(orderCode);
                // Вычисляем общую стоимость продажи
                float saleAmount = quantity * furniturePrice;
                // Получаем дату продажи
                DateTime saleDate = DateTime.Today;
                string formattedDate = saleDate.ToString("yyyy-MM-dd");

                // Добавляем запись о продаже в таблицу "Продажи"
                using (SqlConnection connection1 = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True"))
                {
                    connection1.Open();
                    string query = "SELECT COUNT(*) FROM Продажи WHERE Код_заказа = @orderCode";
                    SqlCommand command = new SqlCommand(query, connection1);
                    command.Parameters.AddWithValue("@orderCode", orderCode);

                    int count = (int)command.ExecuteScalar();
                    
                    if (count > 0)
                    {
                        // код заказа уже есть в таблице продаж
                        MessageBox.Show("Этот заказ уже числится проданным, выберите другой заказ.");
                        
                    }
                    else
                    {
                        // код заказа уникален, продажу можно осуществлять
                        string query1 = "INSERT INTO Продажи (Код_заказа, Код_мебели, Количество, Цена_за_штуку, Сумма, Дата_продажи) " +
                                        "VALUES (@OrderCode, @FurnitureCode, @Quantity, @Price, @Amount, @SaleDate)";
                        using (SqlCommand command1 = new SqlCommand(query1, connection1))
                        {
                            command1.Parameters.AddWithValue("@OrderCode", orderCode);
                            command1.Parameters.AddWithValue("@FurnitureCode", furnitureCode);
                            command1.Parameters.AddWithValue("@Quantity", quantity);
                            command1.Parameters.AddWithValue("@Price", furniturePrice);
                            command1.Parameters.AddWithValue("@Amount", saleAmount);
                            command1.Parameters.AddWithValue("@SaleDate", formattedDate);
                            command1.ExecuteNonQuery();
                        }
                        // Обновляем статус заказа в таблице "Заказы"
                        string status = "Выполнен";
                        using (SqlConnection connection2 = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True"))
                        {
                            connection2.Open();
                            string query2 = "UPDATE Заказы SET Статус = @Status WHERE Код_заказа = @OrderCode";
                            using (SqlCommand command2 = new SqlCommand(query2, connection2))
                            {
                                command2.Parameters.AddWithValue("@Status", status);
                                command2.Parameters.AddWithValue("@OrderCode", orderCode);
                                command2.ExecuteNonQuery();
                            }
                        }

                        // Выводим сообщение об успешной продаже
                        MessageBox.Show("Продажа успешно завершена.");
                    }
                    
                }  
            }
            else
            {
                MessageBox.Show("Заполните поле!");
            }
            
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
            using (SqlConnection connection = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Код_мебели FROM Заказы WHERE Код_заказа = @OrderCode";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderCode", orderCode);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Код мебели не найден");
                    }
                }
            }
        }

        private float GetFurniturePrice(int furnitureCode)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Цена FROM Мебели WHERE Код_мебели = @FurnitureCode";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FurnitureCode", furnitureCode);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToSingle(result);
                    }
                    else
                    {
                        throw new Exception("Цена мебели не найдена");
                    }
                }
            }
        }

        private int GetFurnitureQuantity(int orderCode)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Количество FROM Заказы WHERE Код_заказа = @orderCode";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@orderCode", orderCode);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Количество мебели не найдено.");
                    }
                }
            }
        }
    }
}
