using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSplash
{
    public partial class frmDescriptionRules : Form
    {
        public frmDescriptionRules()
        {
            InitializeComponent();
        }

        private void frmDescriptionRules_Load(object sender, EventArgs e)
        {
            rtbRules.Text = "";
        }

        private void btnNextScreenQuestions_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmQuestion1 myNextScreen = new frmQuestion1();
            //myNextScreen.ShowDialog();

            if (playerDetails.quizLevel == "Beginner")
            {
                frmBeginner1 myBeginnerscreen = new frmBeginner1();
                myBeginnerscreen.Show();
            }
            else if (playerDetails.quizLevel == "Intermediate")
            {
                frmIntermediate1 myBeginnerscreen = new frmIntermediate1();
                myBeginnerscreen.Show();
            }
            else if (playerDetails.quizLevel == "Advanced")
            {
                frmAdvanced1 myBeginnerscreen = new frmAdvanced1();
                myBeginnerscreen.Show();
            }
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbRules.Text = "";
            string filePathRules = "../../Text Files/Rules.Txt";
            string[] linesFromFileRules = File.ReadAllLines(filePathRules);

            for (int Counter = 0; Counter < linesFromFileRules.Length; Counter++)
            {
                rtbRules.Text += linesFromFileRules[Counter];
                rtbRules.Text += "\n\n";
            }
        }

        private void howToRegisterLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbRules.Text = "";
            string filePathRules = "../../Text Files/logininfo.Txt";
            string[] linesFromFileRules = File.ReadAllLines(filePathRules);

            for (int Counter = 0; Counter < linesFromFileRules.Length; Counter++)
            {
                rtbRules.Text += linesFromFileRules[Counter];
                rtbRules.Text += "\n\n";
            }
        }
    }
}
