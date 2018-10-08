using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace frmSplash
{
    public partial class frmAdvanced1 : Form
    {
        public frmAdvanced1()
        {

            InitializeComponent();
            //Adds all the answers to the String list
            List<string> awnsers = new List<string>();
            awnsers.Add("1 Byte");
            awnsers.Add("1 KiloByte");
            awnsers.Add("1 PetaByte");
            awnsers.Add("1 MegaByte");
            //Declares a random object adds the answers randomly to an array and adds them to the radio buttons
            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
            for (int i = 0; i < awnsers.Capacity; i++)
            {
                Controls.Find("rb" + (i + 1), true).FirstOrDefault().Text = MyRandomArray[i];
            }
            //Disables the Control Box
            ControlBox = false;

            
        }
        frmLoginRegister SoundMethodSpeech = new frmLoginRegister();
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            //Checks if selected answer is correct and adds 1 to score and displays the new current score in a message box

            if (rb1.Checked && rb1.Text == "1 PetaByte"|| rb2.Checked && rb2.Text == "1 PetaByte"||rb3.Checked && rb3.Text == "1 PetaByte"||rb4.Checked&&rb4.Text=="1 PetaByte")
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
                MessageBox.Show("Incorrect\n Youre Score is still \t" + GlobalQuizValues.playerScoreDuringQuiz);
                //if user wants the result spoken back to them it outputs a string message to the speech synthesiser
                if (playerDetails.activesound == true)
                {
                    string output = "That was the wrong Answer, your score is still" +GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }
            
            this.Hide();
            frmAdvanced2 myNextScreen = new frmAdvanced2();
            myNextScreen.Show();
        }

        private void frmQuestion4_Load(object sender, EventArgs e)
        {
            /*Sets the values of the text box
            Enables and starts the timer before setting the maximum value of the progress bar*/
            txtScore.Text = "Hello " + playerDetails.playerName + " your Current Score Is " + GlobalQuizValues.playerScoreDuringQuiz;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 20;
            timer1.Tick += new EventHandler(timer1_Tick);
            progressBar1.Update();
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            /*checks that if the progress bar is full it tells the user they have ran out of time and displays there current score 
            if the progress bar value is below the max value it adds 1 on to it*/
            if (progressBar1.Value != 20)
            {
                progressBar1.Value++;       
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("You ran out of time. Your Score is still: " + GlobalQuizValues.playerScoreDuringQuiz);
                this.Hide();
                frmAdvanced2 mynextscreen = new frmAdvanced2();
                mynextscreen.ShowDialog();
                GlobalQuizValues.playerScoreDuringQuiz = GlobalQuizValues.playerScoreDuringQuiz += 0;
                if (playerDetails.activesound == true)
                {
                    string output = "That was the wrong Answer, your score is still" + GlobalQuizValues.playerScoreDuringQuiz;
                    SoundMethodSpeech.speech(output);
                }
            }

        }
        public void timer1method()
        { 
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 20;
            timer1.Tick += new EventHandler(timer1_Tick);
            progressBar1.Update();    
        }
        private void mnuRules_Click(object sender, EventArgs e)
        {
             //Stops timer, opens the rules form and when the form closes it starts the timer again
            timer1.Stop();
            frmDescriptionRules rules = new frmDescriptionRules();
            rules.ShowDialog();
            if(rules != ActiveForm)
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
        
    }
}
