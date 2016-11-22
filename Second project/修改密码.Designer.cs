namespace Second_project
{
    partial class UpdataPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sure = new System.Windows.Forms.Button();
            this.OldPassword = new System.Windows.Forms.TextBox();
            this.NewPassword1 = new System.Windows.Forms.TextBox();
            this.NewPassword2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "请再输一次新密码:";
            // 
            // Sure
            // 
            this.Sure.Location = new System.Drawing.Point(72, 113);
            this.Sure.Name = "Sure";
            this.Sure.Size = new System.Drawing.Size(95, 30);
            this.Sure.TabIndex = 3;
            this.Sure.Text = "确认";
            this.Sure.UseVisualStyleBackColor = true;
            this.Sure.Click += new System.EventHandler(this.Sure_Click);
            // 
            // OldPassword
            // 
            this.OldPassword.Location = new System.Drawing.Point(145, 12);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.PasswordChar = '*';
            this.OldPassword.Size = new System.Drawing.Size(161, 21);
            this.OldPassword.TabIndex = 4;
            // 
            // NewPassword1
            // 
            this.NewPassword1.Location = new System.Drawing.Point(145, 48);
            this.NewPassword1.Name = "NewPassword1";
            this.NewPassword1.PasswordChar = '*';
            this.NewPassword1.Size = new System.Drawing.Size(161, 21);
            this.NewPassword1.TabIndex = 5;
            // 
            // NewPassword2
            // 
            this.NewPassword2.Location = new System.Drawing.Point(145, 84);
            this.NewPassword2.Name = "NewPassword2";
            this.NewPassword2.PasswordChar = '*';
            this.NewPassword2.Size = new System.Drawing.Size(161, 21);
            this.NewPassword2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdataPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 153);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NewPassword2);
            this.Controls.Add(this.NewPassword1);
            this.Controls.Add(this.OldPassword);
            this.Controls.Add(this.Sure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdataPassword";
            this.Text = "请修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sure;
        private System.Windows.Forms.TextBox OldPassword;
        private System.Windows.Forms.TextBox NewPassword1;
        private System.Windows.Forms.TextBox NewPassword2;
        private System.Windows.Forms.Button button2;
    }
}