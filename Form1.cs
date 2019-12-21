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
        string livePath = Environment.CurrentDirectory;
        
        Image[] images = new Image [8];
        public int i = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void ChangeWheel_Image()
        {
            string resourcePath = livePath + "\\resources\\";
            
            images[0] = Image.FromFile(resourcePath + "Slot 1 active.png");
            images[1] = Image.FromFile(resourcePath + "Slot 2 active.png");
            images[2] = Image.FromFile(resourcePath + "Slot 3 active.png");
            images[3] = Image.FromFile(resourcePath + "Slot 4 active.png");
            images[4] = Image.FromFile(resourcePath + "Slot 5 active.png");
            images[5] = Image.FromFile(resourcePath + "Slot 6 active.png");
            images[6] = Image.FromFile(resourcePath + "Slot 7 active.png");
            images[7] = Image.FromFile(resourcePath + "Slot 8 active.png");

            if (i + 1 > images.Length)
                i = 0;

            Wheel_PictureBox.Invoke(new Action(() => Wheel_PictureBox.BackgroundImage = images[i]));
            i++;
        }

        private void SpinTheWheel()
        {
            Random rand = new Random();
            int fastSpin = rand.Next(45, 60);
            int medSpin = rand.Next(14, 24);
            int slowSpin = rand.Next(15, 23);

            //Fast spin speed
            for (int x = 0; x < fastSpin; x++)
            {
                ChangeWheel_Image();
                GameTick(10);
            }

            //Meduim spin speed
            for (int x = 0; x < medSpin; x++)
            {
                ChangeWheel_Image();
                GameTick(40);
            }
            
            //Slow spin speed
            for (int x = 0; x < slowSpin; x++)
            {
                ChangeWheel_Image();
                GameTick(100);
            }

            MessageBox.Show("Congrats!! You won prize " + GivePrize());
        }

        private void Spin_Button_Click(object sender, EventArgs e)
        {
            Thread spinWheel = new Thread(SpinTheWheel);
            spinWheel.Start();
        }

        private int GivePrize()
        {
            int prizeNum = i;
            return prizeNum;
        }

        private void GameTick(int tickSpeed)
        {
            Thread.Sleep(tickSpeed);
        }
    }
}
