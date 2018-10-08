namespace frmSplash
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuizTitle = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(148, 195);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(285, 44);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nathan Doherty";
            // 
            // lblQuizTitle
            // 
            this.lblQuizTitle.AutoSize = true;
            this.lblQuizTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblQuizTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizTitle.ForeColor = System.Drawing.Color.White;
            this.lblQuizTitle.Location = new System.Drawing.Point(136, 239);
            this.lblQuizTitle.Name = "lblQuizTitle";
            this.lblQuizTitle.Size = new System.Drawing.Size(297, 44);
            this.lblQuizTitle.TabIndex = 3;
            this.lblQuizTitle.Text = "GCSE ICT QUIZ";
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.BackColor = System.Drawing.Color.Transparent;
            this.lblCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreated.ForeColor = System.Drawing.Color.Transparent;
            this.lblCreated.Location = new System.Drawing.Point(183, 283);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(250, 44);
            this.lblCreated.TabIndex = 4;
            this.lblCreated.Text = "October 2015";
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 3000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frmSplash.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(205, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 334);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(308, 63);
            this.progressBar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::frmSplash.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.lblQuizTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GCSE ICT Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuizTitle;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

