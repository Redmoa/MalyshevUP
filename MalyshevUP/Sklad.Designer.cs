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
            this.mebelnayaMalyshevDataSetDobavlenie = new MalyshevUP.MebelnayaMalyshevDataSetDobavlenie();
            this.комплектующиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комплектующиеTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSetDobavlenieTableAdapters.КомплектующиеTableAdapter();
            this.кодкомплектующегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодизготовителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиекомплектующегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типкомплектующегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSetDobavlenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовителиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодкомплектующегоDataGridViewTextBoxColumn,
            this.кодизготовителяDataGridViewTextBoxColumn,
            this.названиекомплектующегоDataGridViewTextBoxColumn,
            this.типкомплектующегоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.комплектующиеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // mebelnayaMalyshevDataSetDobavlenie
            // 
            this.mebelnayaMalyshevDataSetDobavlenie.DataSetName = "MebelnayaMalyshevDataSetDobavlenie";
            this.mebelnayaMalyshevDataSetDobavlenie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // комплектующиеBindingSource
            // 
            this.комплектующиеBindingSource.DataMember = "Комплектующие";
            this.комплектующиеBindingSource.DataSource = this.mebelnayaMalyshevDataSetDobavlenie;
            // 
            // комплектующиеTableAdapter
            // 
            this.комплектующиеTableAdapter.ClearBeforeFill = true;
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
            // labelKodKomp
            // 
            this.labelKodKomp.AutoSize = true;
            this.labelKodKomp.Location = new System.Drawing.Point(509, 284);
            this.labelKodKomp.Name = "labelKodKomp";
            this.labelKodKomp.Size = new System.Drawing.Size(117, 13);
            this.labelKodKomp.TabIndex = 1;
            this.labelKodKomp.Text = "Код комплектующего";
            // 
            // textBoxKodKomp
            // 
            this.textBoxKodKomp.Location = new System.Drawing.Point(667, 281);
            this.textBoxKodKomp.Name = "textBoxKodKomp";
            this.textBoxKodKomp.Size = new System.Drawing.Size(121, 20);
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
            this.textBoxKolvoKomp.Location = new System.Drawing.Point(667, 307);
            this.textBoxKolvoKomp.Name = "textBoxKolvoKomp";
            this.textBoxKolvoKomp.Size = new System.Drawing.Size(121, 20);
            this.textBoxKolvoKomp.TabIndex = 5;
            // 
            // labelNazvKomp
            // 
            this.labelNazvKomp.AutoSize = true;
            this.labelNazvKomp.Location = new System.Drawing.Point(509, 310);
            this.labelNazvKomp.Name = "labelNazvKomp";
            this.labelNazvKomp.Size = new System.Drawing.Size(126, 13);
            this.labelNazvKomp.TabIndex = 4;
            this.labelNazvKomp.Text = "Кол-во комплектующих";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(509, 336);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(100, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Дата поступления";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(713, 360);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(713, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(248, 13);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Добавление информации о новом поступлении";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(592, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(667, 334);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxDate.TabIndex = 5;
            this.textBoxDate.Enter += new System.EventHandler(this.textBoxDate_Enter);
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Sklad";
            this.Text = "Sklad";
            this.Load += new System.EventHandler(this.Sklad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSetDobavlenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующиеBindingSource)).EndInit();
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