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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Red;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(29, 372);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(377, 41);
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
            this.btnExit.Location = new System.Drawing.Point(29, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(29, 57);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(377, 282);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(216, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show Certificate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmSplash.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.rtbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinish";
            this.Text = "Questions";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button button1;
    }
}