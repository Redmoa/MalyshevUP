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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MalyshevUP
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }
        //назад к форме авторизации
        private void buttonBackTo_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAuthorization frm = new FormAuthorization();
            frm.Show();
        }
        //функция регистрации
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxAgain.Text != "" && comboBoxRole.Text != "")
            {
                if (textBoxAgain.Text == textBoxPassword.Text)
                {
                    if (textBoxPassword.Text.Length >= 6 && textBoxAgain.Text.Length >= 6)
                    {
                        string userLogin = textBoxLogin.Text.Trim();
                        string userPass = textBoxPassword.Text.Trim();
                        string userRole = comboBoxRole.Text.Trim();

                        SqlConnection con1 = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True");
                        string query = "SELECT * FROM Пользователи WHERE Логин = '" + userLogin + "'";
                        con1.Open();
                        SqlCommand cmd = new SqlCommand(query, con1);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("Данный пользователь уже существует");
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            string insertquery = "INSERT INTO Пользователи (Логин, Пароль, Роль) VALUES ('" + userLogin + "','" + userPass + "','" + userRole + "')";
                            SqlCommand cmd1 = new SqlCommand(insertquery, con1);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Вы успешно зарегистрированы!");
                        }
                        con1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароль должен иметь длину меньше или равно 6 символов!");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли должны совпадать");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }
        //Очистить поля
        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxAgain.Text = "";
            comboBoxRole.Text = "";
        }
        
    }
}
