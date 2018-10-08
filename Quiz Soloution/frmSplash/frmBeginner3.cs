using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSplash
{
    public partial class frmBeginner3 : Form
    {
        public frmBeginner3()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        frmLoginRegister SoundMethodSpeech = new frmLoginRegister();

        private void btnNextQuestion_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            if (rb2.Checked)
            {
                GlobalQuizValues.playerScoreDuringQuiz += 1;
                pctCorrect.Visible = true;
                pctIncorrect.Visible = false;
                MessageBox.Show("Correct\n Your New Score is \t" + GlobalQuizValues.playerScoreDuringQuiz);
                if (playerDetails.activesound == true)
                {
                    string output = "That Was the correct Answer, Your New Score is" + GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }
            else
            {
                GlobalQuizValues.playerScoreDuringQuiz += 0;
                pctCorrect.Visible = false;
                pctIncorrect.Visible = true;
                MessageBox.Show("Incorrect\n Youre Score is still \t" + GlobalQuizValues.playerScoreDuringQuiz);
                if (playerDetails.activesound == true)
                {
                    string output = "That was the wrong Answer, your score is still" + GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }
            
            this.Hide();
            frmBeginner4 myNextScreen = new frmBeginner4();
            myNextScreen.Show();
        }

        private void frmQuestion5_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hello " + playerDetails.playerName + " your Current Score Is " + GlobalQuizValues.playerScoreDuringQuiz;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
            progressBar1.Update();
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("You ran out of time. Your Score is still: " + GlobalQuizValues.playerScoreDuringQuiz);
                this.Hide();
                frmBeginner4 mynextscreen = new frmBeginner4();
                mynextscreen.ShowDialog();
                GlobalQuizValues.playerScoreDuringQuiz = GlobalQuizValues.playerScoreDuringQuiz += 0;
            }
        }

        private void mnuRules_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            frmDescriptionRules rules = new frmDescriptionRules();
            rules.ShowDialog();
            if (rules != ActiveForm)
            {
                timer1.Start();
            }

        }

        private void mnuRestart_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult Restart = MessageBox.Show("Are you sure you want to restart?");
            if (Restart == DialogResult.OK)
            {
                frmBeginner1 RestartScreen = new frmBeginner1();
                this.Hide();
                RestartScreen.ShowDialog();
            }
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult Quit = MessageBox.Show("Are you Sure you want to Quit");
            if (Quit == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
