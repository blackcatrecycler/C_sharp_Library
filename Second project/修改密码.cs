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
    public partial class UpdataPassword : Form
    {
        private string AccountID;
        public UpdataPassword(string Trans)
        {
            InitializeComponent();
            AccountID = Trans;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sure_Click(object sender, EventArgs e)
        {
            string select1 = "SELECT password FROM account WHERE ID =" + AccountID + "";
            DataSet ds1 = admin.query(select1);
            if (OldPassword.Text != ds1.Tables[0].Rows[0][0].ToString())
            {
                MessageBox.Show("请输入正确的密码");
            }
            else if (NewPassword1.Text != "" && NewPassword2.Text != "")
            {
                if (NewPassword1.Text != NewPassword2.Text)
                {
                    MessageBox.Show("请与第一次输入的新密码保持一致");
                }
                else
                {
                    string select2 = "UPDATE account SET password = N'" + NewPassword1.Text + "' WHERE ID =" + AccountID + "";
                    int result = 0;
                    result = admin.Sqlhelper(select2);
                    if (result == 1)
                    {
                        MessageBox.Show("修改成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败，请检查网络设置");
                    }
                }
            }
            else MessageBox.Show("新密码不能为空");
        }
    }
}
