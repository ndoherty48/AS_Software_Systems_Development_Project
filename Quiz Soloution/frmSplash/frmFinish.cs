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
            MaximizeBox = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            
            rtbOutput.Text = "";

          
            string filePath = "../../Text Files/txtScores.txt";

            
            string[] fileLinesToBeRead = File.ReadAllLines(filePath);

            GlobalQuizValues.numberOfGamesPlayed = fileLinesToBeRead.Length / 7;
            playerDetails.quizNumber = (GlobalQuizValues.numberOfGamesPlayed + 1).ToString();

            

            string[] fileLinesToBeWritten = { "Quiz Number = " + playerDetails.quizNumber, "Player Name = " + playerDetails.playerName,"Player Password = " + playerDetails.playerPassword,"Quiz Level = " + playerDetails.quizLevel, "Player Icon Number = " +  playerDetails.playericon.ToString(), "Player Score = " +GlobalQuizValues.playerScoreDuringQuiz, };

            
            File.AppendAllLines(filePath, fileLinesToBeWritten);
            
            foreach (string item in fileLinesToBeWritten)
            {
                rtbOutput.Text = rtbOutput.Text + item + "\n";
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFinishCertificate certificate = new FrmFinishCertificate();
            certificate.Show();
        }
    }
}
