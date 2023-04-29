namespace MalyshevUP
{
    partial class FormRegistration
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonBackTo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClean = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAgain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLogin.Location = new System.Drawing.Point(467, 97);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(140, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(467, 142);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(140, 22);
            this.textBoxPassword.TabIndex = 0;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Покупатель",
            "Изготовитель"});
            this.comboBoxRole.Location = new System.Drawing.Point(467, 233);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(140, 22);
            this.comboBoxRole.TabIndex = 1;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegister.Location = new System.Drawing.Point(396, 297);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(141, 25);
            this.buttonRegister.TabIndex = 2;
            this.buttonRegister.Text = "Зарегистрировать";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonBackTo
            // 
            this.buttonBackTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBackTo.Location = new System.Drawing.Point(396, 360);
            this.buttonBackTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBackTo.Name = "buttonBackTo";
            this.buttonBackTo.Size = new System.Drawing.Size(141, 25);
            this.buttonBackTo.TabIndex = 3;
            this.buttonBackTo.Text = "Назад";
            this.buttonBackTo.UseVisualStyleBackColor = true;
            this.buttonBackTo.Click += new System.EventHandler(this.buttonBackTo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Роль:";
            // 
            // buttonClean
            // 
            this.buttonClean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClean.Location = new System.Drawing.Point(396, 328);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(141, 25);
            this.buttonClean.TabIndex = 2;
            this.buttonClean.Text = "Очистить";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Повторите пароль:";
            // 
            // textBoxAgain
            // 
            this.textBoxAgain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAgain.Location = new System.Drawing.Point(467, 186);
            this.textBoxAgain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAgain.Name = "textBoxAgain";
            this.textBoxAgain.Size = new System.Drawing.Size(140, 22);
            this.textBoxAgain.TabIndex = 0;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBackTo);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxAgain);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonBackTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAgain;
    }
}