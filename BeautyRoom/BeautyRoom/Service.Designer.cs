namespace BeautyRoom
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.gunaServicePanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaService = new Guna.UI.WinForms.GunaLabel();
            this.gunaServicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaServicePanel
            // 
            this.gunaServicePanel.BackColor = System.Drawing.Color.Transparent;
            this.gunaServicePanel.BaseColor = System.Drawing.Color.White;
            this.gunaServicePanel.Controls.Add(this.gunaService);
            this.gunaServicePanel.Location = new System.Drawing.Point(12, 5);
            this.gunaServicePanel.Name = "gunaServicePanel";
            this.gunaServicePanel.ShadowColor = System.Drawing.Color.Black;
            this.gunaServicePanel.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaServicePanel.Size = new System.Drawing.Size(795, 465);
            this.gunaServicePanel.TabIndex = 1;
            // 
            // gunaService
            // 
            this.gunaService.AutoSize = true;
            this.gunaService.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaService.Location = new System.Drawing.Point(242, 28);
            this.gunaService.Name = "gunaService";
            this.gunaService.Size = new System.Drawing.Size(261, 34);
            this.gunaService.TabIndex = 0;
            this.gunaService.Text = "Выберите Услугу";
            this.gunaService.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 475);
            this.Controls.Add(this.gunaServicePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.gunaServicePanel.ResumeLayout(false);
            this.gunaServicePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaServicePanel;
        private Guna.UI.WinForms.GunaLabel gunaService;
    }
}