namespace _20151141班点名系统
{
    partial class 确认修改
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
            this.textBox_newpwd01 = new System.Windows.Forms.TextBox();
            this.textBox_newpwd02 = new System.Windows.Forms.TextBox();
            this.button_确认修改 = new System.Windows.Forms.Button();
            this.button_取消 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "新 密 码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(64, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "确认密码：";
            // 
            // textBox_newpwd01
            // 
            this.textBox_newpwd01.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_newpwd01.Location = new System.Drawing.Point(158, 45);
            this.textBox_newpwd01.Name = "textBox_newpwd01";
            this.textBox_newpwd01.Size = new System.Drawing.Size(149, 26);
            this.textBox_newpwd01.TabIndex = 2;
            // 
            // textBox_newpwd02
            // 
            this.textBox_newpwd02.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_newpwd02.Location = new System.Drawing.Point(158, 95);
            this.textBox_newpwd02.Name = "textBox_newpwd02";
            this.textBox_newpwd02.Size = new System.Drawing.Size(149, 26);
            this.textBox_newpwd02.TabIndex = 3;
            // 
            // button_确认修改
            // 
            this.button_确认修改.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_确认修改.Location = new System.Drawing.Point(114, 147);
            this.button_确认修改.Name = "button_确认修改";
            this.button_确认修改.Size = new System.Drawing.Size(80, 32);
            this.button_确认修改.TabIndex = 4;
            this.button_确认修改.Text = "确认";
            this.button_确认修改.UseVisualStyleBackColor = true;
            this.button_确认修改.Click += new System.EventHandler(this.button_确认修改_Click);
            // 
            // button_取消
            // 
            this.button_取消.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_取消.Location = new System.Drawing.Point(244, 147);
            this.button_取消.Name = "button_取消";
            this.button_取消.Size = new System.Drawing.Size(83, 32);
            this.button_取消.TabIndex = 5;
            this.button_取消.Text = "取消";
            this.button_取消.UseVisualStyleBackColor = true;
            this.button_取消.Click += new System.EventHandler(this.button_取消_Click);
            // 
            // 确认修改
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 220);
            this.Controls.Add(this.button_取消);
            this.Controls.Add(this.button_确认修改);
            this.Controls.Add(this.textBox_newpwd02);
            this.Controls.Add(this.textBox_newpwd01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "确认修改";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "确认修改";
            this.Load += new System.EventHandler(this.确认修改_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_newpwd01;
        private System.Windows.Forms.TextBox textBox_newpwd02;
        private System.Windows.Forms.Button button_确认修改;
        private System.Windows.Forms.Button button_取消;
    }
}