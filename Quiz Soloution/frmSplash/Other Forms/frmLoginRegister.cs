using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace frmSplash
{
    public partial class frmLoginRegister : Form
    {
        public void speech(string vocalmessage)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(vocalmessage);
            synth.SelectVoiceByHints(VoiceGender.Female);
        }
        public frmLoginRegister()
        {
            InitializeComponent();
            ControlBox = false;
        }

        //Creates a boolean value and sets it to false
        private bool loginClicked = false;
        //Creates a boolean value and sets it to false
        private bool registerClicked = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //sets the boolean value to true
            loginClicked = true;
            //calls the mute method
            mute();          
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Sets the boolean value to true
            registerClicked = true;
            //Calls the mute method
            mute();
        }

        private void frmLoginRegister_Load(object sender, EventArgs e)
        {
            this.Show();
        }
        public void mute()
        {
            //Checks whether the muteYes checkbox is pressed and the muteNo is not checked
            if(muteYes.Checked == true && muteNo.Checked == false)
            {
                //sets the boolean value in the class playerDetails
                playerDetails.activesound = true;
                //Creates a string containing the message
                string output = "Welcome To The GCSE I.C.T Quiz 2015";
                
                //Calls the method Speech and passes the string output to the Method
                speech(output);
                
                //creates an if statement to check if the login button has been pressed
                if (loginClicked == true)
                {
                    //Hides the form
                    this.Hide();
                    //Opens Login Page
                    frmLogin login = new frmLogin();
                    login.ShowDialog();
                }
                //Checks if register button has been pressed
                if(registerClicked == true)
                {
                    //Hides the form
                    this.Hide();
                    //Opens Register Form
                    frmPlayerSelectionNew register = new frmPlayerSelectionNew();
                    register.ShowDialog();
                }
                
                
            }
            // Checks if the muteNo is checked and if the muteYes hasnt been checked
            else if(muteNo.Checked == true && muteYes.Checked == false)
            {
                //creates an if statement to check if the login button has been pressed
                if (loginClicked == true)
                {
                    //Hides the form
                    this.Hide();
                    //Opens Login Page
                    frmLogin login = new frmLogin();
                    login.ShowDialog();
                }
                //Checks if register button has been pressed
                if (registerClicked == true)
                {
                    //Hides the form
                    this.Hide();
                    //Opens Register Form
                    frmPlayerSelectionNew register = new frmPlayerSelectionNew();
                    register.ShowDialog();
                }


            }
            //checks if both checkboxes are checked
            else if(muteYes.Checked == true && muteNo.Checked == true)
            {
                //Shows a message box to tell them that they have to select one checkbox
                MessageBox.Show("Please select a choice regarding if you want speech!!");
            }
            //checks if both checkboxes are unchecked
            else if (muteNo.Checked == false && muteYes.Checked == false)
            {
                //Shows a message box to tell them that they have to select one checkbox
                MessageBox.Show("Please select a choice regarding if you want speech!!");
            }
        }
        
        
    }
}
