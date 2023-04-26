namespace MalyshevUP
{
    partial class Mebel
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mebelnayaMalyshevDataSet1 = new MalyshevUP.MebelnayaMalyshevDataSet1();
            this.мебелиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебелиTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSet1TableAdapters.МебелиTableAdapter();
            this.кодмебелиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.изготовителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изготовителиTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSet1TableAdapters.ИзготовителиTableAdapter();
            this.кодизготовителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMebeli = new System.Windows.Forms.Label();
            this.labelIzgotoviteli = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelKodM = new System.Windows.Forms.Label();
            this.textBoxKodM = new System.Windows.Forms.TextBox();
            this.textBoxKodI = new System.Windows.Forms.TextBox();
            this.labelKodI = new System.Windows.Forms.Label();
            this.textBoxDateN = new System.Windows.Forms.TextBox();
            this.labelDateN = new System.Windows.Forms.Label();
            this.textBoxDateO = new System.Windows.Forms.TextBox();
            this.labelDateO = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебелиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовителиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодмебелиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.наличиеDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.мебелиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 134);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодизготовителяDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn1,
            this.кодпользователяDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.изготовителиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 179);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // mebelnayaMalyshevDataSet1
            // 
            this.mebelnayaMalyshevDataSet1.DataSetName = "MebelnayaMalyshevDataSet1";
            this.mebelnayaMalyshevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // кодмебелиDataGridViewTextBoxColumn
            // 
            this.кодмебелиDataGridViewTextBoxColumn.DataPropertyName = "Код_мебели";
            this.кодмебелиDataGridViewTextBoxColumn.HeaderText = "Код_мебели";
            this.кодмебелиDataGridViewTextBoxColumn.Name = "кодмебелиDataGridViewTextBoxColumn";
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
            // изготовителиBindingSource
            // 
            this.изготовителиBindingSource.DataMember = "Изготовители";
            this.изготовителиBindingSource.DataSource = this.mebelnayaMalyshevDataSet1;
            // 
            // изготовителиTableAdapter
            // 
            this.изготовителиTableAdapter.ClearBeforeFill = true;
            // 
            // кодизготовителяDataGridViewTextBoxColumn
            // 
            this.кодизготовителяDataGridViewTextBoxColumn.DataPropertyName = "Код_изготовителя";
            this.кодизготовителяDataGridViewTextBoxColumn.HeaderText = "Код_изготовителя";
            this.кодизготовителяDataGridViewTextBoxColumn.Name = "кодизготовителяDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            // 
            // кодпользователяDataGridViewTextBoxColumn
            // 
            this.кодпользователяDataGridViewTextBoxColumn.DataPropertyName = "Код_пользователя";
            this.кодпользователяDataGridViewTextBoxColumn.HeaderText = "Код_пользователя";
            this.кодпользователяDataGridViewTextBoxColumn.Name = "кодпользователяDataGridViewTextBoxColumn";
            // 
            // labelMebeli
            // 
            this.labelMebeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMebeli.AutoSize = true;
            this.labelMebeli.Location = new System.Drawing.Point(12, 8);
            this.labelMebeli.Name = "labelMebeli";
            this.labelMebeli.Size = new System.Drawing.Size(46, 13);
            this.labelMebeli.TabIndex = 2;
            this.labelMebeli.Text = "Мебели";
            // 
            // labelIzgotoviteli
            // 
            this.labelIzgotoviteli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIzgotoviteli.AutoSize = true;
            this.labelIzgotoviteli.Location = new System.Drawing.Point(12, 163);
            this.labelIzgotoviteli.Name = "labelIzgotoviteli";
            this.labelIzgotoviteli.Size = new System.Drawing.Size(78, 13);
            this.labelIzgotoviteli.TabIndex = 2;
            this.labelIzgotoviteli.Text = "Изготовители";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(713, 338);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(713, 413);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelKodM
            // 
            this.labelKodM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKodM.AutoSize = true;
            this.labelKodM.Location = new System.Drawing.Point(15, 341);
            this.labelKodM.Name = "labelKodM";
            this.labelKodM.Size = new System.Drawing.Size(67, 13);
            this.labelKodM.TabIndex = 4;
            this.labelKodM.Text = "Код мебели";
            // 
            // textBoxKodM
            // 
            this.textBoxKodM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxKodM.Location = new System.Drawing.Point(126, 338);
            this.textBoxKodM.Name = "textBoxKodM";
            this.textBoxKodM.Size = new System.Drawing.Size(100, 20);
            this.textBoxKodM.TabIndex = 5;
            // 
            // textBoxKodI
            // 
            this.textBoxKodI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxKodI.Location = new System.Drawing.Point(126, 364);
            this.textBoxKodI.Name = "textBoxKodI";
            this.textBoxKodI.Size = new System.Drawing.Size(100, 20);
            this.textBoxKodI.TabIndex = 7;
            // 
            // labelKodI
            // 
            this.labelKodI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKodI.AutoSize = true;
            this.labelKodI.Location = new System.Drawing.Point(15, 367);
            this.labelKodI.Name = "labelKodI";
            this.labelKodI.Size = new System.Drawing.Size(98, 13);
            this.labelKodI.TabIndex = 6;
            this.labelKodI.Text = "Код изготовителя";
            // 
            // textBoxDateN
            // 
            this.textBoxDateN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDateN.Location = new System.Drawing.Point(126, 390);
            this.textBoxDateN.Name = "textBoxDateN";
            this.textBoxDateN.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateN.TabIndex = 9;
            this.textBoxDateN.Enter += new System.EventHandler(this.textBoxDateN_Enter);
            // 
            // labelDateN
            // 
            this.labelDateN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDateN.AutoSize = true;
            this.labelDateN.Location = new System.Drawing.Point(15, 393);
            this.labelDateN.Name = "labelDateN";
            this.labelDateN.Size = new System.Drawing.Size(71, 13);
            this.labelDateN.TabIndex = 8;
            this.labelDateN.Text = "Дата начала";
            // 
            // textBoxDateO
            // 
            this.textBoxDateO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDateO.Location = new System.Drawing.Point(126, 416);
            this.textBoxDateO.Name = "textBoxDateO";
            this.textBoxDateO.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateO.TabIndex = 11;
            this.textBoxDateO.Enter += new System.EventHandler(this.textBoxDateO_Enter);
            // 
            // labelDateO
            // 
            this.labelDateO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDateO.AutoSize = true;
            this.labelDateO.Location = new System.Drawing.Point(15, 419);
            this.labelDateO.Name = "labelDateO";
            this.labelDateO.Size = new System.Drawing.Size(89, 13);
            this.labelDateO.TabIndex = 10;
            this.labelDateO.Text = "Дата окончания";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(618, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(618, 170);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 13;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // Mebel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxDateO);
            this.Controls.Add(this.labelDateO);
            this.Controls.Add(this.textBoxDateN);
            this.Controls.Add(this.labelDateN);
            this.Controls.Add(this.textBoxKodI);
            this.Controls.Add(this.labelKodI);
            this.Controls.Add(this.textBoxKodM);
            this.Controls.Add(this.labelKodM);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelIzgotoviteli);
            this.Controls.Add(this.labelMebeli);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mebel";
            this.Text = "Производство мебели";
            this.Load += new System.EventHandler(this.Mebel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебелиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовителиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MebelnayaMalyshevDataSet1 mebelnayaMalyshevDataSet1;
        private System.Windows.Forms.BindingSource мебелиBindingSource;
        private MebelnayaMalyshevDataSet1TableAdapters.МебелиTableAdapter мебелиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмебелиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наличиеDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource изготовителиBindingSource;
        private MebelnayaMalyshevDataSet1TableAdapters.ИзготовителиTableAdapter изготовителиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодизготовителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпользователяDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelMebeli;
        private System.Windows.Forms.Label labelIzgotoviteli;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelKodM;
        private System.Windows.Forms.TextBox textBoxKodM;
        private System.Windows.Forms.TextBox textBoxKodI;
        private System.Windows.Forms.Label labelKodI;
        private System.Windows.Forms.TextBox textBoxDateN;
        private System.Windows.Forms.Label labelDateN;
        private System.Windows.Forms.TextBox textBoxDateO;
        private System.Windows.Forms.Label labelDateO;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}