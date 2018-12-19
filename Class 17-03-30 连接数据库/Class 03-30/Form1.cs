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

namespace Class_03_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //连接字符串
            string strCon = @"server=DEEP-20161031OJ;database=MySchool;uid=sa;password=123;";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            con.Open();
            MessageBox.Show("打开数据库连接成功");
            con.Close();
            MessageBox.Show("关闭数据库连接成功");

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //连接字符串
            string strCon = @"server=DEEP-20161031OJ;database=MySchool;uid=sa;password=123;";
            string strSQL = "select count(*) from Student";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = strSQL;

            con.Open();
            object obj = cmd.ExecuteScalar();            

            con.Close();

            int count = (int)obj;
            MessageBox.Show($"Student表中共有{count}条学生信息！");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = false;



            string strCon = @"server=DEEP-20161031OJ;database=MySchool;uid=sa;password=123;";

            //会产生危险。“SQL Injection”中文“SQL注入”
            //string strSQL = $"select count(*) from admin where loginId= '{txtLogName.Text}' and loginPwd ='{txtPwd.Text}'";

            string strSQL = $"select loginpwd from admin where loginId= '{txtLogName.Text}'";

            ////连接数据库
            ////SqlConnection con = new SqlConnection();
            ////con.ConnectionString = strCon;
            //SqlConnection con = new SqlConnection(strCon);


            ////SqlCommand cmd = new SqlCommand();
            ////cmd.Connection = con;
            ////cmd.CommandText = strSQL;
            //SqlCommand cmd = new SqlCommand(strSQL, con);

            //con.Open();
            //Object obj = cmd.ExecuteScalar();

            //con.Close();

            //可以这样写
            object obj = null;
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                obj = cmd.ExecuteScalar();
                con.Close();
            }


            if (obj != null)
            {
                string count = obj.ToString();
                if (count == txtPwd.Text)
                {
                    isValid = true;
                }
            }
            
            //验证用户名和密码是否正确

  

            if (isValid)
            {
                FrmMain f = new FrmMain();
                f.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }

        }
    }
}
