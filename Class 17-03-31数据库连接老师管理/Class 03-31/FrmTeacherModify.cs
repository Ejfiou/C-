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
    public partial class FrmTeacherModify : Form
    {
        public FrmTeacherModify()
        {
            InitializeComponent();
        }

        public FrmTeacherModify(string guid)
        {
            this.guid = guid;
            InitializeComponent();

        }

        private string strCon = @"server=DEEP-20161031OJ;database=MySchool;uid=sa;password=123";

        private string guid = null;
        private void FrmTeacherModify_Load(object sender, EventArgs e)
        {
           
            string strSQL = "Select SubjectName from Subject";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string subjectName = reader.GetString(reader.GetOrdinal("subjectName"));

                    this.cboSubject.Items.Add(subjectName);
                }

                reader.Close();

                con.Close();
            }
            
            if (!string.IsNullOrWhiteSpace(guid))
            {
                
                strSQL = "SELECT [LoginId],[UserStateid],[TeacherName],[Sex],[Birthday],[SubjectName]FROM [dbo].[Teacher]" +
                         "Left join[subject] on[Teacher].[SubjectGUID] =[Subject].[SubjectGUID]" +
                         "where teacherguid=@TeacherGuid";
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@TeacherGuid", guid);
                    
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int userStateId = reader.GetInt32(reader.GetOrdinal("UserStateId"));
                        string loginId = reader.GetString(reader.GetOrdinal("LoginId"));
                        string teacherName = reader.GetString(reader.GetOrdinal("TeacherName"));
                        string sex = reader.IsDBNull(reader.GetOrdinal("Sex")) ? null : (reader.GetString(reader.GetOrdinal("Sex")));
                        Nullable<DateTime> birthday = reader.IsDBNull(reader.GetOrdinal("Birthday")) ? new Nullable<DateTime>() : (reader.GetDateTime(reader.GetOrdinal("Birthday")));
                        string subjectName = reader.IsDBNull(reader.GetOrdinal("subjectName")) ? null : reader.GetString(reader.GetOrdinal("subjectName"));

                        txtUserName.Text = loginId;
                        txtTeachName.Text = teacherName;
                        this.rdoMale.Checked = (sex == this.rdoMale.Text);
                        this.rdoFemale.Checked = (sex == this.rdoFemale.Text);

                        this.cboState.SelectedIndex = userStateId;
                        this.cboSubject.Text = subjectName;
                    }

                    reader.Close();

                    con.Close();

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string teacherGUID = this.guid;

            string logInId = this.txtUserName.Text.Trim();
            int userStateId = this.cboState.SelectedIndex;
            string teacherName = this.txtTeachName.Text.Trim();
            string sex = this.rdoMale.Checked ? this.rdoMale.Text : this.rdoFemale.Text;
            DateTime birthday = this.dtpBirthday.Value;
            string subjectName = this.cboState.Text;


            string strSQL = "update teacher set LoginID=@LoginID,UserStateID=@UserStateID,TeacherName=@TeacherName,sex=@sex,birthday=@birthday,subjectGuid=(Select SubjectGuid from Subject where SubjectName=@subjectName))"+
                             "where teacherGuid = @TeacherGUID";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@TeacherGUID", teacherGUID);
                cmd.Parameters.AddWithValue("@LoginID", logInId);
                cmd.Parameters.AddWithValue("@UserStateID", userStateId);
                cmd.Parameters.AddWithValue("@TeacherName", teacherName);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@subjectName", subjectName);


                con.Open();

                int rows = cmd.ExecuteNonQuery();

                con.Close();

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

        }
    }
}
