namespace frmSplash
{
    partial class frmPlayerSelectionNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerSelectionNew));
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerPassword = new System.Windows.Forms.TextBox();
            this.lblPlayerPassword = new System.Windows.Forms.Label();
            this.lblQuizLevel = new System.Windows.Forms.Label();
            this.cboQuizLevel = new System.Windows.Forms.ComboBox();
            this.btnNextScreenRules = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnIconSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProjectTitle.Location = new System.Drawing.Point(12, 9);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(270, 55);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.Text = "New Player";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(367, 126);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(281, 20);
            this.txtPlayerName.TabIndex = 1;
            this.txtPlayerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerName_KeyPress);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(51, 115);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(259, 31);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Enter Player Name";
            // 
            // txtPlayerPassword
            // 
            this.txtPlayerPassword.Location = new System.Drawing.Point(367, 183);
            this.txtPlayerPassword.Name = "txtPlayerPassword";
            this.txtPlayerPassword.PasswordChar = '*';
            this.txtPlayerPassword.Size = new System.Drawing.Size(281, 20);
            this.txtPlayerPassword.TabIndex = 3;
            this.txtPlayerPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerPassword_KeyPress);
            // 
            // lblPlayerPassword
            // 
            this.lblPlayerPassword.AutoSize = true;
            this.lblPlayerPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblPlayerPassword.ForeColor = System.Drawing.Color.White;
            this.lblPlayerPassword.Location = new System.Drawing.Point(32, 174);
            this.lblPlayerPassword.Name = "lblPlayerPassword";
            this.lblPlayerPassword.Size = new System.Drawing.Size(278, 29);
            this.lblPlayerPassword.TabIndex = 4;
            this.lblPlayerPassword.Text = "Enter Player Password";
            // 
            // lblQuizLevel
            // 
            this.lblQuizLevel.AutoSize = true;
            this.lblQuizLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblQuizLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblQuizLevel.ForeColor = System.Drawing.Color.White;
            this.lblQuizLevel.Location = new System.Drawing.Point(105, 221);
            this.lblQuizLevel.Name = "lblQuizLevel";
            this.lblQuizLevel.Size = new System.Drawing.Size(205, 29);
            this.lblQuizLevel.TabIndex = 5;
            this.lblQuizLevel.Text = "Enter Quiz Level";
            // 
            // cboQuizLevel
            // 
            this.cboQuizLevel.FormattingEnabled = true;
            this.cboQuizLevel.Location = new System.Drawing.Point(367, 230);
            this.cboQuizLevel.Name = "cboQuizLevel";
            this.cboQuizLevel.Size = new System.Drawing.Size(281, 21);
            this.cboQuizLevel.TabIndex = 6;
            this.cboQuizLevel.TabStop = false;
            // 
            // btnNextScreenRules
            // 
            this.btnNextScreenRules.BackColor = System.Drawing.Color.Red;
            this.btnNextScreenRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextScreenRules.ForeColor = System.Drawing.Color.White;
            this.btnNextScreenRules.Location = new System.Drawing.Point(27, 312);
            this.btnNextScreenRules.Name = "btnNextScreenRules";
            this.btnNextScreenRules.Size = new System.Drawing.Size(283, 53);
            this.btnNextScreenRules.TabIndex = 17;
            this.btnNextScreenRules.Text = "Register";
            this.btnNextScreenRules.UseVisualStyleBackColor = false;
            this.btnNextScreenRules.Click += new System.EventHandler(this.btnNextScreenRules_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(364, 153);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(177, 13);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Date will automatically appear";
            // 
            // btnIconSelect
            // 
            this.btnIconSelect.BackColor = System.Drawing.Color.Red;
            this.btnIconSelect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconSelect.ForeColor = System.Drawing.Color.White;
            this.btnIconSelect.Location = new System.Drawing.Point(27, 266);
            this.btnIconSelect.Name = "btnIconSelect";
            this.btnIconSelect.Size = new System.Drawing.Size(514, 40);
            this.btnIconSelect.TabIndex = 19;
            this.btnIconSelect.Text = "Select Your Icon";
            this.btnIconSelect.UseVisualStyleBackColor = false;
            this.btnIconSelect.Click += new System.EventHandler(this.btnIconSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(316, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(225, 53);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::frmSplash.Properties.Resources.logo1;
            this.picLogo.Location = new System.Drawing.Point(510, 1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(196, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 21;
            this.picLogo.TabStop = false;
            // 
            // frmPlayerSelectionNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIconSelect);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnNextScreenRules);
            this.Controls.Add(this.cboQuizLevel);
            this.Controls.Add(this.lblQuizLevel);
            this.Controls.Add(this.lblPlayerPassword);
            this.Controls.Add(this.txtPlayerPassword);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblProjectTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlayerSelectionNew";
            this.Text = "New Player Details";

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerPassword;
        private System.Windows.Forms.Label lblPlayerPassword;
        private System.Windows.Forms.Label lblQuizLevel;
        private System.Windows.Forms.ComboBox cboQuizLevel;
        private System.Windows.Forms.Button btnNextScreenRules;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnIconSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picLogo;
    }
}