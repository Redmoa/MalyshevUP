namespace MalyshevUP
{
    partial class Sklad
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
            this.кодкомплектующегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодизготовителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиекомплектующегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типкомплектующегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комплектующиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mebelnayaMalyshevDataSetDobavlenie = new MalyshevUP.MebelnayaMalyshevDataSetDobavlenie();
            this.комплектующиеTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSetDobavlenieTableAdapters.КомплектующиеTableAdapter();
            this.labelKodKomp = new System.Windows.Forms.Label();
            this.textBoxKodKomp = new System.Windows.Forms.TextBox();
            this.mebelnayaMalyshevDataSet1 = new MalyshevUP.MebelnayaMalyshevDataSet1();
            this.изготовителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изготовителиTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSet1TableAdapters.ИзготовителиTableAdapter();
            this.textBoxKolvoKomp = new System.Windows.Forms.TextBox();
            this.labelNazvKomp = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSetDobavlenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовителиBindingSource)).BeginInit();
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
            this.кодкомплектующегоDataGridViewTextBoxColumn,
            this.кодизготовителяDataGridViewTextBoxColumn,
            this.названиекомплектующегоDataGridViewTextBoxColumn,
            this.типкомплектующегоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.комплектующиеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодкомплектующегоDataGridViewTextBoxColumn
            // 
            this.кодкомплектующегоDataGridViewTextBoxColumn.DataPropertyName = "Код_комплектующего";
            this.кодкомплектующегоDataGridViewTextBoxColumn.HeaderText = "Код_комплектующего";
            this.кодкомплектующегоDataGridViewTextBoxColumn.Name = "кодкомплектующегоDataGridViewTextBoxColumn";
            // 
            // кодизготовителяDataGridViewTextBoxColumn
            // 
            this.кодизготовителяDataGridViewTextBoxColumn.DataPropertyName = "Код_изготовителя";
            this.кодизготовителяDataGridViewTextBoxColumn.HeaderText = "Код_изготовителя";
            this.кодизготовителяDataGridViewTextBoxColumn.Name = "кодизготовителяDataGridViewTextBoxColumn";
            // 
            // названиекомплектующегоDataGridViewTextBoxColumn
            // 
            this.названиекомплектующегоDataGridViewTextBoxColumn.DataPropertyName = "Название_комплектующего";
            this.названиекомплектующегоDataGridViewTextBoxColumn.HeaderText = "Название_комплектующего";
            this.названиекомплектующегоDataGridViewTextBoxColumn.Name = "названиекомплектующегоDataGridViewTextBoxColumn";
            // 
            // типкомплектующегоDataGridViewTextBoxColumn
            // 
            this.типкомплектующегоDataGridViewTextBoxColumn.DataPropertyName = "Тип_комплектующего";
            this.типкомплектующегоDataGridViewTextBoxColumn.HeaderText = "Тип_комплектующего";
            this.типкомплектующегоDataGridViewTextBoxColumn.Name = "типкомплектующегоDataGridViewTextBoxColumn";
            // 
            // комплектующиеBindingSource
            // 
            this.комплектующиеBindingSource.DataMember = "Комплектующие";
            this.комплектующиеBindingSource.DataSource = this.mebelnayaMalyshevDataSetDobavlenie;
            // 
            // mebelnayaMalyshevDataSetDobavlenie
            // 
            this.mebelnayaMalyshevDataSetDobavlenie.DataSetName = "MebelnayaMalyshevDataSetDobavlenie";
            this.mebelnayaMalyshevDataSetDobavlenie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // комплектующиеTableAdapter
            // 
            this.комплектующиеTableAdapter.ClearBeforeFill = true;
            // 
            // labelKodKomp
            // 
            this.labelKodKomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKodKomp.AutoSize = true;
            this.labelKodKomp.Location = new System.Drawing.Point(594, 306);
            this.labelKodKomp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKodKomp.Name = "labelKodKomp";
            this.labelKodKomp.Size = new System.Drawing.Size(129, 14);
            this.labelKodKomp.TabIndex = 1;
            this.labelKodKomp.Text = "Код комплектующего";
            // 
            // textBoxKodKomp
            // 
            this.textBoxKodKomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKodKomp.Location = new System.Drawing.Point(778, 303);
            this.textBoxKodKomp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxKodKomp.Name = "textBoxKodKomp";
            this.textBoxKodKomp.Size = new System.Drawing.Size(140, 22);
            this.textBoxKodKomp.TabIndex = 2;
            // 
            // mebelnayaMalyshevDataSet1
            // 
            this.mebelnayaMalyshevDataSet1.DataSetName = "MebelnayaMalyshevDataSet1";
            this.mebelnayaMalyshevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // изготовителиBindingSource
            // 
            this.изготовителиBindingSource.DataMember = "Изготовители";
            this.изготовителиBindingSource.DataSource = this.mebelnayaMalyshevDataSet1;
            // 
            // изготовителиTableAdapter
            // 
            this.изготовителиTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxKolvoKomp
            // 
            this.textBoxKolvoKomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKolvoKomp.Location = new System.Drawing.Point(778, 331);
            this.textBoxKolvoKomp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxKolvoKomp.Name = "textBoxKolvoKomp";
            this.textBoxKolvoKomp.Size = new System.Drawing.Size(140, 22);
            this.textBoxKolvoKomp.TabIndex = 5;
            // 
            // labelNazvKomp
            // 
            this.labelNazvKomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNazvKomp.AutoSize = true;
            this.labelNazvKomp.Location = new System.Drawing.Point(594, 334);
            this.labelNazvKomp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNazvKomp.Name = "labelNazvKomp";
            this.labelNazvKomp.Size = new System.Drawing.Size(142, 14);
            this.labelNazvKomp.TabIndex = 4;
            this.labelNazvKomp.Text = "Кол-во комплектующих";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(594, 362);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(109, 14);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Дата поступления";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(832, 388);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 25);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(832, 447);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(88, 25);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(14, 10);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(274, 14);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Добавление информации о новом поступлении";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.monthCalendar1.Location = new System.Drawing.Point(691, 27);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDate.Location = new System.Drawing.Point(778, 360);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(140, 22);
            this.textBoxDate.TabIndex = 5;
            this.textBoxDate.Enter += new System.EventHandler(this.textBoxDate_Enter);
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxKolvoKomp);
            this.Controls.Add(this.labelNazvKomp);
            this.Controls.Add(this.textBoxKodKomp);
            this.Controls.Add(this.labelKodKomp);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Sklad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поступление на склад";
            this.Load += new System.EventHandler(this.Sklad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSetDobavlenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовителиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MebelnayaMalyshevDataSetDobavlenie mebelnayaMalyshevDataSetDobavlenie;
        private System.Windows.Forms.BindingSource комплектующиеBindingSource;
        private MebelnayaMalyshevDataSetDobavlenieTableAdapters.КомплектующиеTableAdapter комплектующиеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкомплектующегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодизготовителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиекомплектующегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типкомплектующегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelKodKomp;
        private System.Windows.Forms.TextBox textBoxKodKomp;
        private MebelnayaMalyshevDataSet1 mebelnayaMalyshevDataSet1;
        private System.Windows.Forms.BindingSource изготовителиBindingSource;
        private MebelnayaMalyshevDataSet1TableAdapters.ИзготовителиTableAdapter изготовителиTableAdapter;
        private System.Windows.Forms.TextBox textBoxKolvoKomp;
        private System.Windows.Forms.Label labelNazvKomp;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxDate;
    }
}