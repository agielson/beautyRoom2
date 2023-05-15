namespace BeautyRoom
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.showButton = new Guna.UI.WinForms.GunaButton();
            this.saveButton = new Guna.UI.WinForms.GunaButton();
            this.deleteButton = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.addButton = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Chsoose_date = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_choose_service = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_check_master = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2_top = new Guna.UI.WinForms.GunaPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Pink;
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Controls.Add(this.gunaButton_Chsoose_date);
            this.gunaPanel1.Controls.Add(this.gunaButton_choose_service);
            this.gunaPanel1.Controls.Add(this.gunaButton_check_master);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(272, 575);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPanel2.Controls.Add(this.gunaButton1);
            this.gunaPanel2.Controls.Add(this.showButton);
            this.gunaPanel2.Controls.Add(this.saveButton);
            this.gunaPanel2.Controls.Add(this.deleteButton);
            this.gunaPanel2.Controls.Add(this.label2);
            this.gunaPanel2.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel2.Controls.Add(this.addButton);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(272, 575);
            this.gunaPanel2.TabIndex = 4;
            // 
            // showButton
            // 
            this.showButton.Animated = true;
            this.showButton.AnimationHoverSpeed = 0.07F;
            this.showButton.AnimationSpeed = 0.03F;
            this.showButton.BaseColor = System.Drawing.Color.Maroon;
            this.showButton.BorderColor = System.Drawing.Color.Black;
            this.showButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.showButton.FocusedColor = System.Drawing.Color.Empty;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.showButton.Image = null;
            this.showButton.ImageSize = new System.Drawing.Size(20, 20);
            this.showButton.Location = new System.Drawing.Point(3, 179);
            this.showButton.Name = "showButton";
            this.showButton.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.showButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.showButton.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.showButton.OnHoverImage = null;
            this.showButton.OnPressedColor = System.Drawing.Color.Black;
            this.showButton.Size = new System.Drawing.Size(270, 50);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Список услуг";
            this.showButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AnimationHoverSpeed = 0.07F;
            this.saveButton.AnimationSpeed = 0.03F;
            this.saveButton.BaseColor = System.Drawing.Color.Maroon;
            this.saveButton.BorderColor = System.Drawing.Color.Black;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveButton.FocusedColor = System.Drawing.Color.Empty;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveButton.Image = null;
            this.saveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.saveButton.Location = new System.Drawing.Point(-1, 423);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.saveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.saveButton.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveButton.OnHoverImage = null;
            this.saveButton.OnPressedColor = System.Drawing.Color.Black;
            this.saveButton.Size = new System.Drawing.Size(270, 50);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить Услугу";
            this.saveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteButton
            // 
            this.deleteButton.AnimationHoverSpeed = 0.07F;
            this.deleteButton.AnimationSpeed = 0.03F;
            this.deleteButton.BaseColor = System.Drawing.Color.Maroon;
            this.deleteButton.BorderColor = System.Drawing.Color.Black;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteButton.FocusedColor = System.Drawing.Color.Empty;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Image = null;
            this.deleteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteButton.Location = new System.Drawing.Point(2, 340);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.deleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.OnHoverImage = null;
            this.deleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteButton.Size = new System.Drawing.Size(270, 50);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить Услугу";
            this.deleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "BeautyRoom";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(75, 3);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(103, 75);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 7;
            this.gunaPictureBox2.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Animated = true;
            this.addButton.AnimationHoverSpeed = 0.07F;
            this.addButton.AnimationSpeed = 0.03F;
            this.addButton.BaseColor = System.Drawing.Color.Maroon;
            this.addButton.BorderColor = System.Drawing.Color.Black;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addButton.FocusedColor = System.Drawing.Color.Empty;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Image = null;
            this.addButton.ImageSize = new System.Drawing.Size(20, 20);
            this.addButton.Location = new System.Drawing.Point(0, 254);
            this.addButton.Name = "addButton";
            this.addButton.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.addButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addButton.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.OnHoverImage = null;
            this.addButton.OnPressedColor = System.Drawing.Color.Black;
            this.addButton.Size = new System.Drawing.Size(270, 50);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить Услугу";
            this.addButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addButton.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // gunaButton_Chsoose_date
            // 
            this.gunaButton_Chsoose_date.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Chsoose_date.AnimationSpeed = 0.03F;
            this.gunaButton_Chsoose_date.BaseColor = System.Drawing.Color.Pink;
            this.gunaButton_Chsoose_date.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Chsoose_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton_Chsoose_date.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Chsoose_date.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton_Chsoose_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton_Chsoose_date.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Chsoose_date.Image = null;
            this.gunaButton_Chsoose_date.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Chsoose_date.Location = new System.Drawing.Point(0, 362);
            this.gunaButton_Chsoose_date.Name = "gunaButton_Chsoose_date";
            this.gunaButton_Chsoose_date.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton_Chsoose_date.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton_Chsoose_date.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton_Chsoose_date.OnHoverImage = null;
            this.gunaButton_Chsoose_date.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton_Chsoose_date.Size = new System.Drawing.Size(272, 42);
            this.gunaButton_Chsoose_date.TabIndex = 3;
            this.gunaButton_Chsoose_date.Text = "Выбрать Дату";
            // 
            // gunaButton_choose_service
            // 
            this.gunaButton_choose_service.AnimationHoverSpeed = 0.07F;
            this.gunaButton_choose_service.AnimationSpeed = 0.03F;
            this.gunaButton_choose_service.BaseColor = System.Drawing.Color.Pink;
            this.gunaButton_choose_service.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_choose_service.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton_choose_service.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_choose_service.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton_choose_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton_choose_service.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_choose_service.Image = null;
            this.gunaButton_choose_service.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_choose_service.Location = new System.Drawing.Point(0, 280);
            this.gunaButton_choose_service.Name = "gunaButton_choose_service";
            this.gunaButton_choose_service.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton_choose_service.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton_choose_service.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton_choose_service.OnHoverImage = null;
            this.gunaButton_choose_service.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton_choose_service.Size = new System.Drawing.Size(272, 42);
            this.gunaButton_choose_service.TabIndex = 2;
            this.gunaButton_choose_service.Text = "Выбрать Услугу";
            // 
            // gunaButton_check_master
            // 
            this.gunaButton_check_master.AnimationHoverSpeed = 0.07F;
            this.gunaButton_check_master.AnimationSpeed = 0.03F;
            this.gunaButton_check_master.BaseColor = System.Drawing.Color.Pink;
            this.gunaButton_check_master.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_check_master.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton_check_master.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_check_master.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton_check_master.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton_check_master.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_check_master.Image = null;
            this.gunaButton_check_master.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_check_master.Location = new System.Drawing.Point(0, 197);
            this.gunaButton_check_master.Name = "gunaButton_check_master";
            this.gunaButton_check_master.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaButton_check_master.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton_check_master.OnHoverForeColor = System.Drawing.Color.LightCoral;
            this.gunaButton_check_master.OnHoverImage = null;
            this.gunaButton_check_master.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton_check_master.Size = new System.Drawing.Size(272, 42);
            this.gunaButton_check_master.TabIndex = 1;
            this.gunaButton_check_master.Text = "Выбрать Мастера";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(22, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel2_top
            // 
            this.gunaPanel2_top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPanel2_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2_top.Location = new System.Drawing.Point(272, 0);
            this.gunaPanel2_top.Name = "gunaPanel2_top";
            this.gunaPanel2_top.Size = new System.Drawing.Size(837, 53);
            this.gunaPanel2_top.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 370);
            this.dataGridView1.TabIndex = 3;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(22, 513);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(217, 38);
            this.gunaButton1.TabIndex = 12;
            this.gunaButton1.Text = "Выйти";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunaPanel2_top);
            this.Controls.Add(this.gunaPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeautyRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gunaButton_Chsoose_date;
        private Guna.UI.WinForms.GunaButton gunaButton_choose_service;
        private Guna.UI.WinForms.GunaButton gunaButton_check_master;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton addButton;
        private Guna.UI.WinForms.GunaPanel gunaPanel2_top;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton saveButton;
        private Guna.UI.WinForms.GunaButton deleteButton;
        private Guna.UI.WinForms.GunaButton showButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}