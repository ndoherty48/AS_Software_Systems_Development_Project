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
            //Clears the text box and sets it to read only
            rtbRules.Text = "";
            rtbRules.ReadOnly = true;
        }

        private void btnNextScreenQuestions_Click(object sender, EventArgs e)
        {

            this.Close();
            
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
            //Clears Text Box
            rtbRules.Text = "";
            //Sets the filepath for the text file of rules
            string filePathRules = "./Text Files/Rules.Txt";
            //Adds all the lines in the text file to the array from the filePath
            string[] linesFromFileRules = File.ReadAllLines(filePathRules);

            //Adds each line in the text file to a new line in the text box
            for (int Counter = 0; Counter < linesFromFileRules.Length; Counter++)
            {
                rtbRules.Text += linesFromFileRules[Counter];
                rtbRules.Text += "\n\n";
            }
        }

        private void howToRegisterLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears The Rich text box
            rtbRules.Text = "";
            //Sets the file path for the rules
            string filePathRules = "./Text Files/logininfo.Txt";
            //adds the text to the array from the file path
            string[] linesFromFileRules = File.ReadAllLines(filePathRules);
            //adds all the lines in the array to the text box
            for (int Counter = 0; Counter < linesFromFileRules.Length; Counter++)
            {
                rtbRules.Text += linesFromFileRules[Counter];
                rtbRules.Text += "\n\n";
            }
        }

        
    }
}
