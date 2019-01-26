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
    public partial class Admin : UserControl
    {
        DataAccess da = new DataAccess();
        public Admin()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt = da.GetAllStudent();
            DataGrid1.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = da.GetAllQUESTION();
            DataGrid2.DataSource = dt2;

        }
        public void ClearText()
        {
            Textbox1.Text = Textbox2.Text = Question.text=Op1.text= Op2.text = Op3.text= Op4.text = Answer.text= uQuestionID.text= uQuestion.text = uOp1.text = uOp2.text = uOp3.text = uOp4.text = dQuestionID.text=string.Empty;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = da.SearchStudentById(int.Parse(Textbox1.Text));

        }

        //SET STUDENT SECTION
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (int.TryParse(Textbox2.Text, out check))
            {
                MessageBox.Show("Invalid\nEnter string type input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                da.SectionUpdate(Textbox2.Text, int.Parse(Textbox1.Text));
                DataGrid1.DataSource = da.SearchStudentById(int.Parse(Textbox1.Text));
                ClearText();

                DataTable dt = new DataTable();
                dt = da.GetAllStudent();
                DataGrid1.DataSource = dt;
            }

        }

        //INSERT QUESTION
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            da.InsertQuestion(Question.text,Op1.text,Op2.text,Op3.text,Op4.text,Answer.text);
            MessageBox.Show("Question Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ClearText();

            DataTable dt2 = new DataTable();
            dt2 = da.GetAllQUESTION();
            DataGrid2.DataSource = dt2;
        }

        //UPDATE QUESTION
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            da.QuestionUpdate(int.Parse(uQuestionID.text), uQuestion.text , uOp1.text , uOp2.text , uOp3.text , uOp4.text , uAnswer.text);
            MessageBox.Show("Question Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ClearText();

            DataTable dt2 = new DataTable();
            dt2 = da.GetAllQUESTION();
            DataGrid2.DataSource = dt2;
        }

        //DELETE QUESTION
        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            da.QuestionDelete(int.Parse(dQuestionID.text));
            MessageBox.Show("Question Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ClearText();

            DataTable dt2 = new DataTable();
            dt2 = da.GetAllQUESTION();
            DataGrid2.DataSource = dt2;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();

        }
    }
}
