using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Second_project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Account.Text == "")
            {
                MessageBox.Show("账号不能为空");
            }
            else if (Password1.Text == "")
            {
                MessageBox.Show("密码不能为空");
            }
            else if (Password2.Text != Password1.Text)
            {
                MessageBox.Show("前后密码必须一致");
            }
            else if (Name1.Text == "")
            {
                MessageBox.Show("姓名不能为空");
            }
            else if (Number.Text == "")
            {
                MessageBox.Show("手机不能为空");
            }
            else if (Number.Text.Length != 11)
            {
                MessageBox.Show("手机长度必须为11位");
            }
            else
            {
                string select = "SELECT account FROM account WHERE account =N'" + Account.Text + "'";
                int result1 = 0;
                result1 = admin.Sqlhelper(select);
                if (result1 != 1)
                {
                    string select2 = "INSERT INTO account VALUES (N'" + Account.Text + "',N'" + Password1.Text + "',N'" + Name1.Text + "',N'" + Number.Text + "', 0)";
                    int result = 0;
                    result = admin.Sqlhelper(select2);
                    if (result == 1)
                    {
                        MessageBox.Show("注册成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败，请检查网络状况");
                    }
                }
                else
                {
                    MessageBox.Show("该帐号已存在");
                }
            }
        }
    }
}
