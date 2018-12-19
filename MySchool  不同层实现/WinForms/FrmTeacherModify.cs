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
    public partial class FrmTeacherModify : Form
    {
        public FrmTeacherModify()
        {
            InitializeComponent();
        }

        public FrmTeacherModify(string guid)
        {
            InitializeComponent();
            this.guid = guid;
        }

        private BLLSubject bllSubject = new BLLSubject();
        private BLLTeacher bllTeacher = new BLLTeacher();
        private string guid = null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guid))
            {
                MessageBox.Show("该页面有问题,无法进行更新！");
                return;
            }
            string teacherGUID = this.guid;
            string logInId = this.txtUserName.Text.Trim();
            int userStateId = this.cboState.SelectedIndex;
            string teacherName = this.txtTeachName.Text.Trim();
            //string sex = this.rdoMale.Checked ? this.rdoMale.Text : this.rdoFemale.Text;
            string sex = this.rdoMale.Checked ? this.rdoMale.Text : (this.rdoFemale.Checked ? this.rdoFemale.Text : null);

            DateTime ? birthday = string.IsNullOrWhiteSpace(this.txtBirthday.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(this.txtBirthday.Text.Trim());
            string subjectGuid = string.IsNullOrWhiteSpace(this.cboSubject.SelectedValue.ToString()) ? null : this.cboSubject.SelectedValue.ToString();

            //组装对象
            Teacher teacher = new Teacher()
            {
                TeacherGuid = teacherGUID,
                LoginId = logInId,
                Sex = sex,
                UserStateId = userStateId,
                TeacherName = teacherName,
                Birthday = birthday,
                SubjectGUID = subjectGuid
            };
            int rows = bllTeacher.ModifyExcudePwd(teacher);
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

        private void FrmTeacherModify_Load(object sender, EventArgs e)
        {
            this.cboSubject.DisplayMember = "SubjectName";
            this.cboSubject.ValueMember = "SubjectGuid";

            List<Subject> list = bllSubject.QueryAll().ToList();
            if (list != null)
            {
                list.Insert(0, new Subject() { SubjectName = "", SubjectGuid = "" });
                this.cboSubject.DataSource = list;
            }

            if (!string.IsNullOrWhiteSpace(guid))
            {
                Teacher teacher = bllTeacher.QueryByPK(guid);
                if (teacher != null)
                {
                    this.txtUserName.Text = teacher.LoginId;
                    this.txtTeachName.Text = teacher.TeacherName;
                    this.rdoMale.Checked = (teacher.Sex == this.rdoMale.Text);
                    this.rdoFemale.Checked = (teacher.Sex == this.rdoFemale.Text);
                    this.txtBirthday.Text = teacher.Birthday.HasValue ? teacher.Birthday.Value.ToString("yyyy年MM月dd日"):"";
                    this.cboState.SelectedIndex = teacher.UserStateId;
                    this.cboSubject.SelectedValue = teacher.SubjectGUID??"";
                }
            }

        }

        private void txtBirthday_MouseDown(object sender, MouseEventArgs e)
        {
            this.dtpBirthday.Show();
            if (!string.IsNullOrWhiteSpace(this.txtBirthday.Text.Trim()))
            {
                this.dtpBirthday.Value = Convert.ToDateTime(this.txtBirthday.Text.Trim());
            }
        }

        private void dtpBirthday_Leave(object sender, EventArgs e)
        {
            this.txtBirthday.Text = this.dtpBirthday.Value.ToString("yyyy年MM月dd日");
            this.dtpBirthday.Hide();
        }
    }
}
