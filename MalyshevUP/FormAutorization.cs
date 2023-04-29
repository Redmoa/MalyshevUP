using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MalyshevUP.Properties;

namespace MalyshevUP
{
    public partial class FormAuthorization : System.Windows.Forms.Form 
    {
        public FormAuthorization()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar= '*';
        }
        //функция авторизации
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //соединение с бд и условия проверки
            SqlConnection con = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True");
            string query = "SELECT * FROM Пользователи WHERE Логин='" + textBoxLogin.Text + "' and Пароль='" + textBoxPassword.Text + "'";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {


                while (reader.Read())
                {
                    object Роль = reader.GetValue(3);
                    string User_Role = Роль.ToString();

                    //вход к формам, в зависимости от ролей
                    if (User_Role == "Изготовитель")
                    {
                        Settings.Default["RememberLogin"] = textBoxLogin.Text;
                        Settings.Default.Save();
                        FormIzgotovitel frm = new FormIzgotovitel();
                        frm.Show();
                        this.Hide();


                    }
                    else if (User_Role == "Покупатель")
                    {
                        Settings.Default["RememberLogin"] = textBoxLogin.Text;
                        Settings.Default.Save();
                        FormPokupatel frm2 = new FormPokupatel();
                        frm2.Show();
                        this.Hide();
                    }


                }


            }
            else
                MessageBox.Show("Некорректный логин или пароль", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //переход к форме регистрации
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegistration frm3 = new FormRegistration();
            frm3.Show();
            this.Hide();
        }
        //выход из приложения
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }
    }
}
