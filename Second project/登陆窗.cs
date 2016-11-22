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
    public partial class LoginWin : Form
    {
        static string str = @"Data Source=(localdb)\v11.0; Initial Catalog=Library; User ID=sa;Password=sa";
        int n;
        public string NameID;
        public LoginWin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void LoginButton_Click(object sender, EventArgs e)              //登录按钮
        {

                string Lo = "SELECT *FROM account where account= '" + account.Text + "' and password= '" + password.Text + "'";
                DataSet ds1 = admin.query(Lo);
                int result = ds1.Tables[0].Rows.Count;
                if (result == 1)
                {
                    Lo = "SELECT ID FROM account WHERE  account= '" + account.Text + "' and password= '" + password.Text + "'";
                    DataSet ds = admin.query(Lo);
                    NameID = ds.Tables[0].Rows[0][0].ToString();
                    Form1 f1 = (Form1)this.Owner;
                    f1.nameID = NameID;
                    MessageBox.Show("登录成功");
                    n = 0;
                    this.Close();
                }
                else
                {
                    if (n >= 3)
                    {
                        MessageBox.Show("您的登录失败次数大于3次，请联系管理员。");
                    }
                    else
                    {
                        MessageBox.Show("登录失败");
                    }
                    n++;
                }
        }

        private void Registered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register Re = new Register();
            Re.StartPosition = FormStartPosition.CenterScreen;
            Re.ShowDialog();
        }

        private void forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("请联系管理员获取密码信息");
        }
    }
}
