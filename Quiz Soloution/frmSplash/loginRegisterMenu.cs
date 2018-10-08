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
    public partial class loginRegisterMenu : Form
    {
        public loginRegisterMenu()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
       
        private void loginRegisterMenu_Load(object sender, EventArgs e)
        {
            this.Show();
            
        }

        private bool loginClicked = false;
        private bool registerClicked = false;

        public void speech(string vocalmessage)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(vocalmessage);
            synth.SelectVoiceByHints(VoiceGender.Female);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginClicked = true;
            mute();
        }

        public void threading()
        {
            Application.ExitThread();
            
        }

        public void mute()
        {
            if (muteYes.Checked == true && muteNo.Checked == false)
            {
                playerDetails.activesound = true;
                string output = "Welcome To The GCSE I.C.T Quiz 2015";

                //NotifyIcon em = new NotifyIcon();
                //em.Visible = true;
                //em.Icon = System.Drawing.SystemIcons.Information;
                //em.ShowBalloonTip(3000, "Your Message is Playing", "", ToolTipIcon.Info);
                speech(output);


                if (loginClicked == true)
                {
                    this.Hide();

                    frmLogin login = new frmLogin();
                    login.ShowDialog();
                }
                if (registerClicked == true)
                {
                    this.Hide();
                    frmLoginRegister register = new frmLoginRegister();
                    register.ShowDialog();
                }


            }
            else if (muteNo.Checked == true && muteYes.Checked == false)
            {
                playerDetails.activesound = false;
                if (loginClicked == true)
                {
                    this.Hide();
                    frmLogin login = new frmLogin();
                    login.ShowDialog();
                }
                if (registerClicked == true)
                {
                    this.Hide();
                    frmPlayerSelectionNew register = new frmPlayerSelectionNew();
                    register.ShowDialog();
                }
            }
            else if (muteYes.Checked == true && muteNo.Checked == true)
            {
                MessageBox.Show("Please select a choice regarding if you want speech!!");
            }
            else if (muteNo.Checked == false && muteYes.Checked == false)
            {
                MessageBox.Show("Please select a choice regarding if you want speech!!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            registerClicked = true;
            mute();
        }
    }
}
