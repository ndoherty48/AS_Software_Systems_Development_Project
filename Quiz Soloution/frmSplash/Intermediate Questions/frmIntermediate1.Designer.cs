namespace frmSplash
{
    partial class frmIntermediate1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntermediate1));
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.pctIncorrect = new System.Windows.Forms.PictureBox();
            this.pctCorrect = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuRules = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorrect)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.Red;
            this.btnNextQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextQuestion.BackgroundImage")));
            this.btnNextQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextQuestion.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextQuestion.Location = new System.Drawing.Point(357, 362);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(149, 49);
            this.btnNextQuestion.TabIndex = 20;
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // pctIncorrect
            // 
            this.pctIncorrect.Image = ((System.Drawing.Image)(resources.GetObject("pctIncorrect.Image")));
            this.pctIncorrect.Location = new System.Drawing.Point(592, 275);
            this.pctIncorrect.Name = "pctIncorrect";
            this.pctIncorrect.Size = new System.Drawing.Size(100, 81);
            this.pctIncorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctIncorrect.TabIndex = 19;
            this.pctIncorrect.TabStop = false;
            this.pctIncorrect.Visible = false;
            // 
            // pctCorrect
            // 
            this.pctCorrect.Image = ((System.Drawing.Image)(resources.GetObject("pctCorrect.Image")));
            this.pctCorrect.Location = new System.Drawing.Point(592, 128);
            this.pctCorrect.Name = "pctCorrect";
            this.pctCorrect.Size = new System.Drawing.Size(100, 81);
            this.pctCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCorrect.TabIndex = 18;
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
            this.groupBox1.Location = new System.Drawing.Point(17, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 228);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What is the Correct Awnser";
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.Location = new System.Drawing.Point(6, 201);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(254, 21);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "Micro Instrument Data interlude";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(7, 142);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(269, 21);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "Musical Instrument Data Interface";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(6, 83);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(269, 21);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Micro Intellectual Digital Interface";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(7, 29);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(281, 21);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Musical Instrument Digital Interface";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion3.ForeColor = System.Drawing.Color.White;
            this.lblQuestion3.Location = new System.Drawing.Point(1, 32);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(86, 20);
            this.lblQuestion3.TabIndex = 15;
            this.lblQuestion3.Text = "Question 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(500, 20);
            this.textBox1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 36);
            this.label1.TabIndex = 111;
            this.label1.Text = "What Does MIDI Stand For";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 362);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(334, 49);
            this.progressBar1.TabIndex = 112;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRules,
            this.mnuRestart,
            this.mnuQuit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
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
            // Logo
            // 
            this.Logo.Image = global::frmSplash.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(511, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(193, 85);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 121;
            this.Logo.TabStop = false;
            // 
            // frmIntermediate1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmSplash.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.pctIncorrect);
            this.Controls.Add(this.pctCorrect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQuestion3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIntermediate1";
            this.Text = "Question 1";
            this.Load += new System.EventHandler(this.frmQuestion3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorrect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.PictureBox pctIncorrect;
        private System.Windows.Forms.PictureBox pctCorrect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRules;
        private System.Windows.Forms.ToolStripMenuItem mnuRestart;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.PictureBox Logo;
    }
}