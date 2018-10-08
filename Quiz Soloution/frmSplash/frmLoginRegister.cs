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
            MaximizeBox = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlayerSelectionNew NewUser= new frmPlayerSelectionNew();
            NewUser.ShowDialog();
        }

        private void mute_CheckedChanged(object sender, EventArgs e)
        {
            playerDetails.activesound = false;
        }

        private void frmLoginRegister_Load(object sender, EventArgs e)
        {
            
            this.Show();
            string output = "Welcome To Nathan's GCSE I.C.T Quiz 2015";
            speech(output);
        }
    }
}
