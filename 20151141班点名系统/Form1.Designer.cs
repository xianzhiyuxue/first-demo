namespace _20151141班点名系统
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_findpwd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_code = new System.Windows.Forms.ComboBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_test = new System.Windows.Forms.TextBox();
            this.label_test = new System.Windows.Forms.Label();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.label_pwd = new System.Windows.Forms.Label();
            this.textBox_sname = new System.Windows.Forms.TextBox();
            this.label_sname = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.button_findpwd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_code);
            this.groupBox1.Controls.Add(this.button_login);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_test);
            this.groupBox1.Controls.Add(this.label_test);
            this.groupBox1.Controls.Add(this.textBox_pwd);
            this.groupBox1.Controls.Add(this.label_pwd);
            this.groupBox1.Controls.Add(this.textBox_sname);
            this.groupBox1.Controls.Add(this.label_sname);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_findpwd
            // 
            this.button_findpwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_findpwd.ForeColor = System.Drawing.Color.Black;
            this.button_findpwd.Location = new System.Drawing.Point(236, 241);
            this.button_findpwd.Name = "button_findpwd";
            this.button_findpwd.Size = new System.Drawing.Size(103, 37);
            this.button_findpwd.TabIndex = 10;
            this.button_findpwd.TabStop = false;
            this.button_findpwd.Text = "忘记密码";
            this.button_findpwd.UseVisualStyleBackColor = true;
            this.button_findpwd.Click += new System.EventHandler(this.button_findpwd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "类  别：";
            // 
            // comboBox_code
            // 
            this.comboBox_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_code.FormattingEnabled = true;
            this.comboBox_code.Location = new System.Drawing.Point(147, 148);
            this.comboBox_code.Name = "comboBox_code";
            this.comboBox_code.Size = new System.Drawing.Size(166, 24);
            this.comboBox_code.TabIndex = 8;
            this.comboBox_code.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_login.ForeColor = System.Drawing.Color.Black;
            this.button_login.Location = new System.Drawing.Point(109, 241);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(103, 37);
            this.button_login.TabIndex = 7;
            this.button_login.TabStop = false;
            this.button_login.Text = "确定登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(236, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_test
            // 
            this.textBox_test.Location = new System.Drawing.Point(147, 192);
            this.textBox_test.Name = "textBox_test";
            this.textBox_test.Size = new System.Drawing.Size(83, 26);
            this.textBox_test.TabIndex = 5;
            // 
            // label_test
            // 
            this.label_test.AutoSize = true;
            this.label_test.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_test.ForeColor = System.Drawing.Color.Black;
            this.label_test.Location = new System.Drawing.Point(64, 196);
            this.label_test.Name = "label_test";
            this.label_test.Size = new System.Drawing.Size(76, 16);
            this.label_test.TabIndex = 4;
            this.label_test.Text = "验证码：";
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(147, 94);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.Size = new System.Drawing.Size(166, 26);
            this.textBox_pwd.TabIndex = 3;
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_pwd.ForeColor = System.Drawing.Color.Black;
            this.label_pwd.Location = new System.Drawing.Point(64, 97);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(77, 16);
            this.label_pwd.TabIndex = 2;
            this.label_pwd.Text = "密  码：";
            this.label_pwd.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_sname
            // 
            this.textBox_sname.Location = new System.Drawing.Point(147, 46);
            this.textBox_sname.Name = "textBox_sname";
            this.textBox_sname.Size = new System.Drawing.Size(166, 26);
            this.textBox_sname.TabIndex = 1;
            // 
            // label_sname
            // 
            this.label_sname.AutoSize = true;
            this.label_sname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sname.ForeColor = System.Drawing.Color.Black;
            this.label_sname.Location = new System.Drawing.Point(64, 49);
            this.label_sname.Name = "label_sname";
            this.label_sname.Size = new System.Drawing.Size(76, 16);
            this.label_sname.TabIndex = 0;
            this.label_sname.Text = "用户名：";
            this.label_sname.Click += new System.EventHandler(this.label_sno_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 323);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "20151141班点名系统v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_test;
        private System.Windows.Forms.Label label_test;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.TextBox textBox_sname;
        private System.Windows.Forms.Label label_sname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.ComboBox comboBox_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_findpwd;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

