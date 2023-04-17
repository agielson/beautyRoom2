<<<<<<< HEAD
namespace BeautyRoom
=======
﻿
namespace BeautyRoom

>>>>>>> Привязка к окнам пользователя и админа
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.NumberTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.PasswordTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.LoginButton = new Guna.UI.WinForms.GunaButton();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
<<<<<<< HEAD
            this.SignUpButton = new Guna.UI.WinForms.GunaButton();
            this.NameTextBox = new Guna.UI.WinForms.GunaTextBox();
=======
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
>>>>>>> Привязка к окнам пользователя и админа
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(377, -12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(566, 618);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
<<<<<<< HEAD
            // NumberTextBox
            // 
            this.NumberTextBox.BaseColor = System.Drawing.Color.White;
            this.NumberTextBox.BorderColor = System.Drawing.Color.Silver;
            this.NumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.NumberTextBox.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.NumberTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.NumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumberTextBox.Location = new System.Drawing.Point(67, 230);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.PasswordChar = '\0';
            this.NumberTextBox.SelectedText = "";
            this.NumberTextBox.Size = new System.Drawing.Size(250, 35);
            this.NumberTextBox.TabIndex = 1;
            this.NumberTextBox.Text = "Номер телефона";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BaseColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Silver;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.PasswordTextBox.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.PasswordTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextBox.Location = new System.Drawing.Point(67, 285);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 35);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.Text = "Пароль";
=======
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(94, 220);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(250, 35);
            this.gunaTextBox1.TabIndex = 1;
            this.gunaTextBox1.Text = "User";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(94, 307);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '*';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(250, 35);
            this.gunaTextBox2.TabIndex = 2;
            this.gunaTextBox2.Text = "Пароль";
>>>>>>> Привязка к окнам пользователя и админа
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добро пожаловать в";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(79, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "BeautyRoom";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(127, 2);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(98, 89);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 5;
            this.gunaPictureBox2.TabStop = false;
            // 
<<<<<<< HEAD
            // LoginButton
            // 
            this.LoginButton.AnimationHoverSpeed = 0.07F;
            this.LoginButton.AnimationSpeed = 0.03F;
            this.LoginButton.BaseColor = System.Drawing.Color.Maroon;
            this.LoginButton.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginButton.FocusedColor = System.Drawing.Color.Empty;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.Snow;
            this.LoginButton.Image = null;
            this.LoginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginButton.Location = new System.Drawing.Point(100, 381);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginButton.OnHoverImage = null;
            this.LoginButton.OnPressedColor = System.Drawing.Color.Black;
            this.LoginButton.Size = new System.Drawing.Size(125, 45);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "       Войти";
            this.LoginButton.Click += new System.EventHandler(this.gunaButton1_Click);
=======
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.Snow;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(94, 394);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(86, 45);
            this.gunaButton1.TabIndex = 8;
            this.gunaButton1.Text = "       Войти";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
>>>>>>> Привязка к окнам пользователя и админа
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.Maroon;
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.gunaCheckBox1.Location = new System.Drawing.Point(67, 339);
=======
            this.gunaCheckBox1.Location = new System.Drawing.Point(94, 348);
>>>>>>> Привязка к окнам пользователя и админа
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(168, 20);
            this.gunaCheckBox1.TabIndex = 9;
            this.gunaCheckBox1.Text = "Роль администратора";
            // 
            // SignUpButton
            // 
            this.SignUpButton.AnimationHoverSpeed = 0.07F;
            this.SignUpButton.AnimationSpeed = 0.03F;
            this.SignUpButton.BaseColor = System.Drawing.Color.Maroon;
            this.SignUpButton.BorderColor = System.Drawing.Color.Black;
            this.SignUpButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignUpButton.FocusedColor = System.Drawing.Color.Empty;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUpButton.ForeColor = System.Drawing.Color.Snow;
            this.SignUpButton.Image = null;
            this.SignUpButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SignUpButton.Location = new System.Drawing.Point(47, 443);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.SignUpButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SignUpButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SignUpButton.OnHoverImage = null;
            this.SignUpButton.OnPressedColor = System.Drawing.Color.Black;
            this.SignUpButton.Size = new System.Drawing.Size(270, 45);
            this.SignUpButton.TabIndex = 10;
            this.SignUpButton.Text = " Нет аккуанта? Зарегистрируйтесь";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BaseColor = System.Drawing.Color.White;
            this.NameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.NameTextBox.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.NameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTextBox.Location = new System.Drawing.Point(67, 178);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(250, 35);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.Text = "Имя";
            this.NameTextBox.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox3.Location = new System.Drawing.Point(94, 266);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.SelectedText = "";
            this.gunaTextBox3.Size = new System.Drawing.Size(250, 35);
            this.gunaTextBox3.TabIndex = 10;
            this.gunaTextBox3.Text = "Number";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.Snow;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(246, 394);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(98, 45);
            this.gunaButton2.TabIndex = 11;
            this.gunaButton2.Text = "Регистрация";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(950, 519);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SignUpButton);
=======
            this.ClientSize = new System.Drawing.Size(1109, 575);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaTextBox3);
>>>>>>> Привязка к окнам пользователя и админа
            this.Controls.Add(this.gunaCheckBox1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.gunaPictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeautyRoom";
   
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaTextBox NumberTextBox;
        private Guna.UI.WinForms.GunaTextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaButton LoginButton;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
<<<<<<< HEAD
        private Guna.UI.WinForms.GunaButton SignUpButton;
        private Guna.UI.WinForms.GunaTextBox NameTextBox;
=======
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
>>>>>>> Привязка к окнам пользователя и админа
    }
}



