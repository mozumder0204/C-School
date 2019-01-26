using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace CSchool
{
    public partial class LogIn : UserControl
    {
        DataAccess da = new DataAccess();

        public LogIn()
        {
            InitializeComponent();
            user1.Visible = false;
            admin1.Visible = false;
        }

        //LOG IN BUTTON
        private void loginButton_Click(object sender, EventArgs e)
        {

            if (userTextBox.Text == "" || passTextBox.Text == "")
            {
                MessageBox.Show("Enter username or password correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DataTable dt = new DataTable();
            dt = da.LogConfirmStudent(userTextBox.Text, passTextBox.Text);

            DataTable dt2 = new DataTable();
            dt2 = da.LogConfirmAdmin(userTextBox.Text, passTextBox.Text);

            try
            {


                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][1].ToString() == userTextBox.Text && dt.Rows[0][2].ToString() == passTextBox.Text)
                    {
                        admin1.Visible = false;
                        user1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Enter username or password correctly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                if (dt2.Rows.Count > 0)
                {
                    if (dt2.Rows[0][1].ToString() == userTextBox.Text && dt2.Rows[0][2].ToString() == passTextBox.Text)
                    {
                        admin1.Visible = true;
                        user1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Enter username or password correctly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        //PASSWORD SHOW OR HIDE
        private void passHide_Click(object sender, EventArgs e)
        {
            if(passTextBox.isPassword==true)
            {
                passTextBox.isPassword = false;
            }
            else
            {
                passTextBox.isPassword = true;
            }
        }

        private void userTextBox_Click(object sender, EventArgs e)
        {
            this.userTextBox.Text = "";
        }

        private void passTextBox_Click(object sender, EventArgs e)
        {
            this.passTextBox.Text = "";
        }


        //REGISTRATION BUTTON
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }
    }
}
