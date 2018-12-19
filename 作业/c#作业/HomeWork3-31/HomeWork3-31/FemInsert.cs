using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeWork3_31
{
    public partial class FemInsert : Form
    {
        public FemInsert()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private string strCon = @"server=.\SQL2014;database=MySchool;uid=sa;password=123;";
        private void button1_Click(object sender, EventArgs e)
        {
            string studentGUID = Guid.NewGuid().ToString();
            string loginId = this.textBox1.Text;
            string loginPwd = this.textBox2.Text;
            int userStateId = 1;
            string stuNo = this.textBox3.Text;
            string studentName = this.textBox4.Text;
            string sex = this.radioButton1.Checked ? this.radioButton1.Text : this.radioButton2.Text;
            string address = this.textBox6.Text;
            string className = this.comboBox1.Text;
            string classGUID = null;
            string strSQL = "select ClassGUID from Class where ClassName=@className";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@className", className);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //string GradeName = reader[0].ToString();
                    //string GradeName = Convert.ToString(reader["GradeName"]);
                    classGUID = reader.GetString(reader.GetOrdinal("ClassGUID"));

                }

                reader.Close();

                con.Close();
            }
            strSQL = "insert into Student(StudentGUID,LoginId,LoginPwd,UserStateId,ClassGuid,StudentNO,StudentName,Sex,Address) values(@StudentGUID,@LoginId,@LoginPwd,@UserStateId,@ClassGuid,@StudentNO,@StudentName,@Sex,@Address)";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@StudentGUID", studentGUID);
                cmd.Parameters.AddWithValue("@LoginId", loginId);
                cmd.Parameters.AddWithValue("@LoginPwd", loginId);
                cmd.Parameters.AddWithValue("@UserStateId", userStateId);
                cmd.Parameters.AddWithValue("@StudentName", studentName);
                cmd.Parameters.AddWithValue("@Sex", sex);
                cmd.Parameters.AddWithValue("@StudentNO", stuNo);
                cmd.Parameters.AddWithValue("@ClassGuid", classGUID);
                cmd.Parameters.AddWithValue("@Address", address);
                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("插入成功！");
                }
                else
                {
                    MessageBox.Show("插入失败！");
                }
                con.Close();
            }
        }

        private void FemInsert_Load(object sender, EventArgs e)
        {
            string strSQL = "select ClassName from Class";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //string GradeName = reader[0].ToString();
                    //string GradeName = Convert.ToString(reader["GradeName"]);
                    string className = reader.GetString(reader.GetOrdinal("ClassName"));
                    this.comboBox1.Items.Add(className);
                }

                reader.Close();

                con.Close();
            }
        }
    }
}
