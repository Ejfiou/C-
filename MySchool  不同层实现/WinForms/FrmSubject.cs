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
    public partial class FrmSubject : Form
    {
        public FrmSubject()
        {
            InitializeComponent();
        }

        private BLLSubject bllSubject = new BLLSubject();

        private void FrmSubject_Load(object sender, EventArgs e)
        {
            this.cboSubject.DisplayMember = "SubjectName";
            this.cboSubject.ValueMember = "SubjectGuid";

            cboSubjectLoad();

        }

        private async void cboSubjectLoad()
        {
            List<Subject> list = (await bllSubject.QueryAllAsync()).ToList();

            if (list != null)
            {
                //方法一
                //不会默认选中任何项
                //foreach (var item in list)
                //{
                //    // this.cboSubject.Items.Add(item.SubjectName);
                //    this.cboSubject.Items.Add(item);
                //}

                //方法二
                //默认会选中第一项
                //list.Insert(0, new Subject() { SubjectName = "", SubjectGuid = "" });
                this.cboSubject.DataSource = list;
                this.cboSubject.Text = null;
            }
        }

        private void cboSubject_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.cboSubject.Text);
            //Subject temp = this.cboSubject.Items[this.cboSubject.SelectedIndex] as Subject;
            //Subject temp = this.cboSubject.SelectedItem as Subject;
            //MessageBox.Show(temp.SubjectGuid);
        }

        private void cboSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Subject temp = this.cboSubject.SelectedItem as Subject;
            MessageBox.Show(temp.SubjectGuid);
        }
    }
}
