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
    public partial class FrmSelect : Form
    {
        public FrmSelect()
        {
            InitializeComponent();
        }

        private string strCon = @"server=.\SQL2014;database=MySchool;uid=sa;password=123;";
        private void FrmSelect_Load(object sender, EventArgs e)
        {
            string strSQL = "select StudentNO from Student";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //string GradeName = reader[0].ToString();
                    //string GradeName = Convert.ToString(reader["GradeName"]);
                    string studentNO = reader.GetString(reader.GetOrdinal("StudentNO"));
                    this.comboBox1.Items.Add(studentNO);
                }

                reader.Close();

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSQL = "Select StudentName from Student  where StudentNO=@StudentNO";
            string stuName="";
            string sex = "";
            string address = "";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@StudentNO", this.comboBox1.Text);
                con.Open();

               object obj = cmd.ExecuteScalar();
                stuName = obj.ToString();
               
                con.Close();
            }
            strSQL = "Select Sex from Student  where StudentNO=@StudentNO";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@StudentNO", this.comboBox1.Text);
                con.Open();

                object obj = cmd.ExecuteScalar();
                sex = obj.ToString();

                con.Close();
            }
            strSQL = "Select Address from Student  where StudentNO=@StudentNO";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@StudentNO", this.comboBox1.Text);
                con.Open();

                object obj = cmd.ExecuteScalar();
                address = obj.ToString();

                con.Close();
            }
            MessageBox.Show($"姓名:{stuName}  学号：{this .comboBox1.Text}  性别：{sex}  地址：{address}","查询结果");
        }
    }
}
