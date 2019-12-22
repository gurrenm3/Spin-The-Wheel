using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spin_The_Wheel
{
    public partial class Main : Form
    {
        static string livePath = Environment.CurrentDirectory;

        static Image[] images = new Image[8];
        static int i = 0;
        static bool isWheelSpinning = false;
        static Thread spinWheel = new Thread(SpinTheWheel);
        static PictureBox wh = new PictureBox(); //did this to be able to close the spinWheel thread anywher in code

        public Main()
        {
            InitializeComponent();
            wh = Wheel_PictureBox;
        }

        static void ChangeWheel_Image()
        {
            if (i + 1 >= images.Length)
                i = 0;
            else
                i++;

            images[i] = Image.FromFile(livePath + "\\resources\\Slot " + (i + 1) + " active.png");
            wh.Invoke(new Action(() => wh.BackgroundImage = images[i]));
        }

        static void SpinTheWheel()
        {
            Random rand = new Random();
            int cycle = 1;

            for (int y = 0; y < 3; y++)
            {
                //Fast spin speed
                int fastSpin = rand.Next((55 - ((cycle - 1) * 20)), (65 - ((cycle - 1) * 15)));
                for (int x = 0; x < fastSpin; x++)
                {
                    ChangeWheel_Image();
                    Thread.Sleep(40 * cycle);
                }
                cycle++;
            }

            isWheelSpinning = false;
            MessageBox.Show("Congrats!! You won prize " + (i + 1));
            spinWheel.Abort();
        }

        private void Spin_Button_Click(object sender, EventArgs e)
        {
            if (!isWheelSpinning)
            {
                Thread spinWheel = new Thread(SpinTheWheel);
                isWheelSpinning = true;
                spinWheel.Start();
            }
        }
    }
}