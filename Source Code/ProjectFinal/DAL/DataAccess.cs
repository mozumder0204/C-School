using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataAccess
    {
        SqlConnection con;
        DataTable stu_Dt = new DataTable();
        DataTable ad_Dt = new DataTable();

        public DataAccess()
        {
            con = new SqlConnection(@"Data Source=BOSS\CSCHOOL;Initial Catalog=CSCHOOL;Persist Security Info=True;User ID=sa;Password=12345678");
            con.Open();
        }

        //REGISTRATION
        public void Registration(string u, string cp, string f, string m)
        {
            string s = "INSERT INTO  STUDENT VALUES(  '" + u + "' , '" + cp + "' , '" + f + "' , '" + m + "' , '-' )";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();
        }

        //STUDENT LOG IN
        public DataTable LogConfirmStudent(string uname, string pass)
        {

            SqlCommand stu_Str = new SqlCommand("SELECT * FROM STUDENT WHERE S_USER = '" + uname + "' AND S_PASS = '" + pass + "' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(stu_Str);
            sda.Fill(stu_Dt);
            con.Close();
            return stu_Dt;
        }

        //ADMIN LOG IN
        public DataTable LogConfirmAdmin(string uname, string pass)
        {

            SqlCommand ad_Str = new SqlCommand("SELECT * FROM ADMIN WHERE A_USER = '" + uname + "' AND A_PASS = '" + pass + "' ", con);
            SqlDataAdapter ada = new SqlDataAdapter(ad_Str);
            ada.Fill(ad_Dt);
            con.Close();
            return ad_Dt;
        }


        public DataTable GetAdminInfo()
        {
            return ad_Dt;
        }
        public DataTable GetStudentInfo()
        {
            return stu_Dt;
        }


        //GET ALL STUDENT INFORMATION
        public DataTable GetAllStudent()
        {
            SqlCommand str = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //SEARCH STUDENT BY STUDENT ID
        public DataTable SearchStudentById(int id)
        {
            SqlCommand str = new SqlCommand("SELECT * FROM STUDENT WHERE S_ID=" + id, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //SET SECTION FOR STUDENT
        public DataTable SectionUpdate(string s, int i)
        {
            SqlCommand str = new SqlCommand("UPDATE STUDENT SET S_SEC='" + s + "' where S_ID=" + i, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        //INSERT QUESTION
        public void InsertQuestion(string q, string op1, string op2, string op3, string op4, string a)
        {
            string s = "INSERT INTO  QUESTIONS VALUES(  '" + q + "' , '" + op1 + "' , '" + op2 + "' , '" + op3 + "' ,  '" + op4 + "' , '" + a + "')";
            SqlCommand str = new SqlCommand(s, con);
            con.Open();
            str.ExecuteNonQuery();
        }


        //GET ALL QUESTION
        public DataTable GetAllQUESTION()
        {
            SqlCommand str = new SqlCommand("Select * from QUESTIONS", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        //UPDATE QUESTION
        public DataTable QuestionUpdate(int i, string q, string op1, string op2, string op3, string op4, string a)
        {
            SqlCommand str = new SqlCommand("UPDATE QUESTIONS SET QUESTION='" + q + "' , OP1='" + op1 + "', OP2='" + op2 + "', OP3='" + op3 + "', OP4='" + op4 + "', ANSWER='" + a + "' where Q_ID=" + i, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        //DELETE QUESTION
        public void QuestionDelete(int i)
        {
            con.Open();
            SqlCommand str = new SqlCommand("Delete from QUESTIONS where Q_id=" + i, con);
            str.ExecuteNonQuery();
        }
    }
  
    }
