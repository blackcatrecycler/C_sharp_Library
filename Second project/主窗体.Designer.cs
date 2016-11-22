namespace Second_project
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Inquiry = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.LinkLabel();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchList = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.NameLink = new System.Windows.Forms.LinkLabel();
            this.Se1 = new System.Windows.Forms.RadioButton();
            this.Se2 = new System.Windows.Forms.RadioButton();
            this.Borrow = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.See1 = new System.Windows.Forms.Button();
            this.See2 = new System.Windows.Forms.Button();
            this.Se3 = new System.Windows.Forms.RadioButton();
            this.LevelUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(79, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(496, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(79, 379);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(109, 32);
            this.Add.TabIndex = 9;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.add_Click);
            // 
            // Inquiry
            // 
            this.Inquiry.AutoEllipsis = true;
            this.Inquiry.Location = new System.Drawing.Point(560, 55);
            this.Inquiry.Margin = new System.Windows.Forms.Padding(2);
            this.Inquiry.Name = "Inquiry";
            this.Inquiry.Size = new System.Drawing.Size(101, 35);
            this.Inquiry.TabIndex = 10;
            this.Inquiry.Text = "查询";
            this.Inquiry.UseVisualStyleBackColor = true;
            this.Inquiry.Click += new System.EventHandler(this.inquiry_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(201, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "欢迎使用图书馆系统";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(632, 9);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(29, 12);
            this.Login.TabIndex = 12;
            this.Login.TabStop = true;
            this.Login.Text = "登录";
            this.Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_LinkClicked);
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchText.Location = new System.Drawing.Point(173, 53);
            this.SearchText.Margin = new System.Windows.Forms.Padding(2);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(336, 35);
            this.SearchText.TabIndex = 13;
            // 
            // SearchList
            // 
            this.SearchList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchList.FormattingEnabled = true;
            this.SearchList.Items.AddRange(new object[] {
            "全部",
            "书名",
            "类型",
            "作者",
            "出版时间"});
            this.SearchList.Location = new System.Drawing.Point(79, 60);
            this.SearchList.Margin = new System.Windows.Forms.Padding(2);
            this.SearchList.Name = "SearchList";
            this.SearchList.Size = new System.Drawing.Size(90, 24);
            this.SearchList.TabIndex = 14;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(267, 380);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(109, 31);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.AllowDrop = true;
            this.Update.Location = new System.Drawing.Point(466, 380);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(109, 31);
            this.Update.TabIndex = 16;
            this.Update.Text = "修改";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Updata_Click);
            // 
            // NameLink
            // 
            this.NameLink.AutoSize = true;
            this.NameLink.LinkArea = new System.Windows.Forms.LinkArea(0, 8);
            this.NameLink.Location = new System.Drawing.Point(580, 9);
            this.NameLink.Name = "NameLink";
            this.NameLink.Size = new System.Drawing.Size(66, 19);
            this.NameLink.TabIndex = 17;
            this.NameLink.TabStop = true;
            this.NameLink.Text = "linkLabel1";
            this.NameLink.UseCompatibleTextRendering = true;
            this.NameLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NameLink_LinkClicked);
            // 
            // Se1
            // 
            this.Se1.AutoSize = true;
            this.Se1.Location = new System.Drawing.Point(167, 98);
            this.Se1.Name = "Se1";
            this.Se1.Size = new System.Drawing.Size(71, 16);
            this.Se1.TabIndex = 18;
            this.Se1.TabStop = true;
            this.Se1.Text = "书籍模式";
            this.Se1.UseVisualStyleBackColor = true;
            this.Se1.CheckedChanged += new System.EventHandler(this.Se1_CheckedChanged);
            // 
            // Se2
            // 
            this.Se2.AutoSize = true;
            this.Se2.Location = new System.Drawing.Point(418, 98);
            this.Se2.Name = "Se2";
            this.Se2.Size = new System.Drawing.Size(71, 16);
            this.Se2.TabIndex = 19;
            this.Se2.TabStop = true;
            this.Se2.Text = "我的借阅";
            this.Se2.UseVisualStyleBackColor = true;
            this.Se2.CheckedChanged += new System.EventHandler(this.Se2_CheckedChanged);
            // 
            // Borrow
            // 
            this.Borrow.Location = new System.Drawing.Point(598, 155);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(81, 29);
            this.Borrow.TabIndex = 20;
            this.Borrow.Text = "借阅";
            this.Borrow.UseVisualStyleBackColor = true;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(598, 269);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(81, 28);
            this.Return.TabIndex = 21;
            this.Return.Text = "还书";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // See1
            // 
            this.See1.Location = new System.Drawing.Point(600, 267);
            this.See1.Name = "See1";
            this.See1.Size = new System.Drawing.Size(79, 32);
            this.See1.TabIndex = 22;
            this.See1.Text = "借阅历史";
            this.See1.UseVisualStyleBackColor = true;
            this.See1.Click += new System.EventHandler(this.See1_Click);
            // 
            // See2
            // 
            this.See2.Location = new System.Drawing.Point(597, 155);
            this.See2.Name = "See2";
            this.See2.Size = new System.Drawing.Size(81, 28);
            this.See2.TabIndex = 23;
            this.See2.Text = "当前借阅";
            this.See2.UseVisualStyleBackColor = true;
            this.See2.Click += new System.EventHandler(this.See2_Click);
            // 
            // Se3
            // 
            this.Se3.AutoSize = true;
            this.Se3.Location = new System.Drawing.Point(281, 98);
            this.Se3.Name = "Se3";
            this.Se3.Size = new System.Drawing.Size(95, 16);
            this.Se3.TabIndex = 24;
            this.Se3.TabStop = true;
            this.Se3.Text = "账户管理模式";
            this.Se3.UseVisualStyleBackColor = true;
            this.Se3.CheckedChanged += new System.EventHandler(this.Se3_CheckedChanged);
            // 
            // LevelUp
            // 
            this.LevelUp.Location = new System.Drawing.Point(603, 210);
            this.LevelUp.Name = "LevelUp";
            this.LevelUp.Size = new System.Drawing.Size(74, 25);
            this.LevelUp.TabIndex = 25;
            this.LevelUp.Text = "升级/降级";
            this.LevelUp.UseVisualStyleBackColor = true;
            this.LevelUp.Click += new System.EventHandler(this.LevelUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 422);
            this.Controls.Add(this.LevelUp);
            this.Controls.Add(this.Se3);
            this.Controls.Add(this.See2);
            this.Controls.Add(this.See1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Borrow);
            this.Controls.Add(this.Se2);
            this.Controls.Add(this.Se1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.SearchList);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Inquiry);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameLink);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(707, 460);
            this.MinimumSize = new System.Drawing.Size(707, 451);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书馆系统制作by黑猫";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Inquiry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel Login;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ComboBox SearchList;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.LinkLabel NameLink;
        private System.Windows.Forms.RadioButton Se1;
        private System.Windows.Forms.RadioButton Se2;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button See1;
        private System.Windows.Forms.Button See2;
        private System.Windows.Forms.RadioButton Se3;
        private System.Windows.Forms.Button LevelUp;
    }
}

