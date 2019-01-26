using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace CSchool
{
    public partial class Register : Form
    {
        DataAccess dt = new DataAccess();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Ubox_MouseClick(object sender, MouseEventArgs e)
        {
            Ubox.text = " ";
        }

        private void Fbox_MouseClick(object sender, MouseEventArgs e)
        {
            Fbox.text = " ";
        }

        private void Ebox_MouseClick(object sender, MouseEventArgs e)
        {
            Ebox.text = " ";
        }

        private void Pbox_MouseClick(object sender, MouseEventArgs e)
        {
            Pbox.text = " ";
        }

        private void CPbox_MouseClick(object sender, MouseEventArgs e)
        {
            CPbox.text = " ";
        }


      















        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(Ubox.text == string.Empty || Fbox.text == string.Empty || Ebox.text == string.Empty || Pbox.text == string.Empty || CPbox.text == string.Empty)
            
            {
                MessageBox.Show("Please insert all information");
            }
            else if(Pbox.text != CPbox.text)
            {
                MessageBox.Show("Those password didn't match\nTry Again.");
            }

            else
            {
                string u = Ubox.text;
                string f = Fbox.text;
                string m = Ebox.text;
                string p = Pbox.text;
                string cp = CPbox.text;

                dt.Registration(u, cp, f, m);

                MessageBox.Show("Registration Successful");
            }

        }
    }
}
