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
    public partial class Sklad : Form
    {
        public Sklad()
        {
            InitializeComponent();
        }

        private void Sklad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSet1.Изготовители". При необходимости она может быть перемещена или удалена.
            this.изготовителиTableAdapter.Fill(this.mebelnayaMalyshevDataSet1.Изготовители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSetDobavlenie.Комплектующие". При необходимости она может быть перемещена или удалена.
            this.комплектующиеTableAdapter.Fill(this.mebelnayaMalyshevDataSetDobavlenie.Комплектующие);

        }
        //кнопка добавления
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxKodKomp.Text != "" && textBoxKolvoKomp.Text != "" && textBoxKolvoKomp.Text != "")
            {
                string KodKomp = textBoxKodKomp.Text.Trim();
                string KolvoKomp = textBoxKolvoKomp.Text.Trim();
                string DateKomp = textBoxDate.Text.Trim();

                SqlConnection con = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True");
                con.Open();
                string insertquery = "INSERT INTO Склад (Код_комплектующего, Количество, Дата_поступления) VALUES ('" + KodKomp + "','" + KolvoKomp + "','" + DateKomp + "')";
                SqlCommand cmd2 = new SqlCommand(insertquery, con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Информация добавлена!");
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }
        //при нажатии на текстбокс должен открыться календарь
        private void textBoxDate_Enter(object sender, EventArgs e)
        {
            monthCalendar1.Show();
        }
        //выбор даты через календарь
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxDate.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            monthCalendar1.Hide();
        }
        //назад к форме изготовителя
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormIzgotovitel frm = new FormIzgotovitel();
            frm.Show();
            this.Close();
        }
    }
}
