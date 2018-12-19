using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySchool.Model;
using MySchool.BLL;
namespace MySchool.WinForms
{
    public partial class FrmTeacherAdd : Form
    {
        public FrmTeacherAdd()
        {
            InitializeComponent();
        }

        private BLLSubject bllSubject = new BLLSubject();
        private BLLTeacher bllTeacher = new BLLTeacher();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string teacherGUID = Guid.NewGuid().ToString();
            string logInId = this.txtUserName.Text.Trim();
            string loginPwd = "12345";
            int userStateId = this.cboState.SelectedIndex;
            string teacherName = this.txtTeachName.Text.Trim();
            //string sex = this.rdoMale.Checked ? this.rdoMale.Text : this.rdoFemale.Text;
            string sex = this.rdoMale.Checked ? this.rdoMale.Text : (this.rdoFemale.Checked ? this.rdoFemale.Text : null);

            DateTime? birthday = string.IsNullOrWhiteSpace(this.txtBirthday.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(this.txtBirthday.Text.Trim());
            string subjectGuid = string.IsNullOrWhiteSpace(this.cboSubject.SelectedValue.ToString()) ? null:this.cboSubject.SelectedValue.ToString();

            //组装对象
            Teacher teacher = new Teacher()
            {
                TeacherGuid = teacherGUID,
                LoginId = logInId,
                LoginPwd = loginPwd,
                Sex = sex,
                UserStateId = userStateId,
                TeacherName = teacherName,
                Birthday = birthday,
                SubjectGUID = subjectGuid
            };
            int rows = bllTeacher.Add(teacher);
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

        private void FrmTeacherAdd_Load(object sender, EventArgs e)
        {
            this.cboSubject.DisplayMember = "SubjectName";
            this.cboSubject.ValueMember = "SubjectGuid";

            List<Subject> list = bllSubject.QueryAll().ToList();
            if (list!=null)
            {
                list.Insert(0, new Subject() { SubjectName = "", SubjectGuid = "" });
                this.cboSubject.DataSource = list;
            }
        }

        private void txtBirthday_MouseDown(object sender, MouseEventArgs e)
        {
            this.dtpBirthday.Show();
        }

        private void dtpBirthday_Leave(object sender, EventArgs e)
        {
            this.txtBirthday.Text = this.dtpBirthday.Value.ToString("yyyy年MM月dd日");
            this.dtpBirthday.Hide();
        }
    }
}
