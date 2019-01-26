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
    public partial class User : UserControl
    {
        DataAccess da = new DataAccess();
        public User()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt = da.LogConfirmStudent("a", "a");

            if (dt.Rows.Count > 0)
            {
                Label7.Text = dt.Rows[0][3].ToString();
                Label8.Text = dt.Rows[0][0].ToString();
                Label9.Text = dt.Rows[0][1].ToString();
                Label10.Text = dt.Rows[0][4].ToString();
            }


        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

    }
}
