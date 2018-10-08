namespace frmSplash
{
    partial class Icon_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Icon_Select));
            this.Icon1 = new System.Windows.Forms.PictureBox();
            this.Icon2 = new System.Windows.Forms.PictureBox();
            this.Icon3 = new System.Windows.Forms.PictureBox();
            this.Icon4 = new System.Windows.Forms.PictureBox();
            this.Icon5 = new System.Windows.Forms.PictureBox();
            this.Icon6 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chosenicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chosenicon)).BeginInit();
            this.SuspendLayout();
            // 
            // Icon1
            // 
            this.Icon1.Image = global::frmSplash.Properties.Resources._12042642_857850680971660_97550004417600091_n;
            this.Icon1.Location = new System.Drawing.Point(2, 3);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(86, 69);
            this.Icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon1.TabIndex = 0;
            this.Icon1.TabStop = false;
            this.Icon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Icon1_MouseDown);
            // 
            // Icon2
            // 
            this.Icon2.Image = global::frmSplash.Properties.Resources.DeathStroke;
            this.Icon2.Location = new System.Drawing.Point(94, 3);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(86, 69);
            this.Icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon2.TabIndex = 1;
            this.Icon2.TabStop = false;
            this.Icon2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Icon2_MouseDown);
            // 
            // Icon3
            // 
            this.Icon3.Image = global::frmSplash.Properties.Resources.flash;
            this.Icon3.Location = new System.Drawing.Point(186, 3);
            this.Icon3.Name = "Icon3";
            this.Icon3.Size = new System.Drawing.Size(86, 69);
            this.Icon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon3.TabIndex = 2;
            this.Icon3.TabStop = false;
            this.Icon3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Icon3_MouseDown);
            // 
            // Icon4
            // 
            this.Icon4.Image = global::frmSplash.Properties.Resources.ras;
            this.Icon4.Location = new System.Drawing.Point(2, 78);
            this.Icon4.Name = "Icon4";
            this.Icon4.Size = new System.Drawing.Size(86, 69);
            this.Icon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon4.TabIndex = 3;
            this.Icon4.TabStop = false;
            this.Icon4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Icon4_MouseDown);
            // 
            // Icon5
            // 
            this.Icon5.Image = global::frmSplash.Properties.Resources.the_atom;
            this.Icon5.Location = new System.Drawing.Point(94, 78);
            this.Icon5.Name = "Icon5";
            this.Icon5.Size = new System.Drawing.Size(86, 69);
            this.Icon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon5.TabIndex = 4;
            this.Icon5.TabStop = false;
            this.Icon5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Icon5_MouseDown);
            // 
            // Icon6
            // 
            this.Icon6.Image = global::frmSplash.Properties.Resources.reverse_flash_icon;
            this.Icon6.Location = new System.Drawing.Point(186, 78);
            this.Icon6.Name = "Icon6";
            this.Icon6.Size = new System.Drawing.Size(86, 69);
            this.Icon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon6.TabIndex = 5;
            this.Icon6.TabStop = false;
            this.Icon6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Icon6_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(2, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Icon";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chosenicon
            // 
            this.chosenicon.BackColor = System.Drawing.Color.Red;
            this.chosenicon.Location = new System.Drawing.Point(278, 3);
            this.chosenicon.Name = "chosenicon";
            this.chosenicon.Size = new System.Drawing.Size(120, 143);
            this.chosenicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chosenicon.TabIndex = 7;
            this.chosenicon.TabStop = false;
            this.chosenicon.DragDrop += new System.Windows.Forms.DragEventHandler(this.chosenicon_DragDrop);
            this.chosenicon.DragEnter += new System.Windows.Forms.DragEventHandler(this.chosenicon_DragEnter);
            // 
            // Icon_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::frmSplash.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(400, 189);
            this.Controls.Add(this.chosenicon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Icon6);
            this.Controls.Add(this.Icon5);
            this.Controls.Add(this.Icon4);
            this.Controls.Add(this.Icon3);
            this.Controls.Add(this.Icon2);
            this.Controls.Add(this.Icon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Icon_Select";
            this.Text = "Select An Icon";
            this.Load += new System.EventHandler(this.Icon_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chosenicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Icon1;
        private System.Windows.Forms.PictureBox Icon2;
        private System.Windows.Forms.PictureBox Icon3;
        private System.Windows.Forms.PictureBox Icon4;
        private System.Windows.Forms.PictureBox Icon5;
        private System.Windows.Forms.PictureBox Icon6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox chosenicon;
    }
}