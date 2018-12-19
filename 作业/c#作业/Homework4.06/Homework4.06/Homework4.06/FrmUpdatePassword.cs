using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4._06
{
    public partial class FrmUpdatePassword : Form
    {
        public FrmUpdatePassword()
        {
            InitializeComponent();
        }

        public FrmUpdatePassword(string guid)
        {
            this.guid = guid;
            InitializeComponent();
        }
        private string guid = null;
        //private string strCon = @"server=.\SQL2014;database=MySchool;uid=sa;password=123";
        private string loginPwd = null;

        private DBHelper helper = new DBHelper();
        private void FrmUpdatePassword_Load(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();
            //    string str = "sp_selectOldPwd";

            //    SqlCommand cmd = new SqlCommand(str, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@StudentGuid", guid);

            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        loginPwd = reader.GetString(reader.GetOrdinal("LoginPwd"));
            //    }
            //    reader.Close();

            //    con.Close();
            //}

            string str = "sp_selectOldPwd";
            using (IDataReader reader = helper.ExecuteReader(str,CommandType.StoredProcedure,new SqlParameter("@StudentGuid", guid)))
            {
                while (reader.Read())
                {
                    loginPwd = reader.GetString(reader.GetOrdinal("LoginPwd"));
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (textBox1.Text.Length == 0)
            {
                this.errorProvider1.SetError(textBox1, "不能为空");
                return;
            }
            if (textBox2.Text.Length == 0)
            {
                this.errorProvider1.SetError(textBox2, "不能为空");
                return;
            }
            if (textBox3.Text.Length == 0)
            {
                this.errorProvider1.SetError(textBox3, "不能为空");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("两次密码输入不一致");
                return;
            }
            if (textBox1.Text != loginPwd)
            {
                MessageBox.Show("旧密码输入错误");
                return;
            }

            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();

            //    string strSQL = "sp_updatePwd";
            //    //(@StudentGuid,@LoginId,@LoginPwd,@UserStateId,@StudentNo,@StudentName,@Sex,@Address,@ClassGuid)
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@StudentGuid", guid);
            //    cmd.Parameters.AddWithValue("@LoginPwd", textBox2.Text);

            //    int a = cmd.ExecuteNonQuery();

            //    if (a > 0)
            //    {
            //        MessageBox.Show("修改密码成功");
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("修改密码失败");
            //    }
            //    con.Close();
            //}

            string strSQL = "sp_updatePwd";
            int a = helper.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, new SqlParameter("@StudentGuid", guid),
                new SqlParameter("@LoginPwd", textBox2.Text));
            if (a > 0)
            {
                MessageBox.Show("修改密码成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改密码失败");
            }
        }
    }
}
