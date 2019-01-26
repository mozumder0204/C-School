using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSchool
{
    public partial class IfStatement : UserControl
    {
        int s = 1;
       
        public IfStatement()
        {
            InitializeComponent(); 
        }


        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.Visible = true;
            GPanel.Visible = true;
            label6.Visible = true;

            GPanel.Location = new Point(GPanel.Location.X+ s , GPanel.Location.Y);

            if(GPanel.Location.X == 440)
            {
                timer1.Stop();
                GPanel.Location = new Point(GPanel.Location.X - 430, GPanel.Location.Y + 30);
               

                timer1.Start();
                GPanel.Location = new Point(GPanel.Location.X + s, GPanel.Location.Y);
                pictureBox1.Location = new Point(pictureBox1.Location.X , pictureBox1.Location.Y+30);

                if (GPanel.Location.Y == 140)
                {
                    GPanel.Location = new Point(40,50);
                    pictureBox1.Location = new Point(10,50);
                    label7.Visible = false;
                    label6.Visible = true;

                }

            }
            if(pictureBox1.Location.Y != 50)
            {
                label6.Visible = false;
            }
            if(pictureBox1.Location.Y == 110)
            {
                label7.Visible = true;
            }


        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            s = 1;
            GPanel.Location = new Point(40, 50);
            pictureBox1.Location = new Point(10, 50);

        }

        private void speed2_Click(object sender, EventArgs e)
        {
            s = 2;
            GPanel.Location = new Point(40, 50);
            pictureBox1.Location = new Point(10, 50);
        }

        private void speed5_Click(object sender, EventArgs e)
        {
             s = 5;
            GPanel.Location = new Point(40, 50);
            pictureBox1.Location = new Point(10, 50);
        }

        private void speed10_Click(object sender, EventArgs e)
        {
            s = 10;
            GPanel.Location = new Point(40, 50);
            pictureBox1.Location = new Point(10, 50);
        }
    }
    }


