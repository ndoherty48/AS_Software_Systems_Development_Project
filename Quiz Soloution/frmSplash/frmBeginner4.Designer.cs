namespace frmSplash
{
    partial class frmBeginner4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeginner4));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.pctIncorrect = new System.Windows.Forms.PictureBox();
            this.pctCorrect = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.lblQuestion5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuRules = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorrect)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(-1, 98);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(402, 20);
            this.lblQuestion.TabIndex = 94;
            this.lblQuestion.Text = "Which of the Following is not a Operating System";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.Red;
            this.btnNextQuestion.BackgroundImage = global::frmSplash.Properties.Resources.Next;
            this.btnNextQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextQuestion.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextQuestion.Location = new System.Drawing.Point(327, 362);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(100, 49);
            this.btnNextQuestion.TabIndex = 93;
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // pctIncorrect
            // 
            this.pctIncorrect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctIncorrect.BackgroundImage")));
            this.pctIncorrect.Image = ((System.Drawing.Image)(resources.GetObject("pctIncorrect.Image")));
            this.pctIncorrect.Location = new System.Drawing.Point(327, 168);
            this.pctIncorrect.Name = "pctIncorrect";
            this.pctIncorrect.Size = new System.Drawing.Size(100, 81);
            this.pctIncorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctIncorrect.TabIndex = 92;
            this.pctIncorrect.TabStop = false;
            this.pctIncorrect.Visible = false;
            // 
            // pctCorrect
            // 
            this.pctCorrect.Image = ((System.Drawing.Image)(resources.GetObject("pctCorrect.Image")));
            this.pctCorrect.Location = new System.Drawing.Point(327, 168);
            this.pctCorrect.Name = "pctCorrect";
            this.pctCorrect.Size = new System.Drawing.Size(100, 81);
            this.pctCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCorrect.TabIndex = 91;
            this.pctCorrect.TabStop = false;
            this.pctCorrect.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 333);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What is the Correct Awnser";
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.Location = new System.Drawing.Point(7, 284);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(133, 24);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "Visual Studio";
            this.rb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(7, 196);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(64, 24);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "OSX";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.ForeColor = System.Drawing.Color.White;
            this.rb2.Location = new System.Drawing.Point(6, 114);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(69, 24);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Linux";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(7, 29);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(89, 24);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Android";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion5
            // 
            this.lblQuestion5.AutoSize = true;
            this.lblQuestion5.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion5.ForeColor = System.Drawing.Color.White;
            this.lblQuestion5.Location = new System.Drawing.Point(-1, 37);
            this.lblQuestion5.Name = "lblQuestion5";
            this.lblQuestion5.Size = new System.Drawing.Size(86, 20);
            this.lblQuestion5.TabIndex = 89;
            this.lblQuestion5.Text = "Question 4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 95;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(327, 424);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 96;
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
            this.logo.Location = new System.Drawing.Point(327, 27);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(107, 64);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 115;
            this.logo.TabStop = false;
            // 
            // frmBeginner4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmSplash.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 462);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.pctIncorrect);
            this.Controls.Add(this.pctCorrect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQuestion5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeginner4";
            this.Text = "Question 4";
            this.Load += new System.EventHandler(this.frmBeginner4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorrect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.PictureBox pctIncorrect;
        private System.Windows.Forms.PictureBox pctCorrect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label lblQuestion5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRules;
        private System.Windows.Forms.ToolStripMenuItem mnuRestart;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.PictureBox logo;
    }
}