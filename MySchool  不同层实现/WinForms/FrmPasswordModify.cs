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
    public partial class FrmPasswordModify : Form
    {
        public FrmPasswordModify()
        {
            InitializeComponent();
        }
        private BLLTeacher bllTeacher = new BLLTeacher();

        public FrmPasswordModify(string guid)
        {
            InitializeComponent();

            this.guid = guid;
        }

        private string guid = null;

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guid))
            {
                MessageBox.Show("操作有误！");
                return;
            }

            Teacher teacher = new Teacher()
            {
                TeacherGuid = guid,
                LoginPwd = this.txtNew2.Text
            };

            Teacher temp = bllTeacher.QueryByPK(guid);
            if (temp != null)
            {
                if (temp.LoginPwd!=txtOld.Text.Trim())
                {
                    MessageBox.Show("原始密码错误");
                    return;
                }
            }
            int rows = bllTeacher.ModifyPwd(teacher);
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
