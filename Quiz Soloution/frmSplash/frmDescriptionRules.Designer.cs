namespace frmSplash
{
    partial class frmDescriptionRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescriptionRules));
            this.rtbRules = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToRegisterLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbRules
            // 
            this.rtbRules.BackColor = System.Drawing.Color.White;
            this.rtbRules.Location = new System.Drawing.Point(26, 116);
            this.rtbRules.Name = "rtbRules";
            this.rtbRules.Size = new System.Drawing.Size(377, 308);
            this.rtbRules.TabIndex = 0;
            this.rtbRules.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.howToRegisterLoginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // howToRegisterLoginToolStripMenuItem
            // 
            this.howToRegisterLoginToolStripMenuItem.Name = "howToRegisterLoginToolStripMenuItem";
            this.howToRegisterLoginToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.howToRegisterLoginToolStripMenuItem.Text = "How To Register/ Login";
            this.howToRegisterLoginToolStripMenuItem.Click += new System.EventHandler(this.howToRegisterLoginToolStripMenuItem_Click);
            // 
            // logo
            // 
            this.logo.Image = global::frmSplash.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(327, 27);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(107, 64);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 116;
            this.logo.TabStop = false;
            // 
            // frmDescriptionRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmSplash.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 462);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.rtbRules);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDescriptionRules";
            this.Text = "Quiz Rules";
            this.Load += new System.EventHandler(this.frmDescriptionRules_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRules;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToRegisterLoginToolStripMenuItem;
        private System.Windows.Forms.PictureBox logo;
    }
}