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
            this.UpDateButton = new Guna.UI.WinForms.GunaButton();
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMaster = new System.Windows.Forms.TextBox();
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.gunaButtonSave = new Guna.UI.WinForms.GunaButton();
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
            this.gunaPanel2.Controls.Add(this.gunaButtonSave);
            this.gunaPanel2.Controls.Add(this.showButton);
            this.gunaPanel2.Controls.Add(this.UpDateButton);
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
            this.showButton.Location = new System.Drawing.Point(3, 168);
            this.showButton.Name = "showButton";
            this.showButton.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.showButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.showButton.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.showButton.OnHoverImage = null;
            this.showButton.OnPressedColor = System.Drawing.Color.Black;
            this.showButton.Size = new System.Drawing.Size(270, 50);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Показать Мастера";
            this.showButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // UpDateButton
            // 
            this.UpDateButton.AnimationHoverSpeed = 0.07F;
            this.UpDateButton.AnimationSpeed = 0.03F;
            this.UpDateButton.BaseColor = System.Drawing.Color.Maroon;
            this.UpDateButton.BorderColor = System.Drawing.Color.Black;
            this.UpDateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpDateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpDateButton.FocusedColor = System.Drawing.Color.Empty;
            this.UpDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpDateButton.Image = null;
            this.UpDateButton.ImageSize = new System.Drawing.Size(20, 20);
            this.UpDateButton.Location = new System.Drawing.Point(-1, 445);
            this.UpDateButton.Name = "UpDateButton";
            this.UpDateButton.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.UpDateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UpDateButton.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpDateButton.OnHoverImage = null;
            this.UpDateButton.OnPressedColor = System.Drawing.Color.Black;
            this.UpDateButton.Size = new System.Drawing.Size(270, 50);
            this.UpDateButton.TabIndex = 10;
            this.UpDateButton.Text = "Изменить Мастера";
            this.UpDateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDateButton.Click += new System.EventHandler(this.UpDateButton_Click);
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
            this.deleteButton.Location = new System.Drawing.Point(-1, 362);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.deleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.OnHoverImage = null;
            this.deleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteButton.Size = new System.Drawing.Size(270, 50);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить Мастера";
            this.deleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(29, 125);
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
            this.gunaPictureBox2.Size = new System.Drawing.Size(106, 100);
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
            this.addButton.Location = new System.Drawing.Point(0, 245);
            this.addButton.Name = "addButton";
            this.addButton.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.addButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addButton.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.OnHoverImage = null;
            this.addButton.OnPressedColor = System.Drawing.Color.Black;
            this.addButton.Size = new System.Drawing.Size(270, 50);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить Мастера";
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
            this.gunaPanel2_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2_top.Location = new System.Drawing.Point(272, 0);
            this.gunaPanel2_top.Name = "gunaPanel2_top";
            this.gunaPanel2_top.Size = new System.Drawing.Size(837, 53);
            this.gunaPanel2_top.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 296);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(368, 113);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(529, 113);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxMaster
            // 
            this.textBoxMaster.Location = new System.Drawing.Point(709, 113);
            this.textBoxMaster.Name = "textBoxMaster";
            this.textBoxMaster.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaster.TabIndex = 6;
            this.textBoxMaster.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.Location = new System.Drawing.Point(909, 113);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrise.TabIndex = 7;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(637, 162);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxDate.TabIndex = 8;
            // 
            // gunaButtonSave
            // 
            this.gunaButtonSave.Animated = true;
            this.gunaButtonSave.AnimationHoverSpeed = 0.07F;
            this.gunaButtonSave.AnimationSpeed = 0.03F;
            this.gunaButtonSave.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButtonSave.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButtonSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonSave.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButtonSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButtonSave.Image = null;
            this.gunaButtonSave.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonSave.Location = new System.Drawing.Point(-1, 301);
            this.gunaButtonSave.Name = "gunaButtonSave";
            this.gunaButtonSave.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.gunaButtonSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonSave.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButtonSave.OnHoverImage = null;
            this.gunaButtonSave.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonSave.Size = new System.Drawing.Size(270, 50);
            this.gunaButtonSave.TabIndex = 12;
            this.gunaButtonSave.Text = "Сохранить Мастера";
            this.gunaButtonSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonSave.Click += new System.EventHandler(this.gunaButtonSave_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 575);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxPrise);
            this.Controls.Add(this.textBoxMaster);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
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
            this.PerformLayout();

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
        private Guna.UI.WinForms.GunaButton UpDateButton;
        private Guna.UI.WinForms.GunaButton deleteButton;
        private Guna.UI.WinForms.GunaButton showButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMaster;
        private System.Windows.Forms.TextBox textBoxPrise;
        private System.Windows.Forms.TextBox textBoxDate;
        private Guna.UI.WinForms.GunaButton gunaButtonSave;
    }
}