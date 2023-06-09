﻿using System;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSetUpdated.Производство". При необходимости она может быть перемещена или удалена.
            this.производствоTableAdapter.Fill(this.mebelnayaMalyshevDataSetUpdated.Производство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSetUpdated.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.mebelnayaMalyshevDataSetUpdated.Склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSetUpdated.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.mebelnayaMalyshevDataSetUpdated.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSetUpdated.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.mebelnayaMalyshevDataSetUpdated.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelnayaMalyshevDataSet1.Продажи". При необходимости она может быть перемещена или удалена.

        }
        //назад к форме авторизации
        private void buttonBackTo_Click(object sender, EventArgs e)
        {
            FormAuthorization frm = new FormAuthorization();
            frm.Show();
            this.Close();
        }
        //переход на форму "Склад"
        private void buttonSklad_Click(object sender, EventArgs e)
        {
            Sklad frm1 = new Sklad();
            frm1.Show();
            this.Hide();
        }
        //переход на форму "Производство"
        private void buttonProizvodstvo_Click(object sender, EventArgs e)
        {
            Mebel frm2 = new Mebel();
            frm2.Show();
            this.Hide();
        }
        //переход на форму "Продажи"
        private void buttonProdaja_Click(object sender, EventArgs e)
        {
            Prodaja frm3 = new Prodaja();
            frm3.Show();
            this.Hide();
        }

    }
}
