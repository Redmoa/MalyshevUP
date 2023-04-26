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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string KodZ = textBoxKodZ.Text.Trim();
            string KodM = textBoxKodM.Text.Trim();
            string KolvoM = textBoxKolvoM.Text.Trim();
            string Cena = textBoxCena.Text.Trim();
            string Sum = textBoxSum.Text.Trim();

            SqlConnection con = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True");
            con.Open();
            string insertquery = "INSERT INTO Продажи (Код_заказа, Код_мебели, Количество, Цена_за_штуку, Сумма, Статус) VALUES ('" + KodZ + "','" + KodM + "','" + KolvoM + "','" + Cena + "','" + Sum + "','В процессе')";
            SqlCommand cmd2 = new SqlCommand(insertquery, con);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Информация добавлена!");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormIzgotovitel frm = new FormIzgotovitel();
            frm.Show();
            this.Close();
        }
    }
}
