namespace Second_project
{
    partial class LoginWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWin));
            this.LoginButton = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Registered = new System.Windows.Forms.LinkLabel();
            this.forgot = new System.Windows.Forms.LinkLabel();
            this.form2_1 = new System.Windows.Forms.Label();
            this.form2_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(82, 167);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(149, 42);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(73, 95);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(166, 21);
            this.account.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(73, 127);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(166, 21);
            this.password.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Registered
            // 
            this.Registered.AutoSize = true;
            this.Registered.Location = new System.Drawing.Point(250, 98);
            this.Registered.Name = "Registered";
            this.Registered.Size = new System.Drawing.Size(29, 12);
            this.Registered.TabIndex = 4;
            this.Registered.TabStop = true;
            this.Registered.Text = "注册";
            this.Registered.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registered_LinkClicked);
            // 
            // forgot
            // 
            this.forgot.AutoSize = true;
            this.forgot.Location = new System.Drawing.Point(250, 130);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(53, 12);
            this.forgot.TabIndex = 5;
            this.forgot.TabStop = true;
            this.forgot.Text = "忘记密码";
            this.forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_LinkClicked);
            // 
            // form2_1
            // 
            this.form2_1.AutoSize = true;
            this.form2_1.Location = new System.Drawing.Point(20, 98);
            this.form2_1.Name = "form2_1";
            this.form2_1.Size = new System.Drawing.Size(47, 12);
            this.form2_1.TabIndex = 6;
            this.form2_1.Text = "用户名:";
            // 
            // form2_2
            // 
            this.form2_2.AutoSize = true;
            this.form2_2.Location = new System.Drawing.Point(32, 130);
            this.form2_2.Name = "form2_2";
            this.form2_2.Size = new System.Drawing.Size(35, 12);
            this.form2_2.TabIndex = 7;
            this.form2_2.Text = "密码:";
            // 
            // LoginWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 222);
            this.Controls.Add(this.form2_2);
            this.Controls.Add(this.form2_1);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.Registered);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.Controls.Add(this.LoginButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximumSize = new System.Drawing.Size(331, 260);
            this.MinimumSize = new System.Drawing.Size(331, 260);
            this.Name = "LoginWin";
            this.Text = "请登录";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Registered;
        private System.Windows.Forms.LinkLabel forgot;
        private System.Windows.Forms.Label form2_1;
        private System.Windows.Forms.Label form2_2;
    }
}