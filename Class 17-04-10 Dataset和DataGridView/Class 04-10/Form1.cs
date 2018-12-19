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
namespace Class_04_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter(strSQL, strCon);
        }

        private string strCon = @"server = .\SQL2014;database = MySchool;uid=sa;password=123";

        private SqlDataAdapter adapter;

        private string strSQL = "select * from teacher";
        private DataSet ds = new DataSet();

        private void btnFill_Click(object sender, EventArgs e)
        {

            adapter.Fill(ds,"qq");
            MessageBox.Show("填充成功！");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (ds.Tables["qq"]==null)
            {
                MessageBox.Show("请先填充数据集");
                return;
            }

            //修改内存中dataset ds 的数据
            //ds.Tables["qq"].Rows[0]["TeacherName"] = "XXX";

            this.lvwShow.Items.Clear();
            for (int i = 0; i < ds.Tables["qq"].Rows.Count; i++)
            {
                string loginId = ds.Tables["qq"].Rows[i]["LoginId"].ToString();
                string teacherName = ds.Tables["qq"].Rows[i]["TeacherName"].ToString();
                string sex = ds.Tables["qq"].Rows[i]["Sex"].ToString();

                ListViewItem item = new ListViewItem(loginId);
                item.SubItems.Add(teacherName);
                item.SubItems.Add(sex);

                this.lvwShow.Items.Add(item);
            }

            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.DataSource = ds.Tables["qq"];
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            new SqlCommandBuilder(adapter);
            adapter.Update(ds, "qq");
            MessageBox.Show("更新成功！");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ds.Tables["qq"].Clear();
            adapter.Fill(ds, "qq");
            MessageBox.Show("刷新成功！");
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables["qq"].DefaultView;
            dv.RowFilter = "Sex ='男'";
            this.dgvShow.DataSource = dv;
        }

        private void btnFale_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables["qq"].DefaultView;
            dv.RowFilter = "Sex ='女'";

            this.dgvShow.DataSource = dv;
        }
    }
}
