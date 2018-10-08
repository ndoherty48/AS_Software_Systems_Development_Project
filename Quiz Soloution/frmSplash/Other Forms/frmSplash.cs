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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Disables the Control Box
            ControlBox = false;
            //Enables the timer
            timer1.Enabled = true;
            //Starts the timer
            timer1.Start();
            //Sets how often the timer updates
            timer1.Interval = 1000;
            //Sets the maximum the progress bar can hold
            pbSplashTimer.Maximum = 5;
            
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        
        void timer1_Tick(object sender, EventArgs e)
        {
            //checks if the value of the progress bar is not equal to 5
            if (pbSplashTimer.Value != 5)
            {
                //Adds one on to the progress bar
                pbSplashTimer.Value++;
            }
            
            else
            {
                //Stops the timer
                timer1.Stop();
                //Hides The Form
                this.Hide();
                //Opens the next form
                frmLoginRegister mynextscreen = new frmLoginRegister();
                mynextscreen.ShowDialog();
            }
            
        }
    }
}
