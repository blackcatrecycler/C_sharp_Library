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
    public partial class UpdateAc : Form
    {
        private string AccountID;
        public UpdateAc(string Trans)
        {
            InitializeComponent();
            AccountID = Trans;
        }

        public string CatchNumber
        {
            set
            {
                Number.Text = value;
            }
        }

        private void UpdateAc_Load(object sender, EventArgs e)
        {
            string select = "SELECT * FROM account WHERE ID =" + AccountID + "";
            DataSet ds = admin.query(select);
            Account.Text = ds.Tables[0].Rows[0][1].ToString();
            Name1.Text = ds.Tables[0].Rows[0][3].ToString();
            Number.Text = ds.Tables[0].Rows[0][4].ToString();
            string LevelKey = ds.Tables[0].Rows[0][5].ToString();

            if (AccountID == "1002")
            {
                Level1.Text = "我是无敌的管理员你懂么";
                ChangeNum1.Visible = false;
                UpPass.Visible = false;
            }
            else
            {
                if (LevelKey == "True")
                {
                    Level1.Text = "管理员";
                    ChangeNum1.Visible = true;
                    UpPass.Visible = true;

                }
                else
                {
                    Level1.Text = "学生";
                    ChangeNum1.Visible = true;
                    UpPass.Visible = true;
                }
            }
        }

        private void return1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpPass_Click(object sender, EventArgs e)
        {
            UpdataPassword Up = new UpdataPassword(AccountID);
            Up.StartPosition = FormStartPosition.CenterScreen;
            Up.ShowDialog();
        }


        private void ChangeNum_Click(object sender, EventArgs e)
        {
            ChangeNum CN = new ChangeNum(AccountID);
            CN.Owner = this;
            CN.ShowDialog();
        }
    }
}
