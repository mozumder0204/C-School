using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logIn1.Visible = true;
            tutorials1.Visible = false;
            faq1.Visible = false;
            quiz1.Visible = false;
            credit1.Visible = false;

        }

        private void btnMnu_Click(object sender, EventArgs e)
        {
            if (sidemenu.Height == 610 && sidemenu.Width == 220)
            {
                sidemenu.Height = 610;
                sidemenu.Width = 50;
                btnMnu.Location = new Point(12, 19);
                logIn1.Location = new Point(50,40);
                logIn1.Width = 900;
                tutorials1.Location = new Point(50, 40);
                tutorials1.Width = 900;
                faq1.Location = new Point(50, 40);
                faq1.Width = 900;
                quiz1.Location = new Point(50, 40);
                quiz1.Width = 900;
                credit1.Location = new Point(50, 40);
                credit1.Width = 900;
                logo.Hide();
                PanelAnimator1.ShowSync(sidemenu);

            }
            else
            {
                sidemenu.Height = 610;
                sidemenu.Width = 220;
                btnMnu.Location = new Point(182, 19);
                logIn1.Location = new Point(217,40);
                logIn1.Width = 730;
                tutorials1.Location = new Point(217, 40);
                tutorials1.Width = 730;
                faq1.Location = new Point(217, 40);
                faq1.Width = 730;
                quiz1.Location = new Point(217, 40);
                quiz1.Width = 730;
                credit1.Location = new Point(217,40);
                credit1.Width = 730;
                PanelAnimator2.ShowSync(sidemenu);
                LogoAnimator.ShowSync(logo);
            }
        }

        //LOG IN BUTTON
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            logIn1.Visible = true;
            tutorials1.Visible = false;
            faq1.Visible = false;
            quiz1.Visible = false;
            credit1.Visible = false;
         
        }
        //TUTORIALS BUTTON
        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            logIn1.Visible = false;
            tutorials1.Visible = true;
            faq1.Visible = false;
            quiz1.Visible = false;
            credit1.Visible = false;



        }

        //FAQ BUTTON
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            logIn1.Visible = false;
            tutorials1.Visible = false;
            faq1.Visible = true;
            quiz1.Visible = false;
            credit1.Visible = false;

        }

        //QUIZ BUTTON
        public void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            logIn1.Visible = false;
            tutorials1.Visible = false;
            faq1.Visible = false;
            quiz1.Visible = true;
            credit1.Visible = false;
        }

        //CREDIT BUTTON
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            logIn1.Visible = false;
            tutorials1.Visible = false;
            faq1.Visible = false;
            quiz1.Visible = false;
            credit1.Visible = true;

        }


    }
}
