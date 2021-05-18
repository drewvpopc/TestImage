using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            int Number = GetNum();
            DisplayImg(Number);
        }
        private int GetNum()
        {
            Random random = new Random();
            int Number = random.Next(1, 8);
            return Number;
        }
        private void DisplayImg(int FUCK)
        {

            pictureBox1.Image = Image.FromFile("TheBigGay/image" + FUCK + ".png");
            //"You're sending number into FUCK"           
        }

    }
}
