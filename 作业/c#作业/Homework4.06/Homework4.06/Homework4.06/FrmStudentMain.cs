using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4._06
{
    public partial class FrmStudentMain : Form
    {
        public FrmStudentMain()
        {
            InitializeComponent();
        }
        //private string strCon = @"server=.\SQL2014;database=MySchool;uid=sa;password=123";
        private string listItems = null;

        private DBHelper helper = new DBHelper();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmInsert frm = new FrmInsert();
            
            frm.ShowDialog();
            this.btnSelect.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();
            //    string strSql = "sp_selectClassName";

            //    SqlCommand cmd = new SqlCommand(strSql, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        object obj = reader.GetString(reader.GetOrdinal("ClassName"));
            //        cboClass.Items.Add(obj);
            //    }
            //    reader.Close();
            //    con.Close();
            //}
            string strSql = "sp_selectClassName";
            using (IDataReader reader = helper.ExecuteReader(strSql,CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    object obj = reader.GetString(reader.GetOrdinal("ClassName"));
                    cboClass.Items.Add(obj);
                }
                reader.Close();
            }
        }

        private FrmWait f = null;

        private void btnSelect_Click(object sender, EventArgs e)
        {
            f = new FrmWait();
            f.Location = this.Location;
            f.Size = this.Size;
            ShowM();
            f.ShowDialog();
        }

        private async void ShowM()
        {
            this.lvwShow.Items.Clear();
            string str = "sp_SelectAll";
            string className1 = cboClass.Text;
            if (cboClass.Text == "查询所有")
            {
                className1 = "";
            }
            string sex1 = cboSex.Text;
            if (cboSex.Text == "查询所有")
            {
                sex1 = "";
            }
            string stuName = textBox1.Text;
            if (textBox1.Text == "查询所有")
            {
                stuName = "";
            }
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand(str, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@Sex", sex1);
            //    cmd.Parameters.AddWithValue("@ClassName", className1);
            //    cmd.Parameters.AddWithValue("@StudentName", stuName);

            //    await Task.Run(new Action(() =>
            //    {
            //        System.Threading.Thread.Sleep(1000);
            //    }));
            //    SqlDataReader reader = await cmd.ExecuteReaderAsync();
            //    while (reader.Read())
            //    {
            //        string stuNO = reader.GetString(reader.GetOrdinal("StudentNO"));
            //        string loginId = reader.GetString(reader.GetOrdinal("LoginId"));
            //        int userStateId = reader.GetInt32(reader.GetOrdinal("UserStateId"));
            //        string userState = userStateId == 1 ? "在线" : "离线";
            //        string className = reader.GetString(reader.GetOrdinal("ClassName"));
            //        string studentName = reader.GetString(reader.GetOrdinal("StudentName"));
            //        string address = reader.GetString(reader.GetOrdinal("Address"));
            //        string sex = reader.GetString(reader.GetOrdinal("Sex"));
            //        string stuGuid = reader.GetString(reader.GetOrdinal("StudentGuid"));

            //        ListViewItem list = new ListViewItem(loginId);
            //        list.SubItems.Add(userState);
            //        list.SubItems.Add(className);
            //        list.SubItems.Add(stuNO);
            //        list.SubItems.Add(studentName);
            //        list.SubItems.Add(sex);
            //        list.SubItems.Add(address);
            //        list.Tag = stuGuid;
            //        this.lvwShow.Items.Add(list);
            //    }
            //    reader.Close();
            //    if (f!=null)
            //    {
            //        f.Close();
            //    }
            //    con.Close();
            //}


            using (IDataReader reader = helper.ExecuteReader(str,CommandType.StoredProcedure,new SqlParameter("@Sex", sex1),
                new SqlParameter("@ClassName", className1),new SqlParameter("@StudentName", stuName)))
            {
                await Task.Run(new Action(() =>
                {
                    System.Threading.Thread.Sleep(1000);
                }));
                while (reader.Read())
                {
                    string stuNO = reader.GetString(reader.GetOrdinal("StudentNO"));
                    string loginId = reader.GetString(reader.GetOrdinal("LoginId"));
                    int userStateId = reader.GetInt32(reader.GetOrdinal("UserStateId"));
                    string userState = userStateId == 1 ? "在线" : "离线";
                    string className = reader.GetString(reader.GetOrdinal("ClassName"));
                    string studentName = reader.GetString(reader.GetOrdinal("StudentName"));
                    string address = reader.GetString(reader.GetOrdinal("Address"));
                    string sex = reader.GetString(reader.GetOrdinal("Sex"));
                    string stuGuid = reader.GetString(reader.GetOrdinal("StudentGuid"));

                    ListViewItem list = new ListViewItem(loginId);
                    list.SubItems.Add(userState);
                    list.SubItems.Add(className);
                    list.SubItems.Add(stuNO);
                    list.SubItems.Add(studentName);
                    list.SubItems.Add(sex);
                    list.SubItems.Add(address);
                    list.Tag = stuGuid;
                    this.lvwShow.Items.Add(list);
                }
                reader.Close();
                if (f != null)
                {
                    f.Close();
                }
            }
        }


        private void tsmiModify_Click(object sender, EventArgs e)
        {
            if (this.lvwShow.SelectedItems.Count > 0)
            {
                listItems = lvwShow.SelectedItems[0].Tag.ToString();
                if (listItems != null)
                {
                    FrmUpdate frm = new FrmUpdate(listItems);
                    frm.ShowDialog();
                }
                this.btnSelect.PerformClick();
            }
            else
            {
                MessageBox.Show("没有选择信息");
            }
        }

        private void tsmiDel_Click(object sender, EventArgs e)
        {
            if (this.lvwShow.SelectedItems.Count > 0)
            {
                listItems = lvwShow.SelectedItems[0].Tag.ToString();
                DialogResult dr = MessageBox.Show("是否确定删除？", "删除", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    FrmDelect frm = new FrmDelect(listItems);
                    frm.ShowDialog();
                }
                this.btnSelect.PerformClick();
            }
            else
            {
                MessageBox.Show("没有选择信息");
            }
        }


        private void tsmiModifyPwd_Click(object sender, EventArgs e)
        {
            if (this.lvwShow.SelectedItems.Count > 0)
            {
                listItems = lvwShow.SelectedItems[0].Tag.ToString();
                if (listItems != null)
                {
                    FrmUpdatePassword frm = new FrmUpdatePassword(listItems);
                    frm.ShowDialog();
                }

                this.btnSelect.PerformClick();
            }
            else
            {
                MessageBox.Show("没有选择信息");
            }
        }
    }
}
