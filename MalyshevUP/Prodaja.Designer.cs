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
            this.мебелиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебелиTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSet1TableAdapters.МебелиTableAdapter();
            this.labelZakazy = new System.Windows.Forms.Label();
            this.buttonSale = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelKodZ = new System.Windows.Forms.Label();
            this.textBoxKodZ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебелиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dataGridView1.Size = new System.Drawing.Size(905, 353);
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
            // buttonSale
            // 
            this.buttonSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSale.Location = new System.Drawing.Point(831, 387);
            this.buttonSale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(88, 25);
            this.buttonSale.TabIndex = 3;
            this.buttonSale.Text = "Продать";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
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
            // Prodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.textBoxKodZ);
            this.Controls.Add(this.labelKodZ);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.labelZakazy);
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
        private System.Windows.Forms.BindingSource мебелиBindingSource;
        private MebelnayaMalyshevDataSet1TableAdapters.МебелиTableAdapter мебелиTableAdapter;
        private System.Windows.Forms.Label labelZakazy;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelKodZ;
        private System.Windows.Forms.TextBox textBoxKodZ;
    }
}