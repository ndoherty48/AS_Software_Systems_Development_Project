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
    public partial class RandomQuestions : Form
    {
        
        #region Advanced-Random-Methods
        public void Advanced1Random(List<RadioButton> rbs)
        {
            
            List<string> awnsers = new List<string>();
            awnsers.Add("1 Byte");
            awnsers.Add("1 KiloByte");
            awnsers.Add("1 PetaByte");
            awnsers.Add("1 MegaByte");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();

            
            
        }

        public void Advanced2Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public void Advanced3Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public static void Advanced4Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public void Advanced5Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }
        #endregion
        #region Intermediate-Random-Methods
        public void Intermediate1Random()
        {

            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public void Intermediate2Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public void Intermediate3Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public  void Intermediate4Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public void Intermediate5Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }
        #endregion
        #region Beginner-Random-Methods
        public void Beginner1Random()
        {

            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public void Beginner2Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public void Beginner3Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public void Beginner4Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }

        public void Beginner5Random()
        {
            List<string> awnsers = new List<string>();
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");
            awnsers.Add("");

            Random rnd = new Random();
            string[] MyRandomArray = awnsers.OrderBy(x => rnd.Next()).ToArray();
        }
        #endregion
    }
}