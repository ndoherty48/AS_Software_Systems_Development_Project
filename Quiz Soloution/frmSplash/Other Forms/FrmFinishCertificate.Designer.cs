namespace frmSplash
{
    partial class FrmFinishCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinishCertificate));
            this.picCertificate = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCertificate)).BeginInit();
            this.SuspendLayout();
            // 
            // picCertificate
            // 
            this.picCertificate.Image = global::frmSplash.Properties.Resources.certificate;
            this.picCertificate.Location = new System.Drawing.Point(2, 27);
            this.picCertificate.Name = "picCertificate";
            this.picCertificate.Size = new System.Drawing.Size(726, 444);
            this.picCertificate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCertificate.TabIndex = 0;
            this.picCertificate.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(302, 202);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 26);
            this.lblName.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(133, 373);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 9;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.White;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(223, 287);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 20);
            this.lblLevel.TabIndex = 10;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblScore.Location = new System.Drawing.Point(466, 270);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 11;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(-3, -2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(731, 35);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print Certificate";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmFinishCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 472);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picCertificate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFinishCertificate";
            this.Text = "Certificate";
            this.Load += new System.EventHandler(this.FrmFinishCertificate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCertificate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCertificate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnPrint;
    }
}