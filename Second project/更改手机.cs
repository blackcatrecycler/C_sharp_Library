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
    public partial class ChangeNum : Form
    {
        private string ID;
        public ChangeNum(string num)
        {
            InitializeComponent();
            ID = num;
        }

        private void ChangeNum_Load(object sender, EventArgs e)
        {
            Click.Text = "点我发送验证码";
            SureChange.Enabled = false;
        }

        private void Click_Click(object sender, EventArgs e)
        {
            try
            {
                int a = (int)Convert.ToDouble(textBox1.Text);
                if (textBox1.TextLength == 11)
                {
                    if (Click.Text == "点我发送验证码")
                    {
                        MessageBox.Show("已将验证码发送至您的手机");
                        MessageBox.Show("验证码为0000");
                        Click.Text = "重新发送";
                    }
                    else
                    {

                        MessageBox.Show("已将验证码发送至您的手机");
                        MessageBox.Show("验证码为0000");
                    }
                    SureChange.Enabled = true;
                }
                else
                {
                    MessageBox.Show("请输入正确手机号");
                }
            }
            catch
            {
                MessageBox.Show("请输入正确手机号");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Click.Text = "点我发送验证码";
            SureChange.Enabled = false;
        }

        private void SureChange_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (textBox2.Text == "0000")
                {
                    string select = "UPDATE account SET number = N'" + textBox1.Text + "' WHERE ID = " + ID + "";
                    int result = admin.Sqlhelper(select);
                    if (result == 1)
                    {
                        MessageBox.Show("添加成功");
                        UpdateAc UA = (UpdateAc)this.Owner;
                        UA.CatchNumber = textBox1.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
                else
                {
                    MessageBox.Show("请输入正确的验证码");
                }
            }
            else
            {
                MessageBox.Show("请输入验证码");
            }
                    
        }
    }
}
