namespace Second_project
{
    partial class UpdateAc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accountlabel1 = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.Namelabel1 = new System.Windows.Forms.Label();
            this.UpPass = new System.Windows.Forms.Button();
            this.Name1 = new System.Windows.Forms.Label();
            this.return1 = new System.Windows.Forms.Button();
            this.Numberlabel1 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.levellabel1 = new System.Windows.Forms.Label();
            this.Level1 = new System.Windows.Forms.Label();
            this.ChangeNum1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountlabel1
            // 
            this.accountlabel1.AutoSize = true;
            this.accountlabel1.Location = new System.Drawing.Point(18, 29);
            this.accountlabel1.Name = "accountlabel1";
            this.accountlabel1.Size = new System.Drawing.Size(35, 12);
            this.accountlabel1.TabIndex = 0;
            this.accountlabel1.Text = "账号:";
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Location = new System.Drawing.Point(56, 29);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(41, 12);
            this.Account.TabIndex = 1;
            this.Account.Text = "label1";
            // 
            // Namelabel1
            // 
            this.Namelabel1.AutoSize = true;
            this.Namelabel1.Location = new System.Drawing.Point(18, 87);
            this.Namelabel1.Name = "Namelabel1";
            this.Namelabel1.Size = new System.Drawing.Size(35, 12);
            this.Namelabel1.TabIndex = 2;
            this.Namelabel1.Text = "姓名:";
            // 
            // UpPass
            // 
            this.UpPass.Location = new System.Drawing.Point(91, 302);
            this.UpPass.Name = "UpPass";
            this.UpPass.Size = new System.Drawing.Size(76, 27);
            this.UpPass.TabIndex = 4;
            this.UpPass.Text = "修改密码";
            this.UpPass.UseVisualStyleBackColor = true;
            this.UpPass.Click += new System.EventHandler(this.UpPass_Click);
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(56, 87);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(41, 12);
            this.Name1.TabIndex = 5;
            this.Name1.Text = "label1";
            // 
            // return1
            // 
            this.return1.Location = new System.Drawing.Point(187, 302);
            this.return1.Name = "return1";
            this.return1.Size = new System.Drawing.Size(76, 27);
            this.return1.TabIndex = 6;
            this.return1.Text = "确认";
            this.return1.UseVisualStyleBackColor = true;
            this.return1.Click += new System.EventHandler(this.return1_Click);
            // 
            // Numberlabel1
            // 
            this.Numberlabel1.AutoSize = true;
            this.Numberlabel1.Location = new System.Drawing.Point(18, 147);
            this.Numberlabel1.Name = "Numberlabel1";
            this.Numberlabel1.Size = new System.Drawing.Size(35, 12);
            this.Numberlabel1.TabIndex = 7;
            this.Numberlabel1.Text = "手机:";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(56, 146);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(41, 12);
            this.Number.TabIndex = 8;
            this.Number.Text = "label1";
            // 
            // levellabel1
            // 
            this.levellabel1.AutoSize = true;
            this.levellabel1.Location = new System.Drawing.Point(18, 206);
            this.levellabel1.Name = "levellabel1";
            this.levellabel1.Size = new System.Drawing.Size(35, 12);
            this.levellabel1.TabIndex = 9;
            this.levellabel1.Text = "等级:";
            // 
            // Level1
            // 
            this.Level1.AutoSize = true;
            this.Level1.Location = new System.Drawing.Point(56, 206);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(41, 12);
            this.Level1.TabIndex = 10;
            this.Level1.Text = "label1";
            // 
            // ChangeNum1
            // 
            this.ChangeNum1.Location = new System.Drawing.Point(205, 140);
            this.ChangeNum1.Name = "ChangeNum1";
            this.ChangeNum1.Size = new System.Drawing.Size(111, 26);
            this.ChangeNum1.TabIndex = 11;
            this.ChangeNum1.Text = "更换我的手机";
            this.ChangeNum1.UseVisualStyleBackColor = true;
            this.ChangeNum1.Click += new System.EventHandler(this.ChangeNum_Click);
            // 
            // UpdateAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 351);
            this.Controls.Add(this.ChangeNum1);
            this.Controls.Add(this.Level1);
            this.Controls.Add(this.levellabel1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Numberlabel1);
            this.Controls.Add(this.return1);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.UpPass);
            this.Controls.Add(this.Namelabel1);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.accountlabel1);
            this.Name = "UpdateAc";
            this.Text = "账户信息";
            this.Load += new System.EventHandler(this.UpdateAc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountlabel1;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label Namelabel1;
        private System.Windows.Forms.Button UpPass;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Button return1;
        private System.Windows.Forms.Label Numberlabel1;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label levellabel1;
        private System.Windows.Forms.Label Level1;
        private System.Windows.Forms.Button ChangeNum1;
    }
}