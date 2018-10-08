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
    public partial class Icon_Select : Form
    {
        public Icon_Select()
        {
            InitializeComponent();
            ControlBox = false;
        }
        int arrayyplayericon = 0;
        

        private void Icon1_MouseDown(object sender, MouseEventArgs e)
        {
            Icon1.DoDragDrop(Icon1.Image, DragDropEffects.Copy);
            arrayyplayericon = 1;
        }

        private void Icon2_MouseDown(object sender, MouseEventArgs e)
        {
            Icon2.DoDragDrop(Icon2.Image, DragDropEffects.Copy);
            arrayyplayericon = 2;
        }

        private void Icon3_MouseDown(object sender, MouseEventArgs e)
        {
            Icon3.DoDragDrop(Icon3.Image, DragDropEffects.Copy);
            arrayyplayericon = 3;
        }

        private void Icon4_MouseDown(object sender, MouseEventArgs e)
        {
            Icon4.DoDragDrop(Icon4.Image, DragDropEffects.Copy);
            arrayyplayericon = 4;
        }

        private void Icon5_MouseDown(object sender, MouseEventArgs e)
        {
            Icon5.DoDragDrop(Icon5.Image, DragDropEffects.Copy);
            arrayyplayericon = 5;
        }

        private void Icon6_MouseDown(object sender, MouseEventArgs e)
        {
            Icon6.DoDragDrop(Icon6.Image, DragDropEffects.Copy);
            arrayyplayericon = 6;
        }

        private void chosenicon_DragDrop(object sender, DragEventArgs e)
        {
            chosenicon.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void chosenicon_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if(arrayyplayericon == 0)
            {
                
                playerDetails.playericon = arrayyplayericon;
                MessageBox.Show("No Icon Is Selected, Please Select an Icon");
            }
            else
            {
                playerDetails.playericon = arrayyplayericon;
                this.Hide();
            }
        }

        private void Icon_Select_Load(object sender, EventArgs e)
        {
            Icon1.AllowDrop = true;
            Icon2.AllowDrop = true;
            Icon3.AllowDrop = true;
            Icon4.AllowDrop = true;
            Icon5.AllowDrop = true;
            Icon6.AllowDrop = true;
            chosenicon.AllowDrop = true;
        }
    }
}
