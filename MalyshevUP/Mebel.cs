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
using System.Windows.Forms.VisualStyles;

namespace MalyshevUP
{
    public partial class Mebel : Form
    {
        public Mebel()
        {
            InitializeComponent();
        }

        private void Mebel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSet1.Изготовители". При необходимости она может быть перемещена или удалена.
            this.изготовителиTableAdapter.Fill(this.mebelnayaMalyshevDataSet1.Изготовители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSet1.Мебели". При необходимости она может быть перемещена или удалена.
            this.мебелиTableAdapter.Fill(this.mebelnayaMalyshevDataSet1.Мебели);

        }
        //добавление записи в таблицу производство
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxKodM.Text != "" && textBoxKodI.Text != "" && textBoxDateN.Text != "" && textBoxDateO.Text != "")
            {
                string KodM = textBoxKodM.Text.Trim();
                string KodI = textBoxKodI.Text.Trim();
                string DateN = textBoxDateN.Text.Trim();
                string DateO = textBoxDateO.Text.Trim();

                SqlConnection con = new SqlConnection(@"Data Source=DaisukiReno;Initial Catalog=MebelnayaMalyshev;Integrated Security=True");
                con.Open();
                string insertquery = "INSERT INTO Производство (Код_мебели, Код_изготовителя, Дата_начала, Дата_окончания) VALUES ('" + KodM + "','" + KodI + "','" + DateN + "','" + DateO+ "')";
                SqlCommand cmd2 = new SqlCommand(insertquery, con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Информация добавлена!");
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }
        //открывает календарь по нажатию на текстбокс
        private void textBoxDateN_Enter(object sender, EventArgs e)
        {
            monthCalendar1.Show();
        }
        //открывает календарь по нажатию на текстбокс
        private void textBoxDateO_Enter(object sender, EventArgs e)
        {
            monthCalendar2.Show();
        }
        //ввод даты через календарь
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxDateN.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            monthCalendar1.Hide();
        }
        //ввод даты через календарь
        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxDateO.Text = monthCalendar2.SelectionStart.ToString("yyyy-MM-dd");
            monthCalendar2.Hide();
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
