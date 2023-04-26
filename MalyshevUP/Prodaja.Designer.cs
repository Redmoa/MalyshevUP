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
            this.кодзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодмебелиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mebelnayaMalyshevDataSet1 = new MalyshevUP.MebelnayaMalyshevDataSet1();
            this.заказыTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSet1TableAdapters.ЗаказыTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодмебелиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.мебелиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебелиTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSet1TableAdapters.МебелиTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебелиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 162);
            this.dataGridView1.TabIndex = 0;
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
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.mebelnayaMalyshevDataSet1;
            // 
            // mebelnayaMalyshevDataSet1
            // 
            this.mebelnayaMalyshevDataSet1.DataSetName = "MebelnayaMalyshevDataSet1";
            this.mebelnayaMalyshevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодмебелиDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.наличиеDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.мебелиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(14, 218);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(905, 162);
            this.dataGridView2.TabIndex = 1;
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
            // мебелиBindingSource
            // 
            this.мебелиBindingSource.DataMember = "Мебели";
            this.мебелиBindingSource.DataSource = this.mebelnayaMalyshevDataSet1;
            // 
            // мебелиTableAdapter
            // 
            this.мебелиTableAdapter.ClearBeforeFill = true;
            // 
            // labelZakazy
            // 
            this.labelZakazy.AutoSize = true;
            this.labelZakazy.Location = new System.Drawing.Point(14, 10);
            this.labelZakazy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZakazy.Name = "labelZakazy";
            this.labelZakazy.Size = new System.Drawing.Size(46, 14);
            this.labelZakazy.TabIndex = 2;
            this.labelZakazy.Text = "Заказы";
            // 
            // labelMebeli
            // 
            this.labelMebeli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMebeli.AutoSize = true;
            this.labelMebeli.Location = new System.Drawing.Point(14, 200);
            this.labelMebeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMebeli.Name = "labelMebeli";
            this.labelMebeli.Size = new System.Drawing.Size(49, 14);
            this.labelMebeli.TabIndex = 2;
            this.labelMebeli.Text = "Мебели";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(831, 387);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 25);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(831, 447);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(88, 25);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelKodZ
            // 
            this.labelKodZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKodZ.AutoSize = true;
            this.labelKodZ.Location = new System.Drawing.Point(14, 389);
            this.labelKodZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKodZ.Name = "labelKodZ";
            this.labelKodZ.Size = new System.Drawing.Size(69, 14);
            this.labelKodZ.TabIndex = 4;
            this.labelKodZ.Text = "Код заказа";
            // 
            // textBoxKodZ
            // 
            this.textBoxKodZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxKodZ.Location = new System.Drawing.Point(118, 387);
            this.textBoxKodZ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxKodZ.Name = "textBoxKodZ";
            this.textBoxKodZ.Size = new System.Drawing.Size(116, 22);
            this.textBoxKodZ.TabIndex = 5;
            // 
            // textBoxKodM
            // 
            this.textBoxKodM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxKodM.Location = new System.Drawing.Point(118, 415);
            this.textBoxKodM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxKodM.Name = "textBoxKodM";
            this.textBoxKodM.Size = new System.Drawing.Size(116, 22);
            this.textBoxKodM.TabIndex = 7;
            // 
            // labelKodM
            // 
            this.labelKodM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKodM.AutoSize = true;
            this.labelKodM.Location = new System.Drawing.Point(14, 417);
            this.labelKodM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKodM.Name = "labelKodM";
            this.labelKodM.Size = new System.Drawing.Size(74, 14);
            this.labelKodM.TabIndex = 6;
            this.labelKodM.Text = "Код мебели";
            // 
            // textBoxKolvoM
            // 
            this.textBoxKolvoM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxKolvoM.Location = new System.Drawing.Point(118, 443);
            this.textBoxKolvoM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxKolvoM.Name = "textBoxKolvoM";
            this.textBoxKolvoM.Size = new System.Drawing.Size(116, 22);
            this.textBoxKolvoM.TabIndex = 9;
            // 
            // labelKolvoM
            // 
            this.labelKolvoM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKolvoM.AutoSize = true;
            this.labelKolvoM.Location = new System.Drawing.Point(14, 445);
            this.labelKolvoM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKolvoM.Name = "labelKolvoM";
            this.labelKolvoM.Size = new System.Drawing.Size(92, 14);
            this.labelKolvoM.TabIndex = 8;
            this.labelKolvoM.Text = "Кол-во мебели";
            // 
            // textBoxCena
            // 
            this.textBoxCena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCena.Location = new System.Drawing.Point(352, 386);
            this.textBoxCena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(116, 22);
            this.textBoxCena.TabIndex = 11;
            // 
            // labelCena
            // 
            this.labelCena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(252, 388);
            this.labelCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(86, 14);
            this.labelCena.TabIndex = 10;
            this.labelCena.Text = "Цена за штуку";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSum.Location = new System.Drawing.Point(352, 415);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(116, 22);
            this.textBoxSum.TabIndex = 13;
            // 
            // labelSum
            // 
            this.labelSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(252, 416);
            this.labelSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(42, 14);
            this.labelSum.TabIndex = 12;
            this.labelSum.Text = "Сумма";
            // 
            // Prodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(933, 485);
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
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Prodaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.Prodaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet1)).EndInit();
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