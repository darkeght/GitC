using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;

            startXPoss = new Random().Next(0, 1000);
            startLocationY = new Random().Next(0, 800);
            timer1.Interval = new Random().Next(10, 200);
            speedMultiple = new Random().Next(10, 100);

            switch (new Random().Next(0, 3))
            {
                case 0: { this.pictureBox1.Image = 
                            global::DataGridViewExample.Properties.Resources._7ChVWbF; }break;
                case 1:
                    {
                        this.pictureBox1.Image =
                      global::DataGridViewExample.Properties.Resources.Bom_Dia_pra_você_1;
                    }
                    break;
                case 2:
                    {
                        this.pictureBox1.Image =
                      global::DataGridViewExample.Properties.Resources.tumblr_56d2c67c64bee9fc69ed718079136ba4_ce3234c9_500;
                    }
                    break;
            }

            timer1.Start();
        }
        int startXPoss = 0;
        int startLocationY = 0;
        bool incrementX = true;
        bool incrementY= true;
        int speedMultiple = 5;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(startXPoss, startLocationY);
            ReturnY();
            ReturnX();
        }
        public void ReturnY()
        {
            if (incrementY)
            {
                startLocationY = startLocationY + speedMultiple;

                if ((startLocationY + 149) >= 800)
                {
                    incrementY = false;
                }
            }
            else
            {
                startLocationY = startLocationY - speedMultiple;

                if (startLocationY <= 0)
                {
                    incrementY = true;
                }
            }
        }

        public void ReturnX()
        {
            if (incrementX)
            {
                startXPoss = startXPoss + speedMultiple;

                if ((startXPoss + 223) >= 1380)
                {
                    incrementX = false;
                }
            }
            else
            {
                startXPoss = startXPoss - speedMultiple;

                if (startXPoss <= 0)
                {
                    incrementX = true;
                }
            }
        }

    }
}
