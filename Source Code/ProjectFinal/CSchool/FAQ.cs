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
    public partial class FAQ : UserControl
    {
        bool p1 = false;
        bool p2 = false;
        bool p3 = false;
        bool p4 = false;
        bool p5 = false;
        public FAQ()
        {
            InitializeComponent();
        }

        private void FAQ_Load(object sender, EventArgs e)
        {
            panel1.Height = 0;
            panel2.Height = 0;
            panel3.Height = 0;
            panel4.Height = 0;
            panel5.Height = 0;

            label4.Top = panel1.Top + 10;
            label6.Top = panel1.Top + 50;
            label8.Top = panel1.Top + 90;
            label10.Top = panel1.Top + 130;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!p1)
            {
                panel2.Height = 0;
                panel3.Height = 0;
                panel4.Height = 0;
                panel5.Height = 0;

                panel1.Height = 220;

                label4.Top = panel1.Bottom + 10;
                label6.Top = panel1.Bottom + 50;
                label8.Top = panel1.Bottom + 90;
                label10.Top = panel1.Bottom + 130;


            }
            else
            {
                panel1.Height = 0;

                label4.Top = panel1.Top + 10;
                label6.Top = panel1.Top + 50;
                label8.Top = panel1.Top + 90;
                label10.Top = panel1.Top + 130;

            }
            p1 = !p1;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (!p2)
            {
                panel1.Height = 0;
                panel3.Height = 0;
                panel4.Height = 0;
                panel5.Height = 0;

                panel2.Height = 260;

                label4.Top = label1.Top + 35;
                panel2.Top = label4.Bottom + 15;


                label6.Top = panel2.Bottom + 10;
                label8.Top = panel2.Bottom + 50;
                label10.Top = panel2.Bottom + 90;
            }
            else
            {
                panel2.Height = 0;

                label6.Top = label4.Top + 40;
                label8.Top = label4.Top + 90;
                label10.Top = label4.Top + 130;



            }
            p2 = !p2;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (!p3)
            {
                panel1.Height = 0;
                panel2.Height = 0;
                panel4.Height = 0;
                panel5.Height = 0;


                panel3.Height = 260;
                label6.Top = label4.Top + 35;
                panel3.Top = label6.Bottom + 15;


                label8.Top = panel3.Bottom + 10;
                label10.Top = panel3.Bottom + 50;
            }
            else
            {
                panel3.Height = 0;

                label8.Top = panel1.Top + 90;
                label10.Top = panel1.Top + 130;
            }
            p3 = !p3;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (!p4)
            {
                panel1.Height = 0;
                panel2.Height = 0;
                panel3.Height = 0;
                panel5.Height = 0;

                panel4.Height = 260;
                label8.Top = label6.Top + 35;
                panel4.Top = label6.Bottom + 40;

                label10.Top = panel4.Bottom + 20;
            }
            else
            {
                panel4.Height = 0;


                label10.Top = panel1.Top + 120;
            }
            p4 = !p4;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (!p5)
            {
                panel1.Height = 0;
                panel2.Height = 0;
                panel3.Height = 0;
                panel4.Height = 0;

                panel5.Height = 260;

                label4.Top = label1.Top + 35;
                label6.Top = label4.Top + 35;
                label8.Top = label6.Top + 35;
                label10.Top = label8.Top + 35;
                panel5.Top = label10.Bottom + 15;

            }
            else
            {
                panel5.Height = 0;


            }
            p5 = !p5;
        }
    }
}
