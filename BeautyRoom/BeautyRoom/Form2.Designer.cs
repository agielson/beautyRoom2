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
            this.gunaButton_choose_service = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_check_master = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2_top = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Controls.Add(this.gunaButton_choose_service);
            this.gunaPanel1.Controls.Add(this.gunaButton_check_master);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(272, 707);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaButton_choose_service
            // 
            this.gunaButton_choose_service.AnimationHoverSpeed = 0.07F;
            this.gunaButton_choose_service.AnimationSpeed = 0.03F;
            this.gunaButton_choose_service.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton_choose_service.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_choose_service.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton_choose_service.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_choose_service.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton_choose_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton_choose_service.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton_choose_service.Image = null;
            this.gunaButton_choose_service.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_choose_service.Location = new System.Drawing.Point(-1, 225);
            this.gunaButton_choose_service.Name = "gunaButton_choose_service";
            this.gunaButton_choose_service.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.gunaButton_choose_service.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton_choose_service.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton_choose_service.OnHoverImage = null;
            this.gunaButton_choose_service.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton_choose_service.Size = new System.Drawing.Size(270, 50);
            this.gunaButton_choose_service.TabIndex = 2;
            this.gunaButton_choose_service.Text = "         Выбрать Услугу";
            // 
            // gunaButton_check_master
            // 
            this.gunaButton_check_master.AnimationHoverSpeed = 0.07F;
            this.gunaButton_check_master.AnimationSpeed = 0.03F;
            this.gunaButton_check_master.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton_check_master.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_check_master.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton_check_master.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_check_master.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton_check_master.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton_check_master.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton_check_master.Image = null;
            this.gunaButton_check_master.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_check_master.Location = new System.Drawing.Point(-1, 328);
            this.gunaButton_check_master.Name = "gunaButton_check_master";
            this.gunaButton_check_master.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.gunaButton_check_master.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton_check_master.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton_check_master.OnHoverImage = null;
            this.gunaButton_check_master.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton_check_master.Size = new System.Drawing.Size(270, 50);
            this.gunaButton_check_master.TabIndex = 1;
            this.gunaButton_check_master.Text = "       Выбрать Мастера";
            this.gunaButton_check_master.Click += new System.EventHandler(this.gunaButton_check_master_Click);
            // 
            // gunaPanel2_top
            // 
            this.gunaPanel2_top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPanel2_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2_top.Location = new System.Drawing.Point(272, 0);
            this.gunaPanel2_top.Name = "gunaPanel2_top";
            this.gunaPanel2_top.Size = new System.Drawing.Size(918, 50);
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
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(76, 3);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(106, 100);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 6;
            this.gunaPictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "BeautyRoom";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1190, 707);
            this.Controls.Add(this.gunaPanel2_top);
            this.Controls.Add(this.gunaPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2_top;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaButton gunaButton_check_master;
        private Guna.UI.WinForms.GunaButton gunaButton_choose_service;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.Label label2;
    }
}