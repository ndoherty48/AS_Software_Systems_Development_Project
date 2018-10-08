namespace frmSplash
{
    partial class frmFinish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinish));
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnCertificate = new System.Windows.Forms.Button();
            this.cboRestartLevels = new System.Windows.Forms.ComboBox();
            this.RestartLevel = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Red;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(395, 189);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(297, 23);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Display And Record Score";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(395, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(297, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Enabled = false;
            this.rtbOutput.Location = new System.Drawing.Point(12, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(377, 417);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // btnCertificate
            // 
            this.btnCertificate.BackColor = System.Drawing.Color.Red;
            this.btnCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertificate.ForeColor = System.Drawing.Color.White;
            this.btnCertificate.Location = new System.Drawing.Point(395, 287);
            this.btnCertificate.Name = "btnCertificate";
            this.btnCertificate.Size = new System.Drawing.Size(297, 23);
            this.btnCertificate.TabIndex = 9;
            this.btnCertificate.Text = "Show Certificate";
            this.btnCertificate.UseVisualStyleBackColor = false;
            this.btnCertificate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboRestartLevels
            // 
            this.cboRestartLevels.FormattingEnabled = true;
            this.cboRestartLevels.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cboRestartLevels.Location = new System.Drawing.Point(395, 96);
            this.cboRestartLevels.Name = "cboRestartLevels";
            this.cboRestartLevels.Size = new System.Drawing.Size(297, 21);
            this.cboRestartLevels.TabIndex = 10;
            // 
            // RestartLevel
            // 
            this.RestartLevel.BackColor = System.Drawing.Color.Red;
            this.RestartLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartLevel.ForeColor = System.Drawing.Color.White;
            this.RestartLevel.Location = new System.Drawing.Point(395, 121);
            this.RestartLevel.Name = "RestartLevel";
            this.RestartLevel.Size = new System.Drawing.Size(297, 23);
            this.RestartLevel.TabIndex = 11;
            this.RestartLevel.Text = "Restart as Level";
            this.RestartLevel.UseVisualStyleBackColor = false;
            this.RestartLevel.Click += new System.EventHandler(this.RestartLevel_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::frmSplash.Properties.Resources.logo1;
            this.picLogo.Location = new System.Drawing.Point(515, -1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(189, 91);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // frmFinish
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.RestartLevel);
            this.Controls.Add(this.cboRestartLevels);
            this.Controls.Add(this.btnCertificate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.rtbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinish";
            this.Text = "Finished Quiz";
            this.Load += new System.EventHandler(this.frmFinish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnCertificate;
        private System.Windows.Forms.ComboBox cboRestartLevels;
        private System.Windows.Forms.Button RestartLevel;
        private System.Windows.Forms.PictureBox picLogo;
    }
}