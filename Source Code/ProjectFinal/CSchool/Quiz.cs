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
    public partial class Quiz : UserControl
    {
        int m = 2;  //SET 2 MINUTE
        int s = 0;
        int marks = 0;  //MARKS COUNTER
        DataAccess da = new DataAccess();

        public Quiz()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //QUIZ TIMER
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if(m == 00 && s == 00)
            {
                timer1.Stop();
                MessageBox.Show("Time's Up !!!");
                Panel2.Enabled = false;
                CheckAnswer();
            }

            min.Text = "0" + m.ToString();
            sec.Text = s.ToString();
            if(s <10)
            {
                sec.Text = "0" + s.ToString();
            }


        }


        //SET ALL QUESTION WHEN QUIZ START
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Panel2.Visible = true;
            DataTable dt = new DataTable();
            dt = da.GetAllQUESTION();
            textBox5.Text = "1. " + dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            textBox4.Text = dt.Rows[0][3].ToString();
            textBox6.Text = dt.Rows[0][4].ToString();
            textBox1.Text = dt.Rows[0][5].ToString();

            textBox11.Text = "2. " + dt.Rows[1][1].ToString();
            textBox15.Text = dt.Rows[1][2].ToString();
            textBox14.Text = dt.Rows[1][3].ToString();
            textBox13.Text = dt.Rows[1][4].ToString();
            textBox12.Text = dt.Rows[1][5].ToString();

            textBox3.Text = "3. " + dt.Rows[2][1].ToString();
            textBox10.Text = dt.Rows[2][2].ToString();
            textBox9.Text = dt.Rows[2][3].ToString();
            textBox8.Text = dt.Rows[2][4].ToString();
            textBox7.Text = dt.Rows[2][5].ToString();

            textBox16.Text = "4. " + dt.Rows[3][1].ToString();
            textBox20.Text = dt.Rows[3][2].ToString();
            textBox19.Text = dt.Rows[3][3].ToString();
            textBox18.Text = dt.Rows[3][4].ToString();
            textBox17.Text = dt.Rows[3][5].ToString();

            textBox21.Text = "5. " + dt.Rows[4][1].ToString();
            textBox25.Text = dt.Rows[4][2].ToString();
            textBox24.Text = dt.Rows[4][3].ToString();
            textBox23.Text = dt.Rows[4][4].ToString();
            textBox22.Text = dt.Rows[4][5].ToString();

            textBox26.Text = "6. " + dt.Rows[5][1].ToString();
            textBox30.Text = dt.Rows[5][2].ToString();
            textBox29.Text = dt.Rows[5][3].ToString();
            textBox28.Text = dt.Rows[5][4].ToString();
            textBox27.Text = dt.Rows[5][5].ToString();

            textBox31.Text = "7. " + dt.Rows[6][1].ToString();
            textBox35.Text = dt.Rows[6][2].ToString();
            textBox34.Text = dt.Rows[6][3].ToString();
            textBox33.Text = dt.Rows[6][4].ToString();
            textBox32.Text = dt.Rows[6][5].ToString();

            textBox36.Text = "8. " + dt.Rows[7][1].ToString();
            textBox40.Text = dt.Rows[7][2].ToString();
            textBox39.Text = dt.Rows[7][3].ToString();
            textBox38.Text = dt.Rows[7][4].ToString();
            textBox37.Text = dt.Rows[7][5].ToString();

            textBox41.Text = "9. " + dt.Rows[8][1].ToString();
            textBox45.Text = dt.Rows[8][2].ToString();
            textBox44.Text = dt.Rows[8][3].ToString();
            textBox43.Text = dt.Rows[8][4].ToString();
            textBox42.Text = dt.Rows[8][5].ToString();

            textBox46.Text = "10. " + dt.Rows[9][1].ToString();
            textBox50.Text = dt.Rows[9][2].ToString();
            textBox49.Text = dt.Rows[9][3].ToString();
            textBox48.Text = dt.Rows[9][4].ToString();
            textBox47.Text = dt.Rows[9][5].ToString();


        }

        //QUIZ SUBMIT BUTTON
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        
        //CHECKING ANSWER
        public int CheckAnswer()
        {
            timer1.Stop();
            Panel2.Enabled = false;

            DataTable dt = new DataTable();
            dt = da.GetAllQUESTION();

            string s1 = Answer1.Text;
            if (dt.Rows[0][6].ToString().Equals(s1, StringComparison.InvariantCultureIgnoreCase))
            {
                marks = marks + 1;
            }
            string s2 = Answer2.Text;
            if (dt.Rows[1][6].ToString().Equals(s2, StringComparison.InvariantCultureIgnoreCase))
            {
                marks = marks + 1;
            }
            string s3 = Answer3.Text;
            if (dt.Rows[2][6].ToString().Equals(s3, StringComparison.InvariantCultureIgnoreCase))
            {
                marks = marks + 1;
            }
            string s4 = Answer4.Text;
            if (dt.Rows[3][6].ToString().Equals(s4, StringComparison.InvariantCultureIgnoreCase))
            {
                marks = marks + 1;
            }
            string s5 = Answer5.Text;
            if (dt.Rows[4][6].ToString().Equals(s5, StringComparison.InvariantCultureIgnoreCase))
            {
                marks = marks + 1;
            }
            string s6 = Answer6.Text;
            if (dt.Rows[5][6].ToString().Equals(s6, StringComparison.InvariantCultureIgnoreCase))
            {
                marks = marks + 1;
            }
            string s7 = Answer7.Text;
            if (dt.Rows[6][6].ToString().Equals(s7, StringComparison.InvariantCultureIgnoreCase))
            {
                marks = marks + 1;
            }
            string s8 = Answer8.Text;
            if (dt.Rows[7][6].ToString().Equals(s8, StringComparison.InvariantCultureIgnoreCase))
            {
                marks = marks + 1;
            }
            string s9 = Answer9.Text;
            if (dt.Rows[8][6].ToString().Equals(s9, StringComparison.InvariantCultureIgnoreCase))
            {
                marks = marks + 1;
            }
            string s10 = Answer10.Text;
            if (dt.Rows[9][6].ToString().Equals(s10, StringComparison.InvariantCultureIgnoreCase))
            {
                marks = marks + 1;
            }

            MessageBox.Show("Your marks : " + marks.ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return marks;
        }
    }
}
