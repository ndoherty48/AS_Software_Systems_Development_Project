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
            //Disables the Control Box
            ControlBox = false;
            //Disables the Login Button so that the user cannot Login until They click the "Select Icon" Button
            btnLogin.Enabled = false;
            cboQuizLevel.Items.AddRange(arrQuizLevels);
        }

        string[] arrQuizLevels = new string[]
        {
            "Beginner",
            "Intermediate",
            "Advanced"
        };

        public void frmLogin_Load(object sender, EventArgs e)
        {
            cboQuizLevel.Items.AddRange(arrQuizLevels);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Closes the Current Screen
            this.Hide();
            frmLoginRegister FirstScreen = new frmLoginRegister();
            //Opens The Previous Form Mentioned up above and assigned to the name: 'FirstScreen'
            FirstScreen.ShowDialog();
        }
       
        void errorMessage()
        {
            //Displays a message box Telling the user that they havent used the correct details
            MessageBox.Show("Please Use Correct Details");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Creates A String Array to hold all the Usernames in the text file
            string[] usernames = System.IO.File.ReadAllLines(@"./Text Files/usernames.txt");
            //Creates A String Array to hold all the Passwords in the text file
            string[] Passwords = System.IO.File.ReadAllLines(@"./Text Files/Passwords.txt");
            //Creates a boolean value to call code when the value = true
            bool loggedOn = false;
            
            //if the combobox doesnt contain a level it will return a false reading on the boolean
            if(cboQuizLevel.Text != "Beginner" || cboQuizLevel.Text != "Intermediate" || cboQuizLevel.Text != "Advanced")
            {
                loggedOn = false;
            }
            
            //Creates a for loop to check usernames and passwords
            for (int i = 0; i < usernames.Length; i++)
            {
                
                //Checks if the username is in the string array
                if (txtUsername.Text == usernames[i])
                {
                    //Checks if the Password is in the string array
                    if (txtPassword.Text == Passwords[i])
                    {
                        loggedOn = true;
                    }
                    //if its not in the array it sets the boolean value to false
                    else
                    {
                        loggedOn = false;
                    }
                }
                //if its not in the array it sets the boolean value to false
                else
                {
                    loggedOn = false;
                }
            }
            
            //Only Starts if the boolean value has been set to true
            if (loggedOn == true)
            {
                //Sets all the inputted values to the playerDetails Class
                playerDetails.quizLevel = cboQuizLevel.Text;
                playerDetails.playerName = txtUsername.Text;
                playerDetails.playerPassword = txtPassword.Text;
                playerDetails.quizdate = DateTime.Now;
                this.Hide();
                if (playerDetails.quizLevel == "Beginner")
                {
                    //If the Beginner level is selected it opens the first Beginner Question
                    frmBeginner1 mynextscreen = new frmBeginner1();
                    mynextscreen.ShowDialog();
                }
                else if (playerDetails.quizLevel == "Intermediate")
                {
                    //If the Intermediate level is selected it opens the first Intermediate Question
                    frmIntermediate1 mynextscreen = new frmIntermediate1();
                    mynextscreen.ShowDialog();
                }
                else if (playerDetails.quizLevel == "Advanced")
                {
                    //If the advanced level is selected it opens the first Advanced Question
                    frmAdvanced1 mynextscreen = new frmAdvanced1();
                    mynextscreen.ShowDialog();
                }
            }
            else if(loggedOn == false)
            {
                //Calls the errormessage Method
                errorMessage();
            }
        }
        
        private void btnIcon_Click(object sender, EventArgs e)
        {
            //Opens The Select Image Form for the user to select their icon
            Icon_Select mynextscreen = new Icon_Select();
            mynextscreen.ShowDialog();
            //Enables the Login Button So that the user can login
            btnLogin.Enabled = true;
        }

        
    }
}

