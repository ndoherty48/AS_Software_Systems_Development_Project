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
    
    public partial class frmAdvanced2 : Form 
    {
        public void methodinteraction()
        {
            frmAdvanced1 frm = new frmAdvanced1();
            frm.timer1method();
        }

        frmLoginRegister SoundMethodSpeech = new frmLoginRegister();
        public frmAdvanced2()
        {
            InitializeComponent();
            MaximizeBox = false;
            
        }
        frmAdvanced1 timer = new frmAdvanced1();
        private void frmQuestion8_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hello " + playerDetails.playerName + " your Current Score Is " + GlobalQuizValues.playerScoreDuringQuiz;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 15;
            timer1.Tick += new EventHandler(timer1_Tick);
            progressBar1.Update();



        }
        private void frmAdvanced2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hello " + playerDetails.playerName + " your Current Score Is " + GlobalQuizValues.playerScoreDuringQuiz;
            methodinteraction();

        }

        void timer1_Tick(object sender, EventArgs e)
        {
            
            
            if (progressBar1.Value != 15)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("You ran out of time. Your Score is still: " + GlobalQuizValues.playerScoreDuringQuiz);
                this.Hide();
                frmAdvanced3 mynextscreen = new frmAdvanced3();
                mynextscreen.ShowDialog();
                GlobalQuizValues.playerScoreDuringQuiz = GlobalQuizValues.playerScoreDuringQuiz += 0;
                if (playerDetails.activesound == true)
                {
                    string output = "That was the wrong Answer, your score is still" + GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
            if(txtAwnser.Text == "Bitcoin"||txtAwnser.Text == "bitcoin")
            {
                GlobalQuizValues.playerScoreDuringQuiz += 1;
                pctCorrect.Visible = true;
                pctIncorrect.Visible = false;
                MessageBox.Show("Correct\n Your New Score is \t" + GlobalQuizValues.playerScoreDuringQuiz);
                if (playerDetails.activesound == true)
                {
                    string output = "That Was the correct Answer, Your New Score is" +GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }
            else
            {
                GlobalQuizValues.playerScoreDuringQuiz += 0;
                pctCorrect.Visible = false;
                pctIncorrect.Visible = true;
                MessageBox.Show("InCorrect\n Your Score is Still\t" + GlobalQuizValues.playerScoreDuringQuiz);
                if (playerDetails.activesound == true)
                {
                    string output = "That was the wrong Answer, your score is still"+GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }

            this.Hide();
            frmAdvanced3 myNextScreen = new frmAdvanced3();
            myNextScreen.Show();
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
                frmAdvanced1 RestartScreen = new frmAdvanced1();
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
