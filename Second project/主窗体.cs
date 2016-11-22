using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Second_project
{
    public partial class Form1 : Form
    {
        public string BookID, NameID;
        bool admin1 = false;
        static string str = @"Data Source=(localdb)\v11.0; Initial Catalog=Library;integrated security=True;";
        static string select = "SELECT * FROM library";
        public Form1()
        {
            InitializeComponent();
        }
        public string nameID
        {
            set
            {
                NameID = value;
            }
        }

        public void inquiry_Click(object sender, EventArgs e)              //查询按钮
        {
            if (Se2.Checked == true || Se3.Checked == true)
            {
                Se1.Checked = true;
                Se2.Checked = false;
                Se3.Checked = false;
            }
            string FinSelect = select;
            if (SearchText.Text == "") FinSelect = select;
            else
            {
                if (SearchList.Text == "书名") FinSelect = select + " WHERE name like N'%" + SearchText.Text + "%'";
                if (SearchList.Text == "作者") FinSelect = select + " WHERE writer like N'%" + SearchText.Text + "%'";
                if (SearchList.Text == "类型") FinSelect = select + " WHERE type like N'%" + SearchText.Text + "%'";
                if (SearchList.Text == "出版时间") FinSelect = select + " WHERE year like N'%" + SearchText.Text + "%'";
                if (SearchList.Text == "全部") FinSelect = select + " WHERE name like N'%" + SearchText.Text + "%' OR writer like N'%" + SearchText.Text + "%' OR type like N'%" + SearchText.Text + "%' OR year like N'%" + SearchText.Text + "%'";
            }
            DataSet ds = admin.query(FinSelect);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;   //列宽
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;     //行高
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "书名";
            dataGridView1.Columns[2].HeaderText = "作者";
            dataGridView1.Columns[3].HeaderText = "分类";
            dataGridView1.Columns[4].HeaderText = "出版年份";
            dataGridView1.Columns[5].HeaderText = "剩余数量";
            if (NameID == null)
            {
                dataGridView1.Columns[5].Visible = false;
            }
            else
            {
                dataGridView1.Columns[5].Visible = true;
            }
            dataGridView1.ReadOnly = true;

        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)          //登录、注销
        {
            if (Login.Text == "登录")
            {
                LoginWin Login1 = new LoginWin();
                Login1.Owner = this;
                Login1.StartPosition = FormStartPosition.CenterScreen;
                Login1.ShowDialog();
                try
                {
                    string Finselect = "SELECT name,level1 FROM account WHERE ID = " + NameID;
                    DataSet ds = admin.query(Finselect);
                    string Account_Name = ds.Tables[0].Rows[0][0].ToString();
                    string Account_level = ds.Tables[0].Rows[0][1].ToString();
                    Se1.Visible = true;
                    Se2.Visible = true;
                    if (Account_level == "True")
                    {
                        Add.Visible = true;
                        Update.Visible = true;
                        Delete.Visible = true;
                        Se1.Text = "书籍管理模式";
                        Se2.Text = "借阅查询模式";
                        Se3.Visible = true;
                        admin1 = true;
                    }
                    else
                    {
                        Borrow.Visible = true;
                        Se1.Text = "我的查询";
                        Se2.Text = "我的借阅";
                    }
                    NameLink.Text = Account_Name;
                    NameLink.Visible = true;
                    Login.Text = "注销";
                }
                catch { }
                finally
                { }

            }
            else if (Login.Text == "注销")
            {
                if (MessageBox.Show("确定注销吗？", "注销确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    //如果不是OK则取消。
                }
                else
                {
                    Login.Text = "登录";
                    NameID = null;
                    dataGridView1.DataSource = null;
                    NameLink.Visible = false;
                    Add.Visible = false;
                    Update.Visible = false;
                    Delete.Visible = false;
                    Borrow.Visible = false;
                    Se2.Checked = false;
                    Se1.Checked = true;
                    Se1.Visible = false;
                    Se2.Visible = false;
                    admin1 = false;
                    See1.Visible = false;
                    See2.Visible = false;
                    Se3.Visible = false;
                    LevelUp.Visible = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) //设置各个combobox的初始值
        {
            SearchList.Text = "全部";
            NameLink.Visible = false;
            Add.Visible = false;
            Update.Visible = false;
            Delete.Visible = false;
            Borrow.Visible = false;
            Return.Visible = false;
            Se1.Checked = true;
            Se1.Visible = false;
            Se2.Visible = false;
            Se3.Visible = false;
            See1.Visible = false;
            See2.Visible = false;
            Return.Visible = false;
            LevelUp.Visible = false;
        }

        private void NameLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateAc UA = new UpdateAc(NameID);
            UA.Owner = this;
            UA.StartPosition = FormStartPosition.CenterScreen;
            UA.ShowDialog();
        }   //当前用户信息

        private void Se1_CheckedChanged(object sender, EventArgs e)         //书籍模式
        {
            dataGridView1.DataSource = null;
            if (Login.Text != "登录")
            {
                if (admin1 == false)
                {
                    Return.Visible = false;
                    Borrow.Text = "借阅";
                }
                else
                {
                    See1.Visible = false;
                    See2.Visible = false;
                    Add.Visible = true;
                    Delete.Visible = true;
                    Update.Visible = true;
                    LevelUp.Visible = false;
                }
            }
        }

        private void Se2_CheckedChanged(object sender, EventArgs e)         //借阅模式
        {
            dataGridView1.DataSource = null;
            if (Login.Text != "登录")
            {
                LevelUp.Visible = false;
                if (admin1 == false)
                {
                    Return.Visible = true;
                    Borrow.Text = "续借";
                    string select = "SELECT *FROM BorrowView WHERE StudentID =" + NameID + " AND Return1 = 1";
                    DataSet ds = admin.query(select);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "书名";
                    dataGridView1.Columns[2].HeaderText = "借书日期";
                    dataGridView1.Columns[3].HeaderText = "截止日期";
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].HeaderText = "能否续借";
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                }
                else
                {
                    See1.Visible = true;
                    See2.Visible = true;
                    Add.Visible = false;
                    Delete.Visible = false;
                    Update.Visible = false;
                }
            }
        }

        /*学生用按钮*/

        private void Borrow_Click(object sender, EventArgs e)           //借阅 续借按钮
        {
            if (Borrow.Text == "借阅")
            {
                try
                {
                    string BN = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                    string BI = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    if (MessageBox.Show("你确定要借《" + BN + "》这本书吗？", "借阅确认",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    {
                        //如果不是OK则取消。
                    }
                    else
                    {
                        string select3 = "SELECT *FROM book_student_relations WHERE StudentID =" + NameID + " AND Return1 = 1";
                        DataSet ds = admin.query(select3);
                        int returnNum = ds.Tables[0].Rows.Count;
                        if (returnNum <= 7)
                        {
                            string sure = "SELECT quantity FROM library WHERE ID = " + BI + "";
                            DataSet ds1 = admin.query(sure);
                            int quantity = (int)ds1.Tables[0].Rows[0][0];
                            if (quantity > 1)
                            {
                                string NowTime, NextTime;
                                DateTime time1 = new DateTime();
                                time1 = DateTime.Now;
                                NowTime = time1.ToString("d");
                                select3 = "SELECT *FROM book_student_relations WHERE StudentID=" + NameID + " AND Endtime< '" + NowTime + "' AND Return1 = 1";                           //判断是否有超期图书
                                int judge = 0;
                                judge = admin.Sqlhelper(select3);
                                if (judge == -1)
                                {
                                    NextTime = time1.AddDays(30).ToString("d");
                                    string select = "INSERT INTO book_student_relations (StudentID,BookID,StartTime,EndTime,Return1,Continue1) VALUES (" + NameID + "," + BI + ",'" + NowTime + "','" + NextTime + "',1,1)";
                                    int result = admin.Sqlhelper(select);
                                    quantity -= 1;
                                    select = "UPDATE library SET quantity = " + quantity.ToString() + "WHERE ID =" + BI + "";
                                    int result2 = admin.Sqlhelper(select);
                                    if (result == 1)
                                    {
                                        MessageBox.Show("借阅成功,请在截止日期前还书");
                                    }
                                    else
                                    {
                                        MessageBox.Show("借阅失败");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("请将过期的图书还回再借阅图书");
                                }
                            }
                            else
                            {
                                MessageBox.Show("该图书数量有限,暂时无法借阅");
                            }
                        }
                        else
                        {
                            MessageBox.Show("您的借阅数量超过7本，请还书后再借");
                        }
                    }
                }
                catch { MessageBox.Show("请先选中一本书"); }
            }
            else if (Borrow.Text == "续借")
            {
                try
                {
                    string BN = dataGridView1.CurrentRow.Cells["Book"].Value.ToString();
                    string BI = dataGridView1.CurrentRow.Cells["BookID"].Value.ToString();
                    string ID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    string select = "SELECT Continue1 FROM book_student_relations WHERE ID=" + ID + "";
                    DataSet ds = admin.query(select);
                    bool can = (bool)ds.Tables[0].Rows[0][0];
                    if (MessageBox.Show("你确定要续借《" + BN + "》这本书吗？", "续借确认",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    {
                        //如果不是OK则取消。
                    }
                    else
                    {
                        if (can == true)
                        {
                            select = "SELECT EndTime FROM book_student_relations WHERE ID =" + ID + "";
                            ds = admin.query(select);
                            DateTime dt = (DateTime)ds.Tables[0].Rows[0][0];
                            string ET = dt.AddDays(30).ToString("d");
                            select = "UPDATE book_student_relations SET EndTime = '" + ET + "',Continue1=0 WHERE ID =" + ID + "";
                            int result = 0;
                            result = admin.Sqlhelper(select);
                            if (result == 1)
                            {
                                MessageBox.Show("续借成功");
                                Se2.Checked = false;
                                Se2.Checked = true;
                            }
                            else
                            {
                                MessageBox.Show("续借失败");
                            }
                        }
                        else
                        {
                            MessageBox.Show("该书已无法续借");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("请先选中一本图书");
                }
            }
        }

        private void Return_Click(object sender, EventArgs e)        //还书按钮
        {
            try
            {
                DateTime Dt = DateTime.Now;
                string BI = dataGridView1.CurrentRow.Cells["BookID"].Value.ToString();
                string BN = dataGridView1.CurrentRow.Cells["Book"].Value.ToString();
                string ID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                if (MessageBox.Show("你确定要还《" + BN + "》这本书吗？", "归还确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    //什么都没有
                }
                else
                {
                    string select = "SELECT EndTime FROM book_student_relations WHERE ID=" + ID + "";
                    DataSet ds = admin.query(select);
                    DateTime Dt1 = (DateTime)ds.Tables[0].Rows[0][0];
                    select = "UPDATE book_student_relations SET Return1 = 0 WHERE ID=" + ID + "";
                    int result = admin.Sqlhelper(select);
                    if (result == 1)
                    {
                        select = "SELECT quantity FROM library WHERE ID=" + BI + "";
                        ds = admin.query(select);
                        int a = (int)ds.Tables[0].Rows[0][0];
                        a += 1;
                        select = "UPDATE library SET quantity =" + a + " WHERE ID=" + BI + "";
                        result = admin.Sqlhelper(select);
                        if (result == 1)
                        {
                            if (Dt <= Dt1)
                            {
                                MessageBox.Show("归还成功");
                                Se2.Checked = false;
                                Se2.Checked = true;
                            }
                            else
                            {
                                int Time1 = (Dt - Dt1).Days;
                                string Money = Time1.ToString();
                                MessageBox.Show("归还成功\t\n本次借阅超期" + Money + "天，你需要交罚款" + Money + "元");
                                Se2.Checked = false;
                                Se2.Checked = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("归还失败");
                        }
                    }
                    else
                    {
                        MessageBox.Show("归还失败");
                    }
                }
            }
            catch
            {
                MessageBox.Show("请先选中一本书");
            }
        }

        /*管理员用按钮*/

        private void See2_Click(object sender, EventArgs e)         //当前借阅
        {
            string select = "SELECT *FROM BorrowView WHERE Return1 = 1";
            DataSet ds = admin.query(select);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "学生名";
            dataGridView1.Columns[1].HeaderText = "书名";
            dataGridView1.Columns[2].HeaderText = "借书日期";
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[3].HeaderText = "截止日期";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

        }

        private void See1_Click(object sender, EventArgs e)          //借阅历史
        {
            string select = "SELECT *FROM BorrowView WHERE Return1 =0";
            DataSet ds = admin.query(select);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "学生名";
            dataGridView1.Columns[1].HeaderText = "书名";
            dataGridView1.Columns[2].HeaderText = "借书日期";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void Se3_CheckedChanged(object sender, EventArgs e) //账户管理模式
        {
            Add.Visible = false;
            Delete.Visible = false;
            Update.Visible = false;
            See1.Visible = false;
            See2.Visible = false;
            Return.Visible = false;
            Borrow.Visible = false;

            if (NameID == "1002")
            {
                string select = "SELECT *FROM account WHERE ID <> 1002";
                DataSet ds = admin.query(select);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "账号";
                dataGridView1.Columns[2].HeaderText = "密码";
                dataGridView1.Columns[3].HeaderText = "姓名";
                dataGridView1.Columns[4].HeaderText = "电话";
                dataGridView1.Columns[5].Visible = true;
                dataGridView1.Columns[5].HeaderText = "管理员";
                LevelUp.Visible = true;
            }
            else
            {
                string select = "SELECT *FROM account WHERE level1 = 0";
                DataSet ds = admin.query(select);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "账号";
                dataGridView1.Columns[2].HeaderText = "密码";
                dataGridView1.Columns[3].HeaderText = "姓名";
                dataGridView1.Columns[4].HeaderText = "电话";
                dataGridView1.Columns[5].Visible = false;
                LevelUp.Visible = false;
            }
        }

        public void Updata_Click(object sender, EventArgs e)                 //修改按钮
        {

            try
            {
                BookID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                Updatebook up = new Updatebook(BookID);
                up.StartPosition = FormStartPosition.CenterScreen;
                up.ShowDialog();
            }
            catch
            {
                MessageBox.Show("请选中图书后再修改");
            }
            finally { }
        }

        private void Delete_Click(object sender, EventArgs e)               //删除按钮
        {
            if (MessageBox.Show("确定删除该行数据吗？", "删除确认",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                //如果不是OK则取消。
            }
            else
            {
                try
                {
                    string id = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    string delete = "DELETE FROM library where ID = '" + id + "'";
                    int result = admin.Sqlhelper(delete);
                    if (result == 1)
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
                catch { MessageBox.Show("请先选中一本图书"); }
            }
        }

        private void add_Click(object sender, EventArgs e)                  //增加按钮
        {
            AddBook AddWin = new AddBook();
            AddWin.StartPosition = FormStartPosition.CenterScreen;
            AddWin.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本系统由黑猫制作，黑猫制品，必属精品！");
        }

        private void LevelUp_Click(object sender, EventArgs e)              //升降级按钮
        {
            try
            {
                string ID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                string Name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                bool I = (bool)dataGridView1.CurrentRow.Cells["level1"].Value;
                if (I == false)
                {
                    if (MessageBox.Show("你确定将" + Name + "升级为管理员吗？", "升级确定",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    {

                    }
                    else
                    {
                        string select = "UPDATE account SET level1 = 1 WHERE ID =" + ID + "";
                        int result = admin.Sqlhelper(select);
                        if (result == 1)
                        {
                            MessageBox.Show("升级成功");
                            Se3.Checked = false;
                            Se3.Checked = true;
                        }
                        else
                        {
                            MessageBox.Show("升级失败");
                        }
                    }
                }
                else
                {

                    if (MessageBox.Show("你确定将" + Name + "降级为普通用户吗？", "降级确定",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    {

                    }
                    else
                    {
                        string select = "UPDATE account SET level1 = 0 WHERE ID =" + ID + "";
                        int result = admin.Sqlhelper(select);
                        if (result == 1)
                        {
                            MessageBox.Show("降级成功");
                            Se3.Checked = false;
                            Se3.Checked = true;
                        }
                        else
                        {
                            MessageBox.Show("降级失败");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("请先选中一个用户");
            }

        }
    }
}
