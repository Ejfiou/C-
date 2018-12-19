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
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }
        public FrmUpdate(string guid)
        {
            this.guid = guid;
            InitializeComponent();
        }
        private string guid = null;
        //string strCon = @"server=.\SQL2014;database=MySchool;uid=sa;password=123";
        private DBHelper helper = new DBHelper();

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();
            //    string strSql = "sp_selectClassName";

            //    SqlCommand cmd = new SqlCommand(strSql, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        object obj = reader.GetString(reader.GetOrdinal("ClassName"));
            //        cboClass.Items.Add(obj);
            //    }
            //    reader.Close();
            //    con.Close();
            //}
            string strSql = "sp_selectClassName";

            using (IDataReader reader = helper.ExecuteReader(strSql,CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    object obj = reader.GetString(reader.GetOrdinal("ClassName"));
                    cboClass.Items.Add(obj);
                }
                reader.Close();
            }

            string str = "sp_selectByStuGuid";

            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand(str, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@StudentGuid", guid);

            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        txtStuID.Text = reader.GetString(reader.GetOrdinal("StudentNO"));
            //        txtLoginID.Text = reader.GetString(reader.GetOrdinal("LoginId"));
            //        int userStateId = reader.GetInt32(reader.GetOrdinal("UserStateId"));
            //        cboStates.Text = userStateId == 1 ? "在线" : "离线";
            //        cboClass.Text = reader.GetString(reader.GetOrdinal("ClassName"));
            //        txtName.Text = reader.GetString(reader.GetOrdinal("StudentName"));
            //        txtAddress.Text = reader.GetString(reader.GetOrdinal("Address"));
            //        this.rdoMale.Checked = (reader.GetString(reader.GetOrdinal("Sex")) == rdoMale.Text);
            //        this.rdoFamel.Checked = (reader.GetString(reader.GetOrdinal("Sex"))) == rdoFamel.Text;
            //    }
            //    reader.Close();

            //    con.Close();
            //}

            using (IDataReader reader = helper.ExecuteReader(str,CommandType.StoredProcedure,new SqlParameter("@StudentGuid", guid)))
            {
                while (reader.Read())
                {
                    txtStuID.Text = reader.GetString(reader.GetOrdinal("StudentNO"));
                    txtLoginID.Text = reader.GetString(reader.GetOrdinal("LoginId"));
                    int userStateId = reader.GetInt32(reader.GetOrdinal("UserStateId"));
                    cboStates.Text = userStateId == 1 ? "在线" : "离线";
                    cboClass.Text = reader.GetString(reader.GetOrdinal("ClassName"));
                    txtName.Text = reader.GetString(reader.GetOrdinal("StudentName"));
                    txtAddress.Text = reader.GetString(reader.GetOrdinal("Address"));
                    this.rdoMale.Checked = (reader.GetString(reader.GetOrdinal("Sex")) == rdoMale.Text);
                    this.rdoFamel.Checked = (reader.GetString(reader.GetOrdinal("Sex"))) == rdoFamel.Text;
                }
                reader.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string stuNo = txtStuID.Text;
            if (this.txtStuID.Text == "")
            {
                this.errorProvider1.SetError(txtStuID, "请输入学生学号");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }
            //登录账号
            string loginId = txtLoginID.Text.Trim();
            if (this.txtLoginID.Text == "")
            {
                this.errorProvider1.SetError(txtLoginID, "不能为空");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }
            //状态
            string userStates = cboStates.Text == "在线" ? "1" : "0";
            if (this.cboStates.Text == "")
            {
                this.errorProvider1.SetError(cboStates, "不能为空");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }
            //性别
            string sex = rdoMale.Checked ? rdoMale.Text : rdoFamel.Text;
            //姓名
            string name = txtName.Text.Trim();
            if (this.txtName.Text == "")
            {
                this.errorProvider1.SetError(txtName, "不能为空");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }
            //地址
            string address = txtAddress.Text.Trim();
            if (this.txtAddress.Text == "")
            {
                this.errorProvider1.SetError(txtAddress, "不能为空");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }
            //班级
            string classChoice = null;
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();

            //    string strSQL = "sp_selectClassGuid";
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    if (cboClass.Text.Length > 0)
            //    {
            //        string className = cboClass.Text;
            //        cmd.Parameters.AddWithValue("@className", className);
            //        classChoice = cmd.ExecuteScalar().ToString();
            //    }
            //    else
            //    {
            //        errorProvider1.SetError(cboClass, "请选择班级");
            //        return;
            //    }

            //    con.Close();
            //}

            string strSQL = "sp_selectClassGuid";
            if (cboClass.Text.Length > 0)
            {
                classChoice = helper.ExecuteScalar(strSQL, CommandType.StoredProcedure, new SqlParameter("@className", cboClass.Text)).ToString();
            }
            else
            {
                errorProvider1.SetError(cboClass, "请选择班级");
                return;
            }


            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();

            //    string strSQL = "sp_Update";
            //    //(@StudentGuid,@LoginId,@LoginPwd,@UserStateId,@StudentNo,@StudentName,@Sex,@Address,@ClassGuid)
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@LoginId", loginId);
            //    cmd.Parameters.AddWithValue("@UserStateId", int.Parse(userStates));
            //    cmd.Parameters.AddWithValue("@StudentNo", stuNo);
            //    cmd.Parameters.AddWithValue("@StudentName", name);
            //    cmd.Parameters.AddWithValue("@Sex", sex);
            //    cmd.Parameters.AddWithValue("@Address", address);
            //    cmd.Parameters.AddWithValue("@ClassGuid", classChoice);
            //    cmd.Parameters.AddWithValue("@StudentGuid", guid);

            //    int a = cmd.ExecuteNonQuery();

            //    if (a > 0)
            //    {
            //        MessageBox.Show("修改成功");
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("修改失败");
            //    }
            //    con.Close();
            //}
             strSQL = "sp_Update";
            int a = helper.ExecuteNonQuery(strSQL, CommandType.StoredProcedure,
                new SqlParameter("@LoginId", loginId),
                new SqlParameter("@UserStateId", int.Parse(userStates)),
                new SqlParameter("@StudentNo", stuNo),
                new SqlParameter("@StudentName", name),
                new SqlParameter("@Sex", sex),
                new SqlParameter("@Address", address),
                new SqlParameter("@ClassGuid", classChoice),
                new SqlParameter("@StudentGuid", guid)
                );
            if (a > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
