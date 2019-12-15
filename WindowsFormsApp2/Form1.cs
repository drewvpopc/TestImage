using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            //new Form3().Show();
            new Form4().Show();
            new Form5().Show();
            new Form6().Show();
            label2.Visible = true;
        }


    }
}
