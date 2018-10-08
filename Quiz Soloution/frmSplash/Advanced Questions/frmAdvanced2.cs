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
            ControlBox = false;

        }
        frmAdvanced1 timer = new frmAdvanced1();
        private void frmQuestion8_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hello " + playerDetails.playerName + " your Current Score Is " + GlobalQuizValues.playerScoreDuringQuiz;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 25;
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

            /*checks that if the progress bar is full it tells the user they have ran out of time and displays there current score 
            if the progress bar value is below the max value it adds 1 on to it*/
            if (progressBar1.Value != 25)
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
            //Checks if selected answer is correct and adds 1 to score and displays the new current score in a message box
            if (txtAwnser.Text == "Bitcoin"||txtAwnser.Text == "bitcoin")
            {
                GlobalQuizValues.playerScoreDuringQuiz += 1;
                pctCorrect.Visible = true;
                pctIncorrect.Visible = false;
                MessageBox.Show("Correct\n Your New Score is \t" + GlobalQuizValues.playerScoreDuringQuiz);
                //if user wants the result spoken back to them it outputs a string message to the speech synthesiser
                if (playerDetails.activesound == true)
                {
                    string output = "That Was the correct Answer, Your New Score is" +GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }
            //if answer is not right it keeps the score the same, displays incorrect image and displays a message box containing relevant info
            else
            {
                GlobalQuizValues.playerScoreDuringQuiz += 0;
                pctCorrect.Visible = false;
                pctIncorrect.Visible = true;
                MessageBox.Show("InCorrect\n Your Score is Still\t" + GlobalQuizValues.playerScoreDuringQuiz);
                //if user wants the result spoken back to them it outputs a string message to the speech synthesiser
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
            //Stops timer, opens the rules form and when the form closes it starts the timer again
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
            /*Stops the timer & then prompts the user if they want to quit and only if yes is selected does the quiz restart.
            if it restarts it resets the score of the user*/
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
            /*Stops the timer before prompting user if they are sure that they want to quit and exits thread if yes is selected
            starts timer if No Is selected*/
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

        private void txtAwnser_MouseClick(object sender, MouseEventArgs e)
        {
            //Clears text box
            txtAwnser.Clear();
        }

        
    }
}
