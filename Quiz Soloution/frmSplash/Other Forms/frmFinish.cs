using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace frmSplash
{
    public partial class frmFinish : Form
    {
        public frmFinish()
        {
            InitializeComponent();
            //Disables the Control Box
            ControlBox = false;
            //Disables the button btnExit
            btnExit.Enabled = false;
            RestartLevel.Enabled = false;
            btnCertificate.Enabled = false;
            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            //Clears the Rich Text Box of any Text
            rtbOutput.Text = "";

            //Sets the File path for the users info to go to
            string filePath = "./Text Files/txtScores.txt";

            //Reads all the lines in the text file
            string[] fileLinesToBeRead = File.ReadAllLines(filePath);

            //Sets the quiz Number from the file
            GlobalQuizValues.numberOfGamesPlayed = fileLinesToBeRead.Length / 7;
            playerDetails.quizNumber = (GlobalQuizValues.numberOfGamesPlayed + 1).ToString();

            
            //Creates an array containing all the info to be written to a text file
            string[] fileLinesToBeWritten = { "Quiz Number = " + playerDetails.quizNumber, "Player Name = " + playerDetails.playerName,"Player Password = " + playerDetails.playerPassword,"Quiz Level = " + playerDetails.quizLevel, "Player Icon Number = " +  playerDetails.playericon.ToString(), "Player Score = " +GlobalQuizValues.playerScoreDuringQuiz, };

            //Enables the btnExit button
            btnExit.Enabled = true;
            btnCertificate.Enabled = true;
            RestartLevel.Enabled = true;

            //Writes the string array to the filePath
            File.AppendAllLines(filePath, fileLinesToBeWritten);
            
            //Places each item on a new line in the text Box
            foreach (string item in fileLinesToBeWritten)
            {
                rtbOutput.Text = rtbOutput.Text + item + "\n";
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the program and the thread
            Application.ExitThread();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //opens the certificate form when button clicked
            FrmFinishCertificate certificate = new FrmFinishCertificate();
            certificate.Show();
        }

        private void RestartLevel_Click(object sender, EventArgs e)
        {
            //sets the score back to 0
            GlobalQuizValues.playerScoreDuringQuiz = 0;
            //if the beginner level is selected it opens that level
            if (cboRestartLevels.Text == "Beginner")
            {
                frmBeginner1 beginner = new frmBeginner1();
                this.Hide();
                beginner.ShowDialog();
                GlobalQuizValues.playerScoreDuringQuiz = 0;
            }
            //if the Intermediate level is selected it opens that level
            else if (cboRestartLevels.Text == "Intermediate")
            {
                frmIntermediate1 intermediate = new frmIntermediate1();
                this.Hide();
                intermediate.ShowDialog();
                GlobalQuizValues.playerScoreDuringQuiz = 0;
            }
            //if the Advanced level is selected it opens that level
            else if (cboRestartLevels.Text == "Advanced")
            {
                frmAdvanced1 advanced = new frmAdvanced1();
                this.Hide();
                advanced.ShowDialog();
                GlobalQuizValues.playerScoreDuringQuiz = 0;
            }
            //If No Level is selected it just displays a Message box
            else if(cboRestartLevels.Text == "")
            {
                MessageBox.Show("Please select a Level");
            }
        }

        private void frmFinish_Load(object sender, EventArgs e)
        {

        }
        
    }
}
