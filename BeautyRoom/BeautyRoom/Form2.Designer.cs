namespace BeautyRoom
{
    partial class BeautyRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeautyRoom));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.DataTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.PceTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.MrTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.SvTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.IDTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPanel1.Controls.Add(this.gunaCheckBox1);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel6);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.DataTextBox);
            this.gunaPanel1.Controls.Add(this.PceTextBox);
            this.gunaPanel1.Controls.Add(this.MrTextBox);
            this.gunaPanel1.Controls.Add(this.SvTextBox);
            this.gunaPanel1.Controls.Add(this.IDTextBox);
            this.gunaPanel1.Controls.Add(this.gunaButton4);
            this.gunaPanel1.Controls.Add(this.gunaButton3);
            this.gunaPanel1.Controls.Add(this.gunaButton2);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(2, -1);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(316, 619);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Maroon;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.Maroon;
            this.gunaCheckBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gunaCheckBox1.Location = new System.Drawing.Point(68, 538);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(159, 20);
            this.gunaCheckBox1.TabIndex = 21;
            this.gunaCheckBox1.Text = "Подтвердите запись";
            this.gunaCheckBox1.CheckedChanged += new System.EventHandler(this.gunaCheckBox1_CheckedChanged);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPanel2.Location = new System.Drawing.Point(314, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(877, 33);
            this.gunaPanel2.TabIndex = 2;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(123, 416);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(41, 20);
            this.gunaLabel6.TabIndex = 20;
            this.gunaLabel6.Text = "Дата";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(130, 353);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(45, 20);
            this.gunaLabel5.TabIndex = 19;
            this.gunaLabel5.Text = "Цена";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(121, 285);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(60, 20);
            this.gunaLabel4.TabIndex = 18;
            this.gunaLabel4.Text = "Мастер";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(123, 208);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel3.TabIndex = 17;
            this.gunaLabel3.Text = "Услуга";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(123, 150);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(72, 20);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "ID услуги";
            // 
            // DataTextBox
            // 
            this.DataTextBox.BaseColor = System.Drawing.Color.White;
            this.DataTextBox.BorderColor = System.Drawing.Color.Silver;
            this.DataTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DataTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.DataTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.DataTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataTextBox.Location = new System.Drawing.Point(68, 439);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.PasswordChar = '\0';
            this.DataTextBox.SelectedText = "";
            this.DataTextBox.Size = new System.Drawing.Size(180, 32);
            this.DataTextBox.TabIndex = 15;
            // 
            // PceTextBox
            // 
            this.PceTextBox.BaseColor = System.Drawing.Color.White;
            this.PceTextBox.BorderColor = System.Drawing.Color.Silver;
            this.PceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PceTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.PceTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PceTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PceTextBox.Location = new System.Drawing.Point(68, 376);
            this.PceTextBox.Name = "PceTextBox";
            this.PceTextBox.PasswordChar = '\0';
            this.PceTextBox.SelectedText = "";
            this.PceTextBox.Size = new System.Drawing.Size(180, 32);
            this.PceTextBox.TabIndex = 14;
            // 
            // MrTextBox
            // 
            this.MrTextBox.BaseColor = System.Drawing.Color.White;
            this.MrTextBox.BorderColor = System.Drawing.Color.Silver;
            this.MrTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MrTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.MrTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MrTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.MrTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MrTextBox.Location = new System.Drawing.Point(68, 308);
            this.MrTextBox.Name = "MrTextBox";
            this.MrTextBox.PasswordChar = '\0';
            this.MrTextBox.SelectedText = "";
            this.MrTextBox.Size = new System.Drawing.Size(180, 32);
            this.MrTextBox.TabIndex = 13;
            // 
            // SvTextBox
            // 
            this.SvTextBox.BaseColor = System.Drawing.Color.White;
            this.SvTextBox.BorderColor = System.Drawing.Color.Silver;
            this.SvTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SvTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.SvTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SvTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SvTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SvTextBox.Location = new System.Drawing.Point(68, 236);
            this.SvTextBox.Name = "SvTextBox";
            this.SvTextBox.PasswordChar = '\0';
            this.SvTextBox.SelectedText = "";
            this.SvTextBox.Size = new System.Drawing.Size(180, 32);
            this.SvTextBox.TabIndex = 12;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BaseColor = System.Drawing.Color.White;
            this.IDTextBox.BorderColor = System.Drawing.Color.Silver;
            this.IDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.IDTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.IDTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.IDTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDTextBox.Location = new System.Drawing.Point(68, 173);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.PasswordChar = '\0';
            this.IDTextBox.SelectedText = "";
            this.IDTextBox.Size = new System.Drawing.Size(180, 32);
            this.IDTextBox.TabIndex = 11;
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(68, 52);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(180, 35);
            this.gunaButton4.TabIndex = 10;
            this.gunaButton4.Text = "Каталог записей";
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(68, 574);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(180, 35);
            this.gunaButton3.TabIndex = 9;
            this.gunaButton3.Text = "Выйти";
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
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
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(68, 488);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(180, 35);
            this.gunaButton2.TabIndex = 8;
            this.gunaButton2.Text = "Записаться";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(68, 102);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(180, 35);
            this.gunaButton1.TabIndex = 7;
            this.gunaButton1.Text = "Мои записи";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("PMingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.gunaLabel1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.gunaLabel1.Location = new System.Drawing.Point(73, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(161, 28);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "BeautyRoom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 382);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BeautyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1105, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunaPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BeautyRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeautyRoom";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox DataTextBox;
        private Guna.UI.WinForms.GunaTextBox PceTextBox;
        private Guna.UI.WinForms.GunaTextBox MrTextBox;
        private Guna.UI.WinForms.GunaTextBox SvTextBox;
        private Guna.UI.WinForms.GunaTextBox IDTextBox;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
    }
}