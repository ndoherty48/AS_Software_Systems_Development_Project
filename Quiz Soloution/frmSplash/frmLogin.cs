using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSplash
{
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
            MaximizeBox = false;
            btnLogin.Enabled = false;
        }


        public void frmLogin_Load(object sender, EventArgs e)
        {    
             string[] arrQuizLevels = new string[]
             {
            "Beginner",
            "Intermediate",
            "Advanced"
            };

            foreach (string quizLevel in arrQuizLevels)
            {
                cboQuizLevel.Items.Add(quizLevel);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginRegister FirstScreen = new frmLoginRegister();
            FirstScreen.ShowDialog();
        }
        void errorMessage()
        {
            MessageBox.Show("Please Use Correct Details");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string[] usernames = System.IO.File.ReadAllLines(@".../.../Text Files/usernames.txt");
            string[] Passwords = System.IO.File.ReadAllLines(@".../.../Text Files/Passwords.txt");
            playerDetails.quizLevel = cboQuizLevel.Text;
            playerDetails.playerName = txtUsername.Text;
            playerDetails.playerPassword = txtPassword.Text;
            playerDetails.quizdate = DateTime.Now;
            bool loggedOn = false;
            
            
            if(cboQuizLevel.Text != "Beginner" || cboQuizLevel.Text != "Intermediate" || cboQuizLevel.Text != "Advanced")
            {
                loggedOn = false;
            }
            
            for (int i = 0; i < usernames.Length; i++)
            {
                
                if (txtUsername.Text == usernames[i])
                {
                    if (txtPassword.Text == Passwords[i])
                    {
                        loggedOn = true;
                    }
                    else
                    {
                        loggedOn = false;
                    }
                    
                }
                else
                {
                    loggedOn = false;
                }
                

            }
            
            
            if (loggedOn == true)
            {
                this.Hide();
                if (playerDetails.quizLevel == "Beginner")
                {
                    
                    frmBeginner1 mynextscreen = new frmBeginner1();
                    mynextscreen.ShowDialog();
                }
                else if (playerDetails.quizLevel == "Intermediate")
                {
                    
                    frmIntermediate1 mynextscreen = new frmIntermediate1();
                    mynextscreen.ShowDialog();
                }
                else if (playerDetails.quizLevel == "Advanced")
                {
                    
                    frmAdvanced1 mynextscreen = new frmAdvanced1();
                    mynextscreen.ShowDialog();
                }
            }
            else if(loggedOn == false)
            {
                errorMessage();
            }
        }
        
        private void btnIcon_Click(object sender, EventArgs e)
        {
            Icon_Select mynextscreen = new Icon_Select();
            mynextscreen.ShowDialog();
            btnLogin.Enabled = true;
        }
    }
}

