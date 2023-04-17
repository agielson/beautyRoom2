namespace BeautyRoom
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton_Chsoose_date = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_choose_service = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_check_master = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2_top = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Pink;
            this.gunaPanel1.Controls.Add(this.gunaButton_Chsoose_date);
            this.gunaPanel1.Controls.Add(this.gunaButton_choose_service);
            this.gunaPanel1.Controls.Add(this.gunaButton_check_master);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(272, 707);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
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
            this.gunaButton_Chsoose_date.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.gunaButton_choose_service.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.gunaButton_check_master.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.gunaButton_check_master.Click += new System.EventHandler(this.gunaButton_check_master_Click);
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
            this.gunaPanel2_top.Size = new System.Drawing.Size(918, 53);
            this.gunaPanel2_top.TabIndex = 0;
            this.gunaPanel2_top.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.gunaPanel2_top;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1190, 707);
            this.Controls.Add(this.gunaPanel2_top);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form2";
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2_top;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaButton gunaButton_check_master;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton gunaButton_Chsoose_date;
        private Guna.UI.WinForms.GunaButton gunaButton_choose_service;
    }
}