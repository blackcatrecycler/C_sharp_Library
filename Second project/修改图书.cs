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
    public partial class Updatebook : Form
    {
        public String BookID;
        public Updatebook(String Trans)
        {
            InitializeComponent();
            BookID = Trans;
            
        }

        private void Updatebook_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Owner = this;
            string select = "SELECT * FROM library WHERE ID = " + BookID;
            DataSet ds = admin.query(select);
            textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            comboBox1.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox2.Text = ds.Tables[0].Rows[0][2].ToString();
            comboBox2.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定修改这些数据吗？", "修改确认",
    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                //如果不是OK则取消。
            }
            else
            {
                int result = 0;
                if (comboBox2.Text != "—出版时间—" && comboBox1.Text != "-请选择图书分类-" && textBox1.Text != "" && textBox2.Text != "")
                {
                    string select = "UPDATE library SET name = N'" + textBox1.Text + "', type = N'" + comboBox1.Text + "', writer = N'" + textBox2.Text + "', year = N'" + comboBox2.Text + "' WHERE ID = " + BookID + "";
                    result = admin.Sqlhelper(select);
                }
                if (result == 1)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else MessageBox.Show("修改失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
