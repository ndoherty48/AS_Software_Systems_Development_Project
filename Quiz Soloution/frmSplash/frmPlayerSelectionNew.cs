using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSplash
{
    public partial class frmPlayerSelectionNew : Form
    {
        public frmPlayerSelectionNew()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        string[] arrQuizLevels = new string[]
           {
            "Beginner",
            "Intermediate",
            "Advanced"
           };
        int arrPlayerIcons = 0;

        private void frmPlayerSelectionNew_Load_1(object sender, EventArgs e)
        {
            foreach (string quizLevel in arrQuizLevels)
            {
                cboQuizLevel.Items.Add(quizLevel);
            }

            //Allow drop of all images
            pctIcon1.AllowDrop = true;
            pctIcon2.AllowDrop = true;
            pctIcon3.AllowDrop = true;
            pctIcon4.AllowDrop = true;
            pctIcon5.AllowDrop = true;
            pctIcon6.AllowDrop = true;
            pctChosenIcon.AllowDrop = true;

            //set cursor to be in Player Name Text Box

            this.ActiveControl = txtPlayerName;
        }

        private void pctIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            pctIcon1.DoDragDrop(pctIcon1.Image, DragDropEffects.Copy);
            arrPlayerIcons = 1;
        }

        private void pctIcon2_MouseDown(object sender, MouseEventArgs e)
        {
            pctIcon2.DoDragDrop(pctIcon2.Image, DragDropEffects.Copy);
            arrPlayerIcons = 2;
        }

        private void pctIcon3_MouseDown(object sender, MouseEventArgs e)
        {
            pctIcon3.DoDragDrop(pctIcon3.Image, DragDropEffects.Copy);
            arrPlayerIcons = 3;
        }

        private void pctIcon4_MouseDown(object sender, MouseEventArgs e)
        {
            pctIcon4.DoDragDrop(pctIcon4.Image, DragDropEffects.Copy);
            arrPlayerIcons = 4;
        }

        private void pctIcon5_MouseDown(object sender, MouseEventArgs e)
        {
            pctIcon5.DoDragDrop(pctIcon5.Image, DragDropEffects.Copy);
            arrPlayerIcons = 5;
        }

        private void pctIcon6_MouseDown(object sender, MouseEventArgs e)
        {
            pctIcon6.DoDragDrop(pctIcon6.Image, DragDropEffects.Copy);
            arrPlayerIcons = 6;
        }

        private void pctChosenIcon_DragDrop(object sender, DragEventArgs e)
        {
            pctChosenIcon.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pctChosenIcon_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        void writetofile()
        {
            string file_name = @".../.../Text Files/usernames.txt";
            System.IO.StreamWriter Userwriter = new System.IO.StreamWriter(file_name,true);

            Userwriter.WriteLine(txtPlayerName.Text);
            Userwriter.Close();

            string file_name1 = @".../.../Text Files/Passwords.txt";
            System.IO.StreamWriter Passwriter = new System.IO.StreamWriter(file_name1,true);

            Passwriter.WriteLine(txtPlayerPassword.Text);
            Passwriter.Close();
        }

        private void btnNextScreenRules_Click(object sender, EventArgs e)
        {
            //these lines of code set the Player Details Class
            playerDetails.playerName = txtPlayerName.Text;
            playerDetails.quizLevel = cboQuizLevel.Text;
            playerDetails.quizdate = DateTime.Now;
            playerDetails.playerPassword = txtPlayerPassword.Text;

            writetofile();
            
            //TextWriter usernametw = new StreamWriter(@"C:\usernames.txt",true);
            //usernametw.WriteLine(txtPlayerName);


            playerDetails.playericon = arrPlayerIcons;

            if (txtPlayerPassword.Text.Contains(" "))
            {
                MessageBox.Show("No Spaces are allowed in the Password! Try Again");
            }
            else
            {
                
                if (playerDetails.quizLevel == "Beginner")
                {
                    this.Hide();
                    frmBeginner1 mynextscreen = new frmBeginner1();
                    mynextscreen.ShowDialog();
                }
                else if (playerDetails.quizLevel == "Intermediate")
                {
                    this.Hide();
                    frmIntermediate1 mynextscreen = new frmIntermediate1();
                    mynextscreen.ShowDialog();
                }
                else if (playerDetails.quizLevel == "Advanced")
                {
                    this.Hide();
                    frmAdvanced1 mynextscreen = new frmAdvanced1();
                    mynextscreen.ShowDialog();
                }
                playerDetails.playerPassword = txtPlayerPassword.Text;
                
                
            }
        }
    }
}
        
