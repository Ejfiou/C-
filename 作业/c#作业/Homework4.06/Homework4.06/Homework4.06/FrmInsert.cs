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
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }

        //string strCon = @"server=.\SQL2014;database=MySchool;uid=sa;password=123";
        private DBHelper helper = new DBHelper();

        private void btnInsert_Click(object sender, EventArgs e)
        {
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
            string loginPwd = txtLoginPwd.Text.Trim();
            if (this.txtLoginPwd.Text == "")
            {
                this.errorProvider1.SetError(txtLoginPwd, "不能为空");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }
            string stuNo = txtStuNo.Text.Trim();
            if (this.txtStuNo.Text == "")
            {
                this.errorProvider1.SetError(txtStuNo, "不能为空");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }
            string sex = rdoMale.Checked ? rdoMale.Text : rdoFamel.Text;
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
            string classChoice = null;

            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();

            //    string strSQL = "sp_selectClassGuid";
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    if (cboClass.Text.Length > 0)
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
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

            //    string strSQL = "sp_studentInsert";
            //    //(@StudentGuid,@LoginId,@LoginPwd,@UserStateId,@StudentNo,@StudentName,@Sex,@Address,@ClassGuid)
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@StudentGuid", Guid.NewGuid());
            //    cmd.Parameters.AddWithValue("@LoginId", loginId);
            //    cmd.Parameters.AddWithValue("@LoginPwd", loginPwd);
            //    cmd.Parameters.AddWithValue("@UserStateId", 1);
            //    cmd.Parameters.AddWithValue("@StudentNo", stuNo);
            //    cmd.Parameters.AddWithValue("@StudentName", name);
            //    cmd.Parameters.AddWithValue("@Sex", sex);
            //    cmd.Parameters.AddWithValue("@Address", address);
            //    cmd.Parameters.AddWithValue("@ClassGuid", classChoice);

            //    int a = cmd.ExecuteNonQuery();

            //    if (a > 0)
            //    {
            //        MessageBox.Show("增加成功");
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("增加失败");
            //    }
            //    con.Close();
            //}
            strSQL = "sp_studentInsert";
            int a = helper.ExecuteNonQuery(strSQL, CommandType.StoredProcedure,
                new SqlParameter("@StudentGuid", Guid.NewGuid()),
                new SqlParameter("@LoginId", loginId),
                new SqlParameter("@LoginPwd", loginPwd),
                new SqlParameter("@UserStateId", 1),
                new SqlParameter("@StudentNo", stuNo),
                new SqlParameter("@StudentName", name),
                new SqlParameter("@Sex", sex),
                new SqlParameter("@Address", address),
                new SqlParameter("@ClassGuid", classChoice)
                );
            if (a > 0)
            {
                MessageBox.Show("增加成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("增加失败");
            }
        }

        private void FrmInsert_Load(object sender, EventArgs e)
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
        }
    }
}
