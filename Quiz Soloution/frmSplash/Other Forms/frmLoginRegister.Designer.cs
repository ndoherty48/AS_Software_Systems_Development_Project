namespace frmSplash
{
    partial class frmLoginRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginRegister));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.muteYes = new System.Windows.Forms.CheckBox();
            this.lblMute = new System.Windows.Forms.Label();
            this.muteNo = new System.Windows.Forms.CheckBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Red;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(102, 117);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(333, 86);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Red;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(286, 209);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(333, 86);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // muteYes
            // 
            this.muteYes.AutoSize = true;
            this.muteYes.BackColor = System.Drawing.Color.Transparent;
            this.muteYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteYes.ForeColor = System.Drawing.Color.White;
            this.muteYes.Location = new System.Drawing.Point(13, 415);
            this.muteYes.Name = "muteYes";
            this.muteYes.Size = new System.Drawing.Size(47, 17);
            this.muteYes.TabIndex = 2;
            this.muteYes.Text = "Yes";
            this.muteYes.UseVisualStyleBackColor = false;
            // 
            // lblMute
            // 
            this.lblMute.AutoSize = true;
            this.lblMute.BackColor = System.Drawing.Color.Transparent;
            this.lblMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMute.ForeColor = System.Drawing.Color.White;
            this.lblMute.Location = new System.Drawing.Point(10, 399);
            this.lblMute.Name = "lblMute";
            this.lblMute.Size = new System.Drawing.Size(208, 13);
            this.lblMute.TabIndex = 3;
            this.lblMute.Text = "Would you like sound to be active?";
            // 
            // muteNo
            // 
            this.muteNo.AutoSize = true;
            this.muteNo.BackColor = System.Drawing.Color.Transparent;
            this.muteNo.Checked = true;
            this.muteNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.muteNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteNo.ForeColor = System.Drawing.Color.White;
            this.muteNo.Location = new System.Drawing.Point(66, 415);
            this.muteNo.Name = "muteNo";
            this.muteNo.Size = new System.Drawing.Size(42, 17);
            this.muteNo.TabIndex = 4;
            this.muteNo.Text = "No";
            this.muteNo.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::frmSplash.Properties.Resources.logo1;
            this.picLogo.Location = new System.Drawing.Point(515, -1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(189, 91);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // frmLoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmSplash.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.muteNo);
            this.Controls.Add(this.lblMute);
            this.Controls.Add(this.muteYes);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoginRegister";
            this.Text = "Login  or Register";
            this.Load += new System.EventHandler(this.frmLoginRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox muteYes;
        private System.Windows.Forms.Label lblMute;
        private System.Windows.Forms.CheckBox muteNo;
        private System.Windows.Forms.PictureBox picLogo;
    }
}