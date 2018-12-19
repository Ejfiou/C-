using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySchool.BLL;
using MySchool.Model;
using MySchool.ViewModel;
namespace MySchool.WinForms
{
    public partial class FrmTeacher : Form
    {
        public FrmTeacher()
        {
            InitializeComponent();
        }

        private BLLTeacher bllTeacher = new BLLTeacher();
        private BLLSubject bllSubject = new BLLSubject();
        private FrmWaiting fWaiting = null;
        private int pageMaxRowNumber = 2;
        private int pageNumber = 1;
        private int pageTotalNumber = 0;
        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.pageNumber = 1;
            fWaiting = new FrmWaiting();
            fWaiting.Location = this.Location;
            fWaiting.Site = this.Site;
           
            ShowMethod();

            if (fWaiting != null)
            {
                fWaiting.ShowDialog();
            }

        }
        //"select Top (@pageMaxRowNumber) * from Teacher "

        private async void ShowMethod()
        {
            //组装对象
            TeacherQueryParameter p = new TeacherQueryParameter()
            {
                TeacherName = this.txtName.Text.Trim(),
                Sex = this.cboSex.Text.Trim(),
                SubjectGUID = this.cboSubject.Text.ToString(),
                PageMaxRowNumber = pageMaxRowNumber,
                PageNumber = pageNumber
            };

            //await Task.Run(() =>
            //{
            //    System.Threading.Thread.Sleep(3000);
            //});

            IEnumerable<Teacher> list = await bllTeacher.QueryPageAsync(p);

            await Task.Run(() =>
            {
                this.dgvShow.AutoGenerateColumns = false;
                this.dgvShow.DataSource = list.ToList();
            });

            if (fWaiting != null)
            {
                fWaiting.Close();
                fWaiting = null;
            }

            this.pageTotalNumber = p.PageTotalNumber;//得到总页数

            this.linkLabel1.Enabled = true;
            this.linkLabel2.Enabled = true;
            this.llblFirst.Enabled = true;
            this.llblLast.Enabled = true;

            if (pageNumber<=1)
            {
                this.linkLabel2.Enabled = false;
                this.llblFirst.Enabled = false;
            }
           
            if (pageNumber >= p.PageTotalNumber)
            {
                linkLabel1.Enabled = false;
                this.llblLast.Enabled = false;
            }
        }



        private void dgvShow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string propertyName = this.dgvShow.Columns[e.ColumnIndex].DataPropertyName;
            if (propertyName.Contains("."))
            {
                var obj = this.dgvShow.Rows[e.RowIndex].DataBoundItem;
                if (obj is Teacher)
                {
                    string[] names = propertyName.Split('.');
                    if (names[0] == "Subject")
                    {
                        if (names[1] == "SubjectName")
                        {
                            e.Value = (obj as Teacher).Subject.SubjectName;
                        }
                    }
                }
            }
        }

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            fWaiting = new FrmWaiting();
            fWaiting.Location = this.Location;
            fWaiting.Site = this.Site;

            this.cboSubject.DisplayMember = "SubjectName";
            this.cboSubject.ValueMember = "SubjectGuid";

            cboSubjectLoadAsync();

            if (fWaiting != null)
            {
                fWaiting.ShowDialog();
            }
        }

        private async void cboSubjectLoadAsync()
        {
            IEnumerable<Subject> temp = await bllSubject.QueryAllAsync();

            await Task.Run(() =>
            {
                List<Subject> list = temp.ToList();
                if (list != null)
                {
                    list.Insert(0, new Subject() { SubjectName = "", SubjectGuid = "" });
                    this.cboSubject.DataSource = list;
                    this.cboSubject.Text = null;
                }

            });

            if (fWaiting != null)
            {
                fWaiting.Close();
                fWaiting = null;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageNumber++;

            this.cboSubject.DisplayMember = "SubjectName";
            this.cboSubject.ValueMember = "SubjectGuid";

            ShowMethod();
            if (fWaiting!=null)
            {
                fWaiting.ShowDialog();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageNumber--;

            this.cboSubject.DisplayMember = "SubjectName";
            this.cboSubject.ValueMember = "SubjectGuid";

            ShowMethod();

            if (fWaiting != null)
            {
                fWaiting.ShowDialog();
            }
        }

        private void llblFirst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageNumber=1;

            this.cboSubject.DisplayMember = "SubjectName";
            this.cboSubject.ValueMember = "SubjectGuid";

            ShowMethod();
            if (fWaiting != null)
            {
                fWaiting.ShowDialog();
            }
        }

        private void llblLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageNumber = pageTotalNumber;

            this.cboSubject.DisplayMember = "SubjectName";
            this.cboSubject.ValueMember = "SubjectGuid";

            ShowMethod();

            if (fWaiting != null)
            {
                fWaiting.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmTeacherAdd f = new FrmTeacherAdd();
            f.ShowDialog();
        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Type cellType = this.dgvShow.Columns[e.ColumnIndex].CellType;
            if (cellType == typeof(DataGridViewButtonCell))
            {
                if (this.dgvShow.Columns[e.ColumnIndex].HeaderText == "修改")
                {
                    var temp = this.dgvShow.Rows[e.RowIndex].DataBoundItem;
                    if (temp is Teacher)
                    {
                        string guid = (temp as Teacher).TeacherGuid;
                        FrmTeacherModify f = new FrmTeacherModify(guid);
                        f.ShowDialog();
                        this.btnQuery.PerformClick();
                    }
                }
                else if (this.dgvShow.Columns[e.ColumnIndex].HeaderText == "删除")
                {
                    var temp = this.dgvShow.Rows[e.RowIndex].DataBoundItem;
                    if (temp is Teacher)
                    {
                        string guid = (temp as Teacher).TeacherGuid;
                        string longId = (temp as Teacher).LoginId;

                        DialogResult d = MessageBox.Show($"您确认要删除用户{longId}吗？", "确认", MessageBoxButtons.OKCancel);
                        if (d == DialogResult.OK)
                        {
                            FrmTeacherRemove f = new FrmTeacherRemove(guid);
                            f.ShowDialog();
                            this.btnQuery.PerformClick();
                        }
                    }
                }
                else if (this.dgvShow.Columns[e.ColumnIndex].HeaderText == "修改密码")
                {
                    var temp = this.dgvShow.Rows[e.RowIndex].DataBoundItem;
                    if (temp is Teacher)
                    {
                        string guid = (temp as Teacher).TeacherGuid;
                        FrmPasswordModify f = new FrmPasswordModify(guid);
                        f.ShowDialog();                       
                    }
                }


            }
        }
    }
}
