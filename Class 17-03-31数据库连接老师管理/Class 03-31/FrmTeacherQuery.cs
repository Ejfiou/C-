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
    public partial class FrmTeacherQuery : Form
    {
        public FrmTeacherQuery()
        {
            InitializeComponent();
        }

        private string strCon = @"server=.\sql2014;database=MySchool;uid=sa;password=123";

        private DBHelper helper = new DBHelper();
        private FrmWaiting f = null;
        private void btnQuery_Click(object sender, EventArgs e)
        {
            f = new FrmWaiting();
            f.Location = this.Location;
            f.Size = this.Size;

            ShowMethod();
            //Task.Run(new Action(ShowMethod));
            f.ShowDialog();
        }

        private async void ShowMethod()
        {
            this.listView1.Items.Clear();

            string querysex = comboBox1.Text;
            if (querysex == "查询所有")
            {
                querysex = "";
            }
            string querySubjectName = cboSubject.Text;
            if (querySubjectName == "查询所有")
            {
                querySubjectName = "";
            }

            string strSQL = "SELECT [TeacherGUID],[LoginId],[TeacherName],[Sex],[Birthday],[SubjectName]FROM [dbo].[Teacher]"
                          + " Left join[subject] on[Teacher].[SubjectGUID] =[Subject].[SubjectGUID]"
                          + "where (charindex(@TeacherName,[TeacherName])>0 or Len(@TeacherName)=0) and (sex =@sex or len(@sex)=0)and(SubjectName =@subjectName or len(@subjectName)=0) order by LoginId";

            //string strSQL = "sp_teacherQuery";
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //   // cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@TeacherName", textBox1.Text);
            //    cmd.Parameters.AddWithValue("@sex", querysex);
            //    cmd.Parameters.AddWithValue("@subjectName", querySubjectName);

            //    con.Open();

            //    //System.Threading.Thread.Sleep(5000);
            //    //SqlDataReader reader = cmd.ExecuteReader();
            //    //await Task.Run(new Action(() => {
            //    //    System.Threading.Thread.Sleep(5000);
            //    //}));
            //    SqlDataReader reader =await cmd.ExecuteReaderAsync();

            //    while (reader.Read())
            //    {
            //        string teacherGuid = reader.GetString(reader.GetOrdinal("teacherGuid"));

            //        string loginId = reader.GetString(reader.GetOrdinal("LoginId"));
            //        string teacherName = reader.GetString(reader.GetOrdinal("TeacherName"));
            //        string sex = reader.IsDBNull(reader.GetOrdinal("Sex")) ? null : (reader.GetString(reader.GetOrdinal("Sex")));
            //        Nullable<DateTime> birthday = reader.IsDBNull(reader.GetOrdinal("Birthday")) ? new Nullable<DateTime>() : (reader.GetDateTime(reader.GetOrdinal("Birthday")));
            //        string subjectName = reader.IsDBNull(reader.GetOrdinal("subjectName")) ? null : reader.GetString(reader.GetOrdinal("subjectName"));

            //        ListViewItem item = new ListViewItem(loginId);
            //        item.SubItems.Add(teacherName);
            //        //item.SubItems.Add(sex==null?"未设置":sex);
            //        item.SubItems.Add(sex ?? "未设置");
            //        item.SubItems.Add(birthday.HasValue ? birthday.Value.ToString("yyyy年MM月dd日") : "未设置");
            //        item.SubItems.Add(subjectName ?? "未选择");
            //        item.Tag = teacherGuid;

            //        listView1.Items.Add(item);

            //    }
            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@TeacherName", textBox1.Text),
                new SqlParameter("@sex", querysex),
                new SqlParameter("@subjectName", querySubjectName)))
            {
                while (reader.Read())
                {
                    string teacherGuid = reader.GetString(reader.GetOrdinal("teacherGuid"));

                    string loginId = reader.GetString(reader.GetOrdinal("LoginId"));
                    string teacherName = reader.GetString(reader.GetOrdinal("TeacherName"));
                    string sex = reader.IsDBNull(reader.GetOrdinal("Sex")) ? null : (reader.GetString(reader.GetOrdinal("Sex")));
                    Nullable<DateTime> birthday = reader.IsDBNull(reader.GetOrdinal("Birthday")) ? new Nullable<DateTime>() : (reader.GetDateTime(reader.GetOrdinal("Birthday")));
                    string subjectName = reader.IsDBNull(reader.GetOrdinal("subjectName")) ? null : reader.GetString(reader.GetOrdinal("subjectName"));

                    ListViewItem item = new ListViewItem(loginId);
                    item.SubItems.Add(teacherName);
                    //item.SubItems.Add(sex==null?"未设置":sex);
                    item.SubItems.Add(sex ?? "未设置");
                    item.SubItems.Add(birthday.HasValue ? birthday.Value.ToString("yyyy年MM月dd日") : "未设置");
                    item.SubItems.Add(subjectName ?? "未选择");
                    item.Tag = teacherGuid;

                    listView1.Items.Add(item);

                }
                reader.Close();
                if (f != null)
                {
                    f.Close();
                }
            }

        }


        private void FrmTeacherQuery_Load(object sender, EventArgs e)
        {
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

            using (IDataReader reader =helper.ExecuteReader(strSQL))
            {
                while (reader.Read())
                {
                    string subjectName = reader.GetString(reader.GetOrdinal("subjectName"));

                    this.cboSubject.Items.Add(subjectName);
                }
                reader.Close();
            }
        }

        private void tsmiModify_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                string longId = listView1.SelectedItems[0].Text;
                string guid = Convert.ToString(this.listView1.SelectedItems[0].Tag);
                FrmTeacherModify f = new FrmTeacherModify(guid);
                f.ShowDialog();
                this.btnQuery.PerformClick();
            }
            else
            {
                MessageBox.Show("对不起！没有选择");
            }
        }

        private void tsmiDel_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                string longId = listView1.SelectedItems[0].Text;
                //MessageBox.Show(longId);
                string guid = Convert.ToString(this.listView1.SelectedItems[0].Tag);
                //MessageBox.Show(guid);

                DialogResult d = MessageBox.Show($"您确认要删除用户{longId}吗？", "确认", MessageBoxButtons.OKCancel);

                this.btnQuery.PerformClick();


            }
            else
            {
                MessageBox.Show("对不起！没有选择");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmTeacherAdd f = new FrmTeacherAdd();
            f.ShowDialog();

            this.btnQuery.PerformClick();
        }
    }
}
