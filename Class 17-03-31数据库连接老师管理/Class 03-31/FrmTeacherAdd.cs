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
namespace Class_03_31
{
    public partial class FrmTeacherAdd : Form
    {
        public FrmTeacherAdd()
        {
            InitializeComponent();
        }

        //private string strCon = @"server=DEEP-20161031OJ;database=MySchool;uid=sa;password=123";

        private DBHelper helper = new DBHelper();

        private void btnSave_Click(object sender, EventArgs e)
        {
            string teacherGUID = Guid.NewGuid().ToString();
            //MessageBox.Show(teacherGUID);
            string logInId = this.txtUserName.Text.Trim();
            string loginPwd = "12345";
            int userStateId = this.cboState.SelectedIndex;
            string teacherName = this.txtTeachName.Text.Trim();
            string sex = this.rdoMale.Checked ? this.rdoMale.Text : this.rdoFemale.Text;
            DateTime birthday = this.dtpBirthday.Value;
            string subjectName = this.cboState.Text;


            //string strSQL = "Select SubjectGuid from Subject where SubjectName=@subjectName";

            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@subjectName", subjectName);

            //    con.Open();

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        SubjectGuid = reader.GetString(reader.GetOrdinal("SubjectGuid"));
            //    }

            //    reader.Close();

            //    con.Close();
            //}

            //string strSQL = "insert into Teacher(TeacherGUID,LoginID,LogInPwd,UserStateID,TeacherName,sex,birthday,subjectGuid) values(@TeacherGUID,@LoginID,@LogInPwd,@UserStateID,@TeacherName,@sex,@birthday,(Select SubjectGuid from Subject where SubjectName=@subjectName))";

            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@TeacherGUID", teacherGUID);
            //    cmd.Parameters.AddWithValue("@LoginID", logInId);
            //    cmd.Parameters.AddWithValue("@LogInPwd", loginPwd);
            //    cmd.Parameters.AddWithValue("@UserStateID", userStateId);
            //    cmd.Parameters.AddWithValue("@TeacherName", teacherName);
            //    cmd.Parameters.AddWithValue("@sex", sex);
            //    cmd.Parameters.AddWithValue("@birthday", birthday);
            //    cmd.Parameters.AddWithValue("@subjectName", subjectName);

            //    con.Open();

            //    int rows = cmd.ExecuteNonQuery();

            //    con.Close();

            //    if (rows>0)
            //    {
            //        MessageBox.Show("操作成功！");
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("操作失败！");
            //    }
            //}

            string strSQL = "insert into Teacher(TeacherGUID,LoginID,LogInPwd,UserStateID,TeacherName,sex,birthday,subjectGuid) values(@TeacherGUID,@LoginID,@LogInPwd,@UserStateID,@TeacherName,@sex,@birthday,(Select SubjectGuid from Subject where SubjectName=@subjectName))";

            int rows = helper.ExecuteNonQuery(strSQL,
                CommandType.Text,
                new SqlParameter("@TeacherGUID", teacherGUID),
                new SqlParameter("@LoginID", logInId),
                new SqlParameter("@LogInPwd", loginPwd),
                new SqlParameter("@UserStateID", userStateId),
                new SqlParameter("@TeacherName", teacherName),
                new SqlParameter("@sex", sex),
                new SqlParameter("@birthday", birthday),

                new SqlParameter("@subjectName", subjectName)
                );

            if (rows > 0)
            {
                MessageBox.Show("操作成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }
    

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            this.cboState.SelectedIndex = 1;

            string strSQL = "Select SubjectName from Subject";

            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    con.Open();

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        string subjectName = reader.GetString(reader.GetOrdinal("subjectName"));

            //        this.cboSubject.Items.Add(subjectName);
            //    }

            //    reader.Close();

            //    con.Close();
            //}

            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                string subjectName = reader.GetString(reader.GetOrdinal("subjectName"));

                this.cboSubject.Items.Add(subjectName);
            }

            reader.Close();
        }
    }
}
