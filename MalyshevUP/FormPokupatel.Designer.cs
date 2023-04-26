namespace MalyshevUP
{
    partial class FormPokupatel
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
            this.кодмебелиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.мебелиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mebelnayaMalyshevDataSet = new MalyshevUP.MebelnayaMalyshevDataSet();
            this.мебелиTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSetTableAdapters.МебелиTableAdapter();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonToOrder = new System.Windows.Forms.Button();
            this.radioButtonCheck = new System.Windows.Forms.RadioButton();
            this.radioButtonUncheck = new System.Windows.Forms.RadioButton();
            this.radioButtonViewAll = new System.Windows.Forms.RadioButton();
            this.buttonBackTo = new System.Windows.Forms.Button();
            this.labelKodMebel = new System.Windows.Forms.Label();
            this.textBoxKodMebeli = new System.Windows.Forms.TextBox();
            this.labelKolich = new System.Windows.Forms.Label();
            this.textBoxKolich = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебелиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dataGridView1.Location = new System.Drawing.Point(47, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(703, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодмебелиDataGridViewTextBoxColumn
            // 
            this.кодмебелиDataGridViewTextBoxColumn.DataPropertyName = "Код_мебели";
            this.кодмебелиDataGridViewTextBoxColumn.HeaderText = "Код_мебели";
            this.кодмебелиDataGridViewTextBoxColumn.Name = "кодмебелиDataGridViewTextBoxColumn";
            this.кодмебелиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наличиеDataGridViewCheckBoxColumn
            // 
            this.наличиеDataGridViewCheckBoxColumn.DataPropertyName = "Наличие";
            this.наличиеDataGridViewCheckBoxColumn.HeaderText = "Наличие";
            this.наличиеDataGridViewCheckBoxColumn.Name = "наличиеDataGridViewCheckBoxColumn";
            this.наличиеDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // мебелиBindingSource
            // 
            this.мебелиBindingSource.DataMember = "Мебели";
            this.мебелиBindingSource.DataSource = this.mebelnayaMalyshevDataSet;
            // 
            // mebelnayaMalyshevDataSet
            // 
            this.mebelnayaMalyshevDataSet.DataSetName = "MebelnayaMalyshevDataSet";
            this.mebelnayaMalyshevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // мебелиTableAdapter
            // 
            this.мебелиTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(181, 52);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(121, 20);
            this.textBoxFind.TabIndex = 1;
            // 
            // buttonToOrder
            // 
            this.buttonToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonToOrder.Location = new System.Drawing.Point(226, 311);
            this.buttonToOrder.Name = "buttonToOrder";
            this.buttonToOrder.Size = new System.Drawing.Size(121, 23);
            this.buttonToOrder.TabIndex = 3;
            this.buttonToOrder.Text = "Заказать мебель";
            this.buttonToOrder.UseVisualStyleBackColor = true;
            this.buttonToOrder.Click += new System.EventHandler(this.buttonToOrder_Click);
            // 
            // radioButtonCheck
            // 
            this.radioButtonCheck.AutoSize = true;
            this.radioButtonCheck.Location = new System.Drawing.Point(321, 53);
            this.radioButtonCheck.Name = "radioButtonCheck";
            this.radioButtonCheck.Size = new System.Drawing.Size(76, 17);
            this.radioButtonCheck.TabIndex = 4;
            this.radioButtonCheck.TabStop = true;
            this.radioButtonCheck.Text = "В наличии";
            this.radioButtonCheck.UseVisualStyleBackColor = true;
            this.radioButtonCheck.CheckedChanged += new System.EventHandler(this.radioButtonCheck_CheckedChanged);
            // 
            // radioButtonUncheck
            // 
            this.radioButtonUncheck.AutoSize = true;
            this.radioButtonUncheck.Location = new System.Drawing.Point(403, 53);
            this.radioButtonUncheck.Name = "radioButtonUncheck";
            this.radioButtonUncheck.Size = new System.Drawing.Size(97, 17);
            this.radioButtonUncheck.TabIndex = 4;
            this.radioButtonUncheck.TabStop = true;
            this.radioButtonUncheck.Text = "Нет в наличии";
            this.radioButtonUncheck.UseVisualStyleBackColor = true;
            this.radioButtonUncheck.CheckedChanged += new System.EventHandler(this.radioButtonUncheck_CheckedChanged);
            // 
            // radioButtonViewAll
            // 
            this.radioButtonViewAll.AutoSize = true;
            this.radioButtonViewAll.Location = new System.Drawing.Point(506, 53);
            this.radioButtonViewAll.Name = "radioButtonViewAll";
            this.radioButtonViewAll.Size = new System.Drawing.Size(44, 17);
            this.radioButtonViewAll.TabIndex = 4;
            this.radioButtonViewAll.TabStop = true;
            this.radioButtonViewAll.Text = "Все";
            this.radioButtonViewAll.UseVisualStyleBackColor = true;
            this.radioButtonViewAll.CheckedChanged += new System.EventHandler(this.radioButtonViewAll_CheckedChanged);
            // 
            // buttonBackTo
            // 
            this.buttonBackTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackTo.Location = new System.Drawing.Point(629, 313);
            this.buttonBackTo.Name = "buttonBackTo";
            this.buttonBackTo.Size = new System.Drawing.Size(121, 23);
            this.buttonBackTo.TabIndex = 5;
            this.buttonBackTo.Text = "Назад";
            this.buttonBackTo.UseVisualStyleBackColor = true;
            this.buttonBackTo.Click += new System.EventHandler(this.buttonBackTo_Click);
            // 
            // labelKodMebel
            // 
            this.labelKodMebel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKodMebel.AutoSize = true;
            this.labelKodMebel.Location = new System.Drawing.Point(44, 316);
            this.labelKodMebel.Name = "labelKodMebel";
            this.labelKodMebel.Size = new System.Drawing.Size(114, 13);
            this.labelKodMebel.TabIndex = 6;
            this.labelKodMebel.Text = "Введите код мебели:";
            // 
            // textBoxKodMebeli
            // 
            this.textBoxKodMebeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxKodMebeli.Location = new System.Drawing.Point(179, 313);
            this.textBoxKodMebeli.Name = "textBoxKodMebeli";
            this.textBoxKodMebeli.Size = new System.Drawing.Size(34, 20);
            this.textBoxKodMebeli.TabIndex = 7;
            // 
            // labelKolich
            // 
            this.labelKolich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKolich.AutoSize = true;
            this.labelKolich.Location = new System.Drawing.Point(44, 342);
            this.labelKolich.Name = "labelKolich";
            this.labelKolich.Size = new System.Drawing.Size(129, 13);
            this.labelKolich.TabIndex = 6;
            this.labelKolich.Text = "Введите кол-во мебели:";
            // 
            // textBoxKolich
            // 
            this.textBoxKolich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxKolich.Location = new System.Drawing.Point(179, 339);
            this.textBoxKolich.Name = "textBoxKolich";
            this.textBoxKolich.Size = new System.Drawing.Size(34, 20);
            this.textBoxKolich.TabIndex = 7;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(47, 50);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(121, 23);
            this.buttonFind.TabIndex = 8;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // FormPokupatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxKolich);
            this.Controls.Add(this.textBoxKodMebeli);
            this.Controls.Add(this.labelKolich);
            this.Controls.Add(this.labelKodMebel);
            this.Controls.Add(this.buttonBackTo);
            this.Controls.Add(this.radioButtonViewAll);
            this.Controls.Add(this.radioButtonUncheck);
            this.Controls.Add(this.radioButtonCheck);
            this.Controls.Add(this.buttonToOrder);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPokupatel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупатель";
            this.Load += new System.EventHandler(this.FormPokupatel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебелиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MebelnayaMalyshevDataSet mebelnayaMalyshevDataSet;
        private System.Windows.Forms.BindingSource мебелиBindingSource;
        private MebelnayaMalyshevDataSetTableAdapters.МебелиTableAdapter мебелиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмебелиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наличиеDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonToOrder;
        private System.Windows.Forms.RadioButton radioButtonCheck;
        private System.Windows.Forms.RadioButton radioButtonUncheck;
        private System.Windows.Forms.RadioButton radioButtonViewAll;
        private System.Windows.Forms.Button buttonBackTo;
        private System.Windows.Forms.Label labelKodMebel;
        private System.Windows.Forms.TextBox textBoxKodMebeli;
        private System.Windows.Forms.Label labelKolich;
        private System.Windows.Forms.TextBox textBoxKolich;
        private System.Windows.Forms.Button buttonFind;
    }
}