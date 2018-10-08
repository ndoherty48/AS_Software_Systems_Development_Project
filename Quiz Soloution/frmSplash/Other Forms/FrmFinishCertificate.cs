using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace frmSplash
{
    public partial class FrmFinishCertificate : Form
    {
        public FrmFinishCertificate()
        {
            InitializeComponent();
            //Sets the Text value of the button
            printButton.Text = "Print Form";
            //When the button is pressed it calls an event
            printButton.Click += new EventHandler(printButton_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.Controls.Add(printButton);
        }

        private void FrmFinishCertificate_Load(object sender, EventArgs e)
        {
            //Sets the playerDetails Class contents with the text Defined Below
            lblDate.Text = Convert.ToString(playerDetails.quizdate);
            lblLevel.Text = playerDetails.quizLevel;
            lblName.Text = playerDetails.playerName;
            lblScore.Text = Convert.ToString(GlobalQuizValues.playerScoreDuringQuiz);
        }
        private Button printButton = new Button();
        private PrintDocument printDocument1 = new PrintDocument();
        

        void printButton_Click(object sender, EventArgs e)
        {
            //Calls The Method CaptureScreen which is used to screen capture the form
            CaptureScreen();
            //Calls up the print dialog to print the document
            printDocument1.Print();
        }


        Bitmap memoryImage;

        private void CaptureScreen()
        {
            //Code to Capture the contents of the form on the screen 
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Captures the screen
            CaptureScreen();
            //Creates a Print Dialog
            PrintDialog printDialog1 = new PrintDialog();
            //Opens the Print Dialog that was just created
            printDialog1.ShowDialog();
            //if the ok button is pressed it prints the Image that was captured Graphics
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                
                printDocument1.Print();
            }
            
        }
        
    }
}
