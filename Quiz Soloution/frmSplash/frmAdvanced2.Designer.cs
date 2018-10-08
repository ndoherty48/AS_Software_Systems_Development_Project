using System;

namespace frmSplash
{
    partial class frmAdvanced2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvanced2));
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.pctIncorrect = new System.Windows.Forms.PictureBox();
            this.pctCorrect = new System.Windows.Forms.PictureBox();
            this.lblQuestion5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuRules = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAwnser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorrect)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "cryptocurrency?";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(13, 68);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(258, 24);
            this.lblQuestion.TabIndex = 57;
            this.lblQuestion.Text = "Please Name the following";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.Red;
            this.btnNextQuestion.BackgroundImage = global::frmSplash.Properties.Resources.Next;
            this.btnNextQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextQuestion.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextQuestion.Location = new System.Drawing.Point(327, 364);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(100, 49);
            this.btnNextQuestion.TabIndex = 56;
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // pctIncorrect
            // 
            this.pctIncorrect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctIncorrect.BackgroundImage")));
            this.pctIncorrect.Image = ((System.Drawing.Image)(resources.GetObject("pctIncorrect.Image")));
            this.pctIncorrect.Location = new System.Drawing.Point(327, 170);
            this.pctIncorrect.Name = "pctIncorrect";
            this.pctIncorrect.Size = new System.Drawing.Size(100, 81);
            this.pctIncorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctIncorrect.TabIndex = 55;
            this.pctIncorrect.TabStop = false;
            this.pctIncorrect.Visible = false;
            // 
            // pctCorrect
            // 
            this.pctCorrect.Image = ((System.Drawing.Image)(resources.GetObject("pctCorrect.Image")));
            this.pctCorrect.Location = new System.Drawing.Point(327, 170);
            this.pctCorrect.Name = "pctCorrect";
            this.pctCorrect.Size = new System.Drawing.Size(100, 81);
            this.pctCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCorrect.TabIndex = 54;
            this.pctCorrect.TabStop = false;
            this.pctCorrect.Visible = false;
            // 
            // lblQuestion5
            // 
            this.lblQuestion5.AutoSize = true;
            this.lblQuestion5.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion5.ForeColor = System.Drawing.Color.White;
            this.lblQuestion5.Location = new System.Drawing.Point(-2, 29);
            this.lblQuestion5.Name = "lblQuestion5";
            this.lblQuestion5.Size = new System.Drawing.Size(86, 20);
            this.lblQuestion5.TabIndex = 52;
            this.lblQuestion5.Text = "Question 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 59;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(327, 425);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 60;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRules,
            this.mnuRestart,
            this.mnuQuit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 113;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuRules
            // 
            this.mnuRules.Name = "mnuRules";
            this.mnuRules.Size = new System.Drawing.Size(47, 20);
            this.mnuRules.Text = "Rules";
            this.mnuRules.Click += new System.EventHandler(this.mnuRules_Click);
            // 
            // mnuRestart
            // 
            this.mnuRestart.Name = "mnuRestart";
            this.mnuRestart.Size = new System.Drawing.Size(55, 20);
            this.mnuRestart.Text = "Restart";
            this.mnuRestart.Click += new System.EventHandler(this.mnuRestart_Click);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(42, 20);
            this.mnuQuit.Text = "Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // logo
            // 
            this.logo.Image = global::frmSplash.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(326, 27);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(107, 64);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 114;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frmSplash.Properties.Resources.bitcoin;
            this.pictureBox1.Location = new System.Drawing.Point(2, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // txtAwnser
            // 
            this.txtAwnser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAwnser.Location = new System.Drawing.Point(2, 364);
            this.txtAwnser.Name = "txtAwnser";
            this.txtAwnser.Size = new System.Drawing.Size(320, 47);
            this.txtAwnser.TabIndex = 116;
            // 
            // frmAdvanced2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmSplash.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 462);
            this.Controls.Add(this.txtAwnser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.pctIncorrect);
            this.Controls.Add(this.pctCorrect);
            this.Controls.Add(this.lblQuestion5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdvanced2";
            this.Text = "Question 2";
            this.Load += new System.EventHandler(this.frmQuestion8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorrect)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.PictureBox pctIncorrect;
        private System.Windows.Forms.PictureBox pctCorrect;
        private System.Windows.Forms.Label lblQuestion5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;

        public static implicit operator frmAdvanced2(frmFinish v)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRules;
        private System.Windows.Forms.ToolStripMenuItem mnuRestart;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAwnser;
    }
}