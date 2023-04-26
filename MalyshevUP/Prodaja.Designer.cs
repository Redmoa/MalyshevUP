namespace MalyshevUP
{
    partial class Prodaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mebelnayaMalyshevDataSet1 = new MalyshevUP.MebelnayaMalyshevDataSet1();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSet1TableAdapters.ЗаказыTableAdapter();
            this.кодзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодмебелиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.мебелиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебелиTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSet1TableAdapters.МебелиTableAdapter();
            this.кодмебелиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelZakazy = new System.Windows.Forms.Label();
            this.labelMebeli = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelKodZ = new System.Windows.Forms.Label();
            this.textBoxKodZ = new System.Windows.Forms.TextBox();
            this.textBoxKodM = new System.Windows.Forms.TextBox();
            this.labelKodM = new System.Windows.Forms.Label();
            this.textBoxKolvoM = new System.Windows.Forms.TextBox();
            this.labelKolvoM = new System.Windows.Forms.Label();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.labelCena = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебелиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодзаказаDataGridViewTextBoxColumn,
            this.кодклиентаDataGridViewTextBoxColumn,
            this.кодмебелиDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.датазаказаDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // mebelnayaMalyshevDataSet1
            // 
            this.mebelnayaMalyshevDataSet1.DataSetName = "MebelnayaMalyshevDataSet1";
            this.mebelnayaMalyshevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.mebelnayaMalyshevDataSet1;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // кодзаказаDataGridViewTextBoxColumn
            // 
            this.кодзаказаDataGridViewTextBoxColumn.DataPropertyName = "Код_заказа";
            this.кодзаказаDataGridViewTextBoxColumn.HeaderText = "Код_заказа";
            this.кодзаказаDataGridViewTextBoxColumn.Name = "кодзаказаDataGridViewTextBoxColumn";
            this.кодзаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодклиентаDataGridViewTextBoxColumn
            // 
            this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
            // 
            // кодмебелиDataGridViewTextBoxColumn
            // 
            this.кодмебелиDataGridViewTextBoxColumn.DataPropertyName = "Код_мебели";
            this.кодмебелиDataGridViewTextBoxColumn.HeaderText = "Код_мебели";
            this.кодмебелиDataGridViewTextBoxColumn.Name = "кодмебелиDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // датазаказаDataGridViewTextBoxColumn
            // 
            this.датазаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата_заказа";
            this.датазаказаDataGridViewTextBoxColumn.HeaderText = "Дата_заказа";
            this.датазаказаDataGridViewTextBoxColumn.Name = "датазаказаDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодмебелиDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.наличиеDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.мебелиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 202);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // мебелиBindingSource
            // 
            this.мебелиBindingSource.DataMember = "Мебели";
            this.мебелиBindingSource.DataSource = this.mebelnayaMalyshevDataSet1;
            // 
            // мебелиTableAdapter
            // 
            this.мебелиTableAdapter.ClearBeforeFill = true;
            // 
            // кодмебелиDataGridViewTextBoxColumn1
            // 
            this.кодмебелиDataGridViewTextBoxColumn1.DataPropertyName = "Код_мебели";
            this.кодмебелиDataGridViewTextBoxColumn1.HeaderText = "Код_мебели";
            this.кодмебелиDataGridViewTextBoxColumn1.Name = "кодмебелиDataGridViewTextBoxColumn1";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // наличиеDataGridViewCheckBoxColumn
            // 
            this.наличиеDataGridViewCheckBoxColumn.DataPropertyName = "Наличие";
            this.наличиеDataGridViewCheckBoxColumn.HeaderText = "Наличие";
            this.наличиеDataGridViewCheckBoxColumn.Name = "наличиеDataGridViewCheckBoxColumn";
            // 
            // labelZakazy
            // 
            this.labelZakazy.AutoSize = true;
            this.labelZakazy.Location = new System.Drawing.Point(12, 9);
            this.labelZakazy.Name = "labelZakazy";
            this.labelZakazy.Size = new System.Drawing.Size(46, 13);
            this.labelZakazy.TabIndex = 2;
            this.labelZakazy.Text = "Заказы";
            // 
            // labelMebeli
            // 
            this.labelMebeli.AutoSize = true;
            this.labelMebeli.Location = new System.Drawing.Point(12, 186);
            this.labelMebeli.Name = "labelMebeli";
            this.labelMebeli.Size = new System.Drawing.Size(46, 13);
            this.labelMebeli.TabIndex = 2;
            this.labelMebeli.Text = "Мебели";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(712, 359);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(712, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelKodZ
            // 
            this.labelKodZ.AutoSize = true;
            this.labelKodZ.Location = new System.Drawing.Point(12, 361);
            this.labelKodZ.Name = "labelKodZ";
            this.labelKodZ.Size = new System.Drawing.Size(65, 13);
            this.labelKodZ.TabIndex = 4;
            this.labelKodZ.Text = "Код заказа";
            // 
            // textBoxKodZ
            // 
            this.textBoxKodZ.Location = new System.Drawing.Point(101, 359);
            this.textBoxKodZ.Name = "textBoxKodZ";
            this.textBoxKodZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxKodZ.TabIndex = 5;
            // 
            // textBoxKodM
            // 
            this.textBoxKodM.Location = new System.Drawing.Point(101, 385);
            this.textBoxKodM.Name = "textBoxKodM";
            this.textBoxKodM.Size = new System.Drawing.Size(100, 20);
            this.textBoxKodM.TabIndex = 7;
            // 
            // labelKodM
            // 
            this.labelKodM.AutoSize = true;
            this.labelKodM.Location = new System.Drawing.Point(12, 387);
            this.labelKodM.Name = "labelKodM";
            this.labelKodM.Size = new System.Drawing.Size(67, 13);
            this.labelKodM.TabIndex = 6;
            this.labelKodM.Text = "Код мебели";
            // 
            // textBoxKolvoM
            // 
            this.textBoxKolvoM.Location = new System.Drawing.Point(101, 411);
            this.textBoxKolvoM.Name = "textBoxKolvoM";
            this.textBoxKolvoM.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolvoM.TabIndex = 9;
            // 
            // labelKolvoM
            // 
            this.labelKolvoM.AutoSize = true;
            this.labelKolvoM.Location = new System.Drawing.Point(12, 413);
            this.labelKolvoM.Name = "labelKolvoM";
            this.labelKolvoM.Size = new System.Drawing.Size(82, 13);
            this.labelKolvoM.TabIndex = 8;
            this.labelKolvoM.Text = "Кол-во мебели";
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(302, 358);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCena.TabIndex = 11;
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(216, 360);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(80, 13);
            this.labelCena.TabIndex = 10;
            this.labelCena.Text = "Цена за штуку";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(302, 385);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 13;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(216, 386);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(41, 13);
            this.labelSum.TabIndex = 12;
            this.labelSum.Text = "Сумма";
            // 
            // Prodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.textBoxKolvoM);
            this.Controls.Add(this.labelKolvoM);
            this.Controls.Add(this.textBoxKodM);
            this.Controls.Add(this.labelKodM);
            this.Controls.Add(this.textBoxKodZ);
            this.Controls.Add(this.labelKodZ);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelMebeli);
            this.Controls.Add(this.labelZakazy);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prodaja";
            this.Text = "Prodaja";
            this.Load += new System.EventHandler(this.Prodaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебелиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MebelnayaMalyshevDataSet1 mebelnayaMalyshevDataSet1;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private MebelnayaMalyshevDataSet1TableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмебелиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource мебелиBindingSource;
        private MebelnayaMalyshevDataSet1TableAdapters.МебелиTableAdapter мебелиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмебелиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наличиеDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label labelZakazy;
        private System.Windows.Forms.Label labelMebeli;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelKodZ;
        private System.Windows.Forms.TextBox textBoxKodZ;
        private System.Windows.Forms.TextBox textBoxKodM;
        private System.Windows.Forms.Label labelKodM;
        private System.Windows.Forms.TextBox textBoxKolvoM;
        private System.Windows.Forms.Label labelKolvoM;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelSum;
    }
}