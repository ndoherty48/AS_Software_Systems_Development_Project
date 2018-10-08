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
            //Disables the Control Box
            ControlBox = false;
            //Disables the Next Screen Button
            btnNextScreenRules.Enabled = false;
            cboQuizLevel.Items.AddRange(arrQuizLevels);
        }

        //Creates an array to hold the levels
        string[] arrQuizLevels = new string[]
        {
            "Beginner",
            "Intermediate",
            "Advanced"
        };
        int arrPlayerIcons = 0;

        private void frmPlayerSelectionNew_Load_1(object sender, EventArgs e)
        {
            cboQuizLevel.Items.AddRange(arrQuizLevels);
        }

        void writetofile()
        {
            //Declares the text file that the usernames will go into
            string file_name = @"./Text Files/usernames.txt";
            System.IO.StreamWriter Userwriter = new System.IO.StreamWriter(file_name,true);

            ////Writes the Username to the text file on a new line
            //Userwriter.WriteLine(txtPlayerName.Text,true);
            //Userwriter.Close();

            //Declares the text file that the Passwords will go into
            string file_name1 = @"./Text Files/Passwords.txt";
            System.IO.StreamWriter Passwriter = new System.IO.StreamWriter(file_name1,true);

            Userwriter.WriteLine("\n");
            Userwriter.WriteLine(txtPlayerName.Text,true);
            Userwriter.Close();
            Passwriter.WriteLine("\n");
            Passwriter.WriteLine( txtPlayerPassword.Text,true);
            Passwriter.Close();

            ////Writes the Password to the text file on a new line
            //Passwriter.WriteLine(txtPlayerPassword.Text,true);
            //Passwriter.Close();
        }

        private void btnNextScreenRules_Click(object sender, EventArgs e)
        {
            //these lines of code set the Player Details Class
            playerDetails.playerName = txtPlayerName.Text;
            playerDetails.quizLevel = cboQuizLevel.Text;
            playerDetails.quizdate = DateTime.Now;
            playerDetails.playerPassword = txtPlayerPassword.Text;

            writetofile();
            string[] currentUsers = File.ReadAllLines("./text Files/usernames.txt");
            string username = txtPlayerName.Text;

            playerDetails.playericon = arrPlayerIcons;

            //Shows a message box if there is a space in the password
            if (txtPlayerPassword.Text.Contains(" "))
            {
                MessageBox.Show("No Spaces are allowed in the Password! Try Again");
            }
            else if (txtPlayerPassword.TextLength < 8)
            {
                MessageBox.Show("There must be atleast 8 characters in the password");
            }
            else if (currentUsers.Contains(username))
            {
                MessageBox.Show("This Username is already Taken");
            }
           
            else
            {
                //Checks Which Lever is selected
                if (playerDetails.quizLevel == "Beginner")
                {
                    //Hides the form
                    this.Hide();
                    //Opens the Form mentioned
                    frmBeginner1 mynextscreen = new frmBeginner1();
                    mynextscreen.ShowDialog();
                }
                //Checks Which Lever is selected
                else if (playerDetails.quizLevel == "Intermediate")
                {
                    //Hides the form
                    this.Hide();
                    //Opens the Form mentioned
                    frmIntermediate1 mynextscreen = new frmIntermediate1();
                    mynextscreen.ShowDialog();
                }
                //Checks Which Lever is selected
                else if (playerDetails.quizLevel == "Advanced")
                {
                    //Hides the form
                    this.Hide();
                    //Opens the Form mentioned
                    frmAdvanced1 mynextscreen = new frmAdvanced1();
                    mynextscreen.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Select A Level");
                }
                //sets the playerDetails class with the text in the textbox
                playerDetails.playerPassword = txtPlayerPassword.Text;
            }
        }


        private void btnIconSelect_Click(object sender, EventArgs e)
        {
            //Opens the Icon Form
            Icon_Select icon = new Icon_Select();
            icon.ShowDialog();
            //Enables the Next Button
            lblDate.Text = Convert.ToString(DateTime.Now);
            btnNextScreenRules.Enabled = true;
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Hides the form
            this.Hide();
            //opens the last form that was open
            frmLoginRegister mylastscreen = new frmLoginRegister();
            mylastscreen.ShowDialog();
        }

        private void txtPlayerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void txtPlayerPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        
    }
}
        
