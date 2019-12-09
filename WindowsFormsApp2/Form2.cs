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
using System.Runtime.InteropServices;
using System;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            GetImages();
            SetImage();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetImages();
            SetImage();
        }
        public event EventHandler Load;
        public static Form2 form2 = new Form2();
        
        private static Random random = new Random();
        private static int Number = random.Next(1, 3);
                
        public static void GetImages()
        {
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    string name = "Image" + i.ToString();
                }
                catch
                {
                    Console.WriteLine("Make sure all the images have a proper name. Ex.) 'Image1' " + "\n" + "Ending Program");
                    Console.ReadLine();
                    Environment.Exit(1);
                }

            }
        }
        public static void SetImage()
        {

            if (System.IO.File.Exists(@"/testimages" + Number + ".png"))
            {
                form2.pictureBox1.Image = Image.FromFile(@"/testimages" + Number + ".png");
                Console.WriteLine("Image Changed to Image" + Number);
                Console.ReadLine();
            }
            //else
            //{
            //    if (File.Exists("E:\Images\Image" + Number + ".jpg"))
            //    {
            //        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, "E:\Images\Image" + Number + ".jpg",
            //        SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            //        Console.WriteLine("Image Changed to Image" + Number);
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        if (File.Exists("D:\Images\Image" + Number + ".jpg"))
            //        {
            //            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, "D:\Images\Image" + Number + ".jpg",
            //            SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            //            Console.WriteLine("Image Changed to Image" + Number);
            //            Console.ReadLine();
            //        }
                    else
                    {
                        Console.Write("Failed. Image couldn't be found");
                        Console.ReadLine();
                    }
                }
            }
        } 
    


        

