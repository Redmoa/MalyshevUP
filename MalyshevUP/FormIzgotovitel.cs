using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalyshevUP
{
    public partial class FormIzgotovitel : Form
    {
        public FormIzgotovitel()
        {
            InitializeComponent();
        }

        private void FormIzgotovitel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSetIzgotovitel.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.mebelnayaMalyshevDataSetIzgotovitel.Склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSetIzgotovitel.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.mebelnayaMalyshevDataSetIzgotovitel.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSetIzgotovitel.Производство". При необходимости она может быть перемещена или удалена.
            this.производствоTableAdapter.Fill(this.mebelnayaMalyshevDataSetIzgotovitel.Производство);

        }

        private void buttonBackTo_Click(object sender, EventArgs e)
        {
            FormAuthorization frm = new FormAuthorization();
            frm.Show();
            this.Close();
        }

        private void buttonSklad_Click(object sender, EventArgs e)
        {
            Sklad frm1 = new Sklad();
            frm1.Show();
            this.Hide();
        }

        private void buttonProizvodstvo_Click(object sender, EventArgs e)
        {
            Mebel frm2 = new Mebel();
            frm2.Show();
            this.Hide();
        }
    }
}
