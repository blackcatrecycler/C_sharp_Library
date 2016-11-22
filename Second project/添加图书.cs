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
    public partial class AddBook : Form
    { 
        public AddBook()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)    //添加
        {
            string insert = "";
            int result = 0;
            if (comboBox2.Text != "—出版时间—" && comboBox1.Text != "-请选择图书分类-" && textBox1.Text != "" && textBox2.Text != "")
            {
                insert = "INSERT INTO library (name,type,writer,year,quantity) VALUES (N'" + textBox1.Text + "',N'" + comboBox1.Text + "',N'" + textBox2.Text + "',N'" + comboBox2.Text + "',3)";
            }
            result = admin.Sqlhelper(insert);
            if (result == 1)
            {
                MessageBox.Show("添加成功");
                textBox1.Text = "";
                comboBox1.Text = "-请选择图书分类-";
                textBox2.Text = "";
                comboBox2.Text = "—出版时间—";
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "-请选择图书分类-";
            comboBox2.Text = "—出版时间—";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
