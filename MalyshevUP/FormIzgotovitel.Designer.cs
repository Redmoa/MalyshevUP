﻿namespace MalyshevUP
{
    partial class FormIzgotovitel
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
            this.кодпроизводстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодмебелиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодизготовителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаокончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производствоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mebelnayaMalyshevDataSetUpdated = new MalyshevUP.MebelnayaMalyshevDataSetUpdated();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодпродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодмебелиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценазаштукуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продажиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодкомплектующегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапоступленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelSklad = new System.Windows.Forms.Label();
            this.labelProizvodstvo = new System.Windows.Forms.Label();
            this.labelProdaji = new System.Windows.Forms.Label();
            this.buttonSklad = new System.Windows.Forms.Button();
            this.buttonProizvodstvo = new System.Windows.Forms.Button();
            this.buttonProdaja = new System.Windows.Forms.Button();
            this.buttonBackTo = new System.Windows.Forms.Button();
            this.продажиTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSetUpdatedTableAdapters.ПродажиTableAdapter();
            this.складTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSetUpdatedTableAdapters.СкладTableAdapter();
            this.производствоTableAdapter = new MalyshevUP.MebelnayaMalyshevDataSetUpdatedTableAdapters.ПроизводствоTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.производствоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSetUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпроизводстваDataGridViewTextBoxColumn,
            this.кодмебелиDataGridViewTextBoxColumn1,
            this.кодизготовителяDataGridViewTextBoxColumn,
            this.датаначалаDataGridViewTextBoxColumn,
            this.датаокончанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.производствоBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 311);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодпроизводстваDataGridViewTextBoxColumn
            // 
            this.кодпроизводстваDataGridViewTextBoxColumn.DataPropertyName = "Код_производства";
            this.кодпроизводстваDataGridViewTextBoxColumn.HeaderText = "Код_производства";
            this.кодпроизводстваDataGridViewTextBoxColumn.Name = "кодпроизводстваDataGridViewTextBoxColumn";
            this.кодпроизводстваDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодмебелиDataGridViewTextBoxColumn1
            // 
            this.кодмебелиDataGridViewTextBoxColumn1.DataPropertyName = "Код_мебели";
            this.кодмебелиDataGridViewTextBoxColumn1.HeaderText = "Код_мебели";
            this.кодмебелиDataGridViewTextBoxColumn1.Name = "кодмебелиDataGridViewTextBoxColumn1";
            // 
            // кодизготовителяDataGridViewTextBoxColumn
            // 
            this.кодизготовителяDataGridViewTextBoxColumn.DataPropertyName = "Код_изготовителя";
            this.кодизготовителяDataGridViewTextBoxColumn.HeaderText = "Код_изготовителя";
            this.кодизготовителяDataGridViewTextBoxColumn.Name = "кодизготовителяDataGridViewTextBoxColumn";
            // 
            // датаначалаDataGridViewTextBoxColumn
            // 
            this.датаначалаDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.HeaderText = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.Name = "датаначалаDataGridViewTextBoxColumn";
            // 
            // датаокончанияDataGridViewTextBoxColumn
            // 
            this.датаокончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата_окончания";
            this.датаокончанияDataGridViewTextBoxColumn.HeaderText = "Дата_окончания";
            this.датаокончанияDataGridViewTextBoxColumn.Name = "датаокончанияDataGridViewTextBoxColumn";
            // 
            // производствоBindingSource
            // 
            this.производствоBindingSource.DataMember = "Производство";
            this.производствоBindingSource.DataSource = this.mebelnayaMalyshevDataSetUpdated;
            // 
            // mebelnayaMalyshevDataSetUpdated
            // 
            this.mebelnayaMalyshevDataSetUpdated.DataSetName = "MebelnayaMalyshevDataSetUpdated";
            this.mebelnayaMalyshevDataSetUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпродажиDataGridViewTextBoxColumn,
            this.кодзаказаDataGridViewTextBoxColumn,
            this.кодмебелиDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценазаштукуDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.датапродажиDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.продажиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(713, 33);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(867, 439);
            this.dataGridView2.TabIndex = 1;
            // 
            // кодпродажиDataGridViewTextBoxColumn
            // 
            this.кодпродажиDataGridViewTextBoxColumn.DataPropertyName = "Код_продажи";
            this.кодпродажиDataGridViewTextBoxColumn.HeaderText = "Код_продажи";
            this.кодпродажиDataGridViewTextBoxColumn.Name = "кодпродажиDataGridViewTextBoxColumn";
            this.кодпродажиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодзаказаDataGridViewTextBoxColumn
            // 
            this.кодзаказаDataGridViewTextBoxColumn.DataPropertyName = "Код_заказа";
            this.кодзаказаDataGridViewTextBoxColumn.HeaderText = "Код_заказа";
            this.кодзаказаDataGridViewTextBoxColumn.Name = "кодзаказаDataGridViewTextBoxColumn";
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
            // ценазаштукуDataGridViewTextBoxColumn
            // 
            this.ценазаштукуDataGridViewTextBoxColumn.DataPropertyName = "Цена_за_штуку";
            this.ценазаштукуDataGridViewTextBoxColumn.HeaderText = "Цена_за_штуку";
            this.ценазаштукуDataGridViewTextBoxColumn.Name = "ценазаштукуDataGridViewTextBoxColumn";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // датапродажиDataGridViewTextBoxColumn
            // 
            this.датапродажиDataGridViewTextBoxColumn.DataPropertyName = "Дата_продажи";
            this.датапродажиDataGridViewTextBoxColumn.HeaderText = "Дата_продажи";
            this.датапродажиDataGridViewTextBoxColumn.Name = "датапродажиDataGridViewTextBoxColumn";
            // 
            // продажиBindingSource
            // 
            this.продажиBindingSource.DataMember = "Продажи";
            this.продажиBindingSource.DataSource = this.mebelnayaMalyshevDataSetUpdated;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодтовараDataGridViewTextBoxColumn,
            this.кодкомплектующегоDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn1,
            this.датапоступленияDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.складBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(14, 33);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(634, 162);
            this.dataGridView3.TabIndex = 2;
            // 
            // кодтовараDataGridViewTextBoxColumn
            // 
            this.кодтовараDataGridViewTextBoxColumn.DataPropertyName = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.HeaderText = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.Name = "кодтовараDataGridViewTextBoxColumn";
            this.кодтовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодкомплектующегоDataGridViewTextBoxColumn
            // 
            this.кодкомплектующегоDataGridViewTextBoxColumn.DataPropertyName = "Код_комплектующего";
            this.кодкомплектующегоDataGridViewTextBoxColumn.HeaderText = "Код_комплектующего";
            this.кодкомплектующегоDataGridViewTextBoxColumn.Name = "кодкомплектующегоDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn1
            // 
            this.количествоDataGridViewTextBoxColumn1.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn1.Name = "количествоDataGridViewTextBoxColumn1";
            // 
            // датапоступленияDataGridViewTextBoxColumn
            // 
            this.датапоступленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_поступления";
            this.датапоступленияDataGridViewTextBoxColumn.HeaderText = "Дата_поступления";
            this.датапоступленияDataGridViewTextBoxColumn.Name = "датапоступленияDataGridViewTextBoxColumn";
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.mebelnayaMalyshevDataSetUpdated;
            // 
            // labelSklad
            // 
            this.labelSklad.AutoSize = true;
            this.labelSklad.Location = new System.Drawing.Point(14, 16);
            this.labelSklad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSklad.Name = "labelSklad";
            this.labelSklad.Size = new System.Drawing.Size(132, 14);
            this.labelSklad.TabIndex = 3;
            this.labelSklad.Text = "Поступление на склад";
            // 
            // labelProizvodstvo
            // 
            this.labelProizvodstvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProizvodstvo.AutoSize = true;
            this.labelProizvodstvo.Location = new System.Drawing.Point(14, 294);
            this.labelProizvodstvo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProizvodstvo.Name = "labelProizvodstvo";
            this.labelProizvodstvo.Size = new System.Drawing.Size(132, 14);
            this.labelProizvodstvo.TabIndex = 3;
            this.labelProizvodstvo.Text = "Производство мебели";
            // 
            // labelProdaji
            // 
            this.labelProdaji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProdaji.AutoSize = true;
            this.labelProdaji.Location = new System.Drawing.Point(709, 16);
            this.labelProdaji.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProdaji.Name = "labelProdaji";
            this.labelProdaji.Size = new System.Drawing.Size(59, 14);
            this.labelProdaji.TabIndex = 3;
            this.labelProdaji.Text = "Продажи";
            // 
            // buttonSklad
            // 
            this.buttonSklad.Location = new System.Drawing.Point(14, 202);
            this.buttonSklad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSklad.Name = "buttonSklad";
            this.buttonSklad.Size = new System.Drawing.Size(257, 25);
            this.buttonSklad.TabIndex = 4;
            this.buttonSklad.Text = "Новое поступление комплектующих";
            this.buttonSklad.UseVisualStyleBackColor = true;
            this.buttonSklad.Click += new System.EventHandler(this.buttonSklad_Click);
            // 
            // buttonProizvodstvo
            // 
            this.buttonProizvodstvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProizvodstvo.Location = new System.Drawing.Point(14, 479);
            this.buttonProizvodstvo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonProizvodstvo.Name = "buttonProizvodstvo";
            this.buttonProizvodstvo.Size = new System.Drawing.Size(257, 25);
            this.buttonProizvodstvo.TabIndex = 4;
            this.buttonProizvodstvo.Text = "Изготовление новой мебели";
            this.buttonProizvodstvo.UseVisualStyleBackColor = true;
            this.buttonProizvodstvo.Click += new System.EventHandler(this.buttonProizvodstvo_Click);
            // 
            // buttonProdaja
            // 
            this.buttonProdaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProdaja.Location = new System.Drawing.Point(713, 479);
            this.buttonProdaja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonProdaja.Name = "buttonProdaja";
            this.buttonProdaja.Size = new System.Drawing.Size(257, 25);
            this.buttonProdaja.TabIndex = 4;
            this.buttonProdaja.Text = "Продажа мебели";
            this.buttonProdaja.UseVisualStyleBackColor = true;
            this.buttonProdaja.Click += new System.EventHandler(this.buttonProdaja_Click);
            // 
            // buttonBackTo
            // 
            this.buttonBackTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackTo.Location = new System.Drawing.Point(1323, 558);
            this.buttonBackTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBackTo.Name = "buttonBackTo";
            this.buttonBackTo.Size = new System.Drawing.Size(257, 25);
            this.buttonBackTo.TabIndex = 4;
            this.buttonBackTo.Text = "Назад";
            this.buttonBackTo.UseVisualStyleBackColor = true;
            this.buttonBackTo.Click += new System.EventHandler(this.buttonBackTo_Click);
            // 
            // продажиTableAdapter
            // 
            this.продажиTableAdapter.ClearBeforeFill = true;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // производствоTableAdapter
            // 
            this.производствоTableAdapter.ClearBeforeFill = true;
            // 
            // FormIzgotovitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1594, 596);
            this.Controls.Add(this.buttonBackTo);
            this.Controls.Add(this.buttonProdaja);
            this.Controls.Add(this.buttonProizvodstvo);
            this.Controls.Add(this.buttonSklad);
            this.Controls.Add(this.labelProizvodstvo);
            this.Controls.Add(this.labelProdaji);
            this.Controls.Add(this.labelSklad);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1610, 635);
            this.Name = "FormIzgotovitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изготовитель";
            this.Load += new System.EventHandler(this.FormIzgotovitel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.производствоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelnayaMalyshevDataSetUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label labelSklad;
        private System.Windows.Forms.Label labelProizvodstvo;
        private System.Windows.Forms.Label labelProdaji;
        private System.Windows.Forms.Button buttonSklad;
        private System.Windows.Forms.Button buttonProizvodstvo;
        private System.Windows.Forms.Button buttonProdaja;
        private System.Windows.Forms.Button buttonBackTo;
        private MebelnayaMalyshevDataSetUpdated mebelnayaMalyshevDataSetUpdated;
        private System.Windows.Forms.BindingSource продажиBindingSource;
        private MebelnayaMalyshevDataSetUpdatedTableAdapters.ПродажиTableAdapter продажиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмебелиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценазаштукуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource складBindingSource;
        private MebelnayaMalyshevDataSetUpdatedTableAdapters.СкладTableAdapter складTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкомплектующегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапоступленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource производствоBindingSource;
        private MebelnayaMalyshevDataSetUpdatedTableAdapters.ПроизводствоTableAdapter производствоTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпроизводстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмебелиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодизготовителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаокончанияDataGridViewTextBoxColumn;
    }
}