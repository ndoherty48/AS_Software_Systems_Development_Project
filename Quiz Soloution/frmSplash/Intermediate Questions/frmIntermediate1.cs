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
    public partial class frmIntermediate1 : Form
    {
        public frmIntermediate1()
        {
            InitializeComponent();
            List<string> awnsers = new List<string>();
            awnsers.Add("Musical instrument Digital Interface");
            awnsers.Add("Micro Intellectual Digital Interface");
            awnsers.Add("Musical Instrument Data Interface");
            awnsers.Add("Micro Instrument Data Interlude");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
            for (int i = 0; i < awnsers.Capacity; i++)
            {
                Controls.Find("rb" + (i + 1), true).FirstOrDefault().Text = MyRandomArray[i];
            }
            ControlBox = false;
        }
        

        frmLoginRegister SoundMethodSpeech = new frmLoginRegister();

        
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (rb1.Checked && rb1.Text == "Musical instrument Digital Interface" || rb2.Checked && rb2.Text == "Musical instrument Digital Interface" || rb3.Checked && rb3.Text == "Musical instrument Digital Interface" || rb4.Checked && rb4.Text == "Musical instrument Digital Interface")
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
            frmIntermediate2 myNextScreen = new frmIntermediate2();
            myNextScreen.Show();
        }
        
        private void frmQuestion3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hello " + playerDetails.playerName + " your Current Score Is " + GlobalQuizValues.playerScoreDuringQuiz;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 20;
            timer1.Tick += new EventHandler(timer1_Tick);
            progressBar1.Update();
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 20)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("You ran out of time. Your Score is still: " + GlobalQuizValues.playerScoreDuringQuiz);
                this.Hide();
                frmIntermediate2 mynextscreen = new frmIntermediate2();
                mynextscreen.ShowDialog();
                GlobalQuizValues.playerScoreDuringQuiz = GlobalQuizValues.playerScoreDuringQuiz += 0;
                if (playerDetails.activesound == true)
                {
                    string output = "That was the wrong Answer, your score is still" + GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
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
            DialogResult Restart = MessageBox.Show("Restart", "Are you sure you want to restart?", MessageBoxButtons.OKCancel);
            if (Restart == DialogResult.OK)
            {
                GlobalQuizValues.playerScoreDuringQuiz = 0;
                frmAdvanced1 RestartScreen = new frmAdvanced1();
                this.Hide();
                RestartScreen.ShowDialog();

                GlobalQuizValues.playerScoreDuringQuiz = 0;
            }
            else
            {
                timer1.Start();
            }
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult quit = MessageBox.Show("Quit", "Are You Sure You Want To Quit", MessageBoxButtons.YesNo);
            if (quit == DialogResult.Yes)
            {

                Application.ExitThread();

            }
            else if (quit == DialogResult.No)
            {
                timer1.Start();
            }
        }
        
    }
}
