namespace BeautyRoom
{
    partial class Date
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Date));
            this.gunaDatePanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaService = new Guna.UI.WinForms.GunaLabel();
            this.gunaDatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaDatePanel
            // 
            this.gunaDatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaDatePanel.AutoScroll = true;
            this.gunaDatePanel.BackColor = System.Drawing.Color.Transparent;
            this.gunaDatePanel.BaseColor = System.Drawing.Color.White;
            this.gunaDatePanel.Controls.Add(this.gunaService);
            this.gunaDatePanel.Location = new System.Drawing.Point(12, 5);
            this.gunaDatePanel.Name = "gunaDatePanel";
            this.gunaDatePanel.ShadowColor = System.Drawing.Color.Black;
            this.gunaDatePanel.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaDatePanel.Size = new System.Drawing.Size(795, 465);
            this.gunaDatePanel.TabIndex = 2;
            // 
            // gunaService
            // 
            this.gunaService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaService.AutoSize = true;
            this.gunaService.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaService.Location = new System.Drawing.Point(199, 25);
            this.gunaService.Name = "gunaService";
            this.gunaService.Size = new System.Drawing.Size(412, 68);
            this.gunaService.TabIndex = 0;
            this.gunaService.Text = "Выберите Свободную Дату\r\n\r\n";
            this.gunaService.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 475);
            this.Controls.Add(this.gunaDatePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Date";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date";
            this.Load += new System.EventHandler(this.Date_Load);
            this.gunaDatePanel.ResumeLayout(false);
            this.gunaDatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaService;
        private Guna.UI.WinForms.GunaShadowPanel gunaDatePanel;
    }
}