using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            int Number = GetNum();
            DisplayImg(Number);
        }
        private int GetNum()
        {
            Random random = new Random();
            int Number = random.Next(22, 27);
            return Number;
        }
        private void DisplayImg(int FUCK)
        {
            pictureBox1.Image = Image.FromFile("Images/image" + FUCK + ".png");
            //"You're sending number into FUCK"
        }

    }
}
