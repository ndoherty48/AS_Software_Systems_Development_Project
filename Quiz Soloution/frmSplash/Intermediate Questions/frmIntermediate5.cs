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
    public partial class frmIntermediate5 : Form
    {
        public frmIntermediate5()
        {
            InitializeComponent();
            //Adds all the answers to the list strings
            List<string> awnsers = new List<string>();
            awnsers.Add("Data Protection Act 1998");
            awnsers.Add("Computer Misuse Act 1990");
            awnsers.Add("Copyright Act 1988");
            awnsers.Add("Consumer Protection Act 1987");

            //Creates a new random object
            Random rnd = new Random();
            //Adds the answers to the array randomly each load
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
            //adds the answers to the radio buttons
            for (int i = 0; i < awnsers.Capacity; i++)
            {
                Controls.Find("rb" + (i + 1), true).FirstOrDefault().Text = MyRandomArray[i];
            }
            //Disables the Control Box
            ControlBox = false;
        }
        //Declares the Login Register page to use a method from the form
        frmLoginRegister SoundMethodSpeech = new frmLoginRegister();

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            //Stops The Timer
            timer1.Stop();
            if (rb1.Checked && rb1.Text == "Data Protection Act 1998" || rb2.Checked && rb2.Text == "Data Protection Act 1998" || rb3.Checked && rb3.Text == "Data Protection Act 1998" || rb4.Checked && rb4.Text == "Data Protection Act 1998")
            {
                //Adds 1 on to the score
                GlobalQuizValues.playerScoreDuringQuiz += 1;
                //Shows the pctcorrect and hides the pctincorrect
                pctCorrect.Visible = true;
                pctIncorrect.Visible = false;
                //Shows a message box displaying the users score
                MessageBox.Show("Correct\n Your New Score is \t" + GlobalQuizValues.playerScoreDuringQuiz);
                //checks if the user has enabled speech and if true plays a message
                if (playerDetails.activesound == true)
                {
                    string output = "That Was the correct answer, Your New Score is" + GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }
            else
            {
                //Adds 0 on to the score of the user
                GlobalQuizValues.playerScoreDuringQuiz += 0;
                //Displays the incorrect image and hides the correct image
                pctCorrect.Visible = false;
                pctIncorrect.Visible = true;
                //Shows a Message box telling them they got it incorrect and what there score was
                MessageBox.Show("Incorrect\n Youre Score is still \t" + GlobalQuizValues.playerScoreDuringQuiz);
                //checks if the user has enabled speech and if true plays a message
                if (playerDetails.activesound == true)
                {
                    string output = "That was the wrong answer, your score is still" + GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }
            //Hides The Form
            this.Hide();
            //Opens the finish form
            frmFinish myNextScreen = new frmFinish();
            myNextScreen.Show();
        }

        private void frmQuestion15_Load(object sender, EventArgs e)
        {
            //displays the player name sand score in the textbox
            textBox1.Text = "Hello " + playerDetails.playerName + " your Current Score Is " + GlobalQuizValues.playerScoreDuringQuiz;
            //Enables and starts the timer
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            //Maximum value that the progress bar can hold is 20
            progressBar1.Maximum = 20;
            timer1.Tick += new EventHandler(timer1_Tick);
            progressBar1.Update();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            //Checks if the progress bar is not equal to 20 then adds 1 to the progress bar
            if (progressBar1.Value != 20)
            {
                progressBar1.Value++;
            }
            else
            {
                //Stops The timer and displays a messagebox
                timer1.Stop();
                MessageBox.Show("You ran out of time. Your Score is still: " + GlobalQuizValues.playerScoreDuringQuiz);
                //hides the form
                this.Hide();
                //opens next form
                frmFinish mynextscreen = new frmFinish();
                mynextscreen.ShowDialog();
                //adds 0 to the score
                GlobalQuizValues.playerScoreDuringQuiz = GlobalQuizValues.playerScoreDuringQuiz += 0;
                //checks if the user has enabled speech and if true plays a message
                if (playerDetails.activesound == true)
                {
                    string output = "That was the wrong Answer, your score is still" + GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }
        }

        private void mnuRules_Click(object sender, EventArgs e)
        {
            //Stops The Timer
            timer1.Stop();
            //Declares a form to open 
            frmDescriptionRules rules = new frmDescriptionRules();
            rules.ShowDialog();
            //if the rules page has been closed it starts the timer again
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
            //Stops The Timer
            timer1.Stop();
            //prompts the user to see if they really want to quit
            DialogResult quit = MessageBox.Show("Quit", "Are You Sure You Want To Quit", MessageBoxButtons.YesNo);
            if (quit == DialogResult.Yes)
            {
                //Exits the thread
                Application.ExitThread();

            }
            //starts the timer if no has been selected
            else if (quit == DialogResult.No)
            {
                timer1.Start();
            }
        }
        
    }
}
