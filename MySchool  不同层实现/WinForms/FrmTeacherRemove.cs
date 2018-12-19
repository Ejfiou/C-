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
    public partial class FrmTeacherRemove : Form
    {
        public FrmTeacherRemove()
        {
            InitializeComponent();
        }

        public FrmTeacherRemove(string guid)
        {
            InitializeComponent();
            this.guid = guid;
        }
        private BLLTeacher bllTeacher = new BLLTeacher();


        private string guid = null;
        private void FrmTeacherRemove_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(guid))
            {
                Teacher teacher = bllTeacher.QueryByPK(guid);
                if (teacher != null)
                {
                    lblUserName.Text = teacher.LoginId;
                    this.lblTeacherName.Text = teacher.TeacherName;
                    lblSex.Text = teacher.Sex ?? "未设置";
                    lblBirthday.Text = teacher.Birthday?.ToString("yyyy年MM月dd日") ?? "未填写";
                    lblState.Text = teacher.UserStateId == 1 ? "有效" : "无效";
                    lblSubject.Text = teacher.Subject?.SubjectName ?? "未选择";
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guid))
            {
                MessageBox.Show("该页面有问题，无法进行删除！");
                return;
            }

            Teacher teacher = new Teacher()
            {
                TeacherGuid = guid
            };

           int row = bllTeacher.Remove(teacher);
            if (row>0)
            {
                MessageBox.Show("操作成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
    }
}
