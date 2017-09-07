namespace _20151141班点名系统
{
    partial class 寝室长
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
            this.groupBox_roomadd = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_roomname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_roomno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_datetime0 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_yes1 = new System.Windows.Forms.RadioButton();
            this.radioButton_no1 = new System.Windows.Forms.RadioButton();
            this.button_ok1 = new System.Windows.Forms.Button();
            this.groupBox_roomadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_roomadd
            // 
            this.groupBox_roomadd.Controls.Add(this.button_ok1);
            this.groupBox_roomadd.Controls.Add(this.groupBox1);
            this.groupBox_roomadd.Controls.Add(this.textBox_datetime0);
            this.groupBox_roomadd.Controls.Add(this.dateTimePicker1);
            this.groupBox_roomadd.Controls.Add(this.label5);
            this.groupBox_roomadd.Controls.Add(this.label4);
            this.groupBox_roomadd.Controls.Add(this.label3);
            this.groupBox_roomadd.Controls.Add(this.comboBox_roomno);
            this.groupBox_roomadd.Controls.Add(this.label2);
            this.groupBox_roomadd.Controls.Add(this.label1);
            this.groupBox_roomadd.Controls.Add(this.comboBox_roomname);
            this.groupBox_roomadd.Controls.Add(this.dataGridView1);
            this.groupBox_roomadd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_roomadd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_roomadd.ForeColor = System.Drawing.Color.Blue;
            this.groupBox_roomadd.Location = new System.Drawing.Point(0, 0);
            this.groupBox_roomadd.Name = "groupBox_roomadd";
            this.groupBox_roomadd.Size = new System.Drawing.Size(382, 348);
            this.groupBox_roomadd.TabIndex = 0;
            this.groupBox_roomadd.TabStop = false;
            this.groupBox_roomadd.Text = "寝室成员签到";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(376, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox_roomname
            // 
            this.comboBox_roomname.FormattingEnabled = true;
            this.comboBox_roomname.Location = new System.Drawing.Point(167, 60);
            this.comboBox_roomname.Name = "comboBox_roomname";
            this.comboBox_roomname.Size = new System.Drawing.Size(138, 24);
            this.comboBox_roomname.TabIndex = 1;
            this.comboBox_roomname.SelectedIndexChanged += new System.EventHandler(this.comboBox_roomname_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "寝室成员：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "寝 室 号：";
            // 
            // comboBox_roomno
            // 
            this.comboBox_roomno.FormattingEnabled = true;
            this.comboBox_roomno.Location = new System.Drawing.Point(167, 108);
            this.comboBox_roomno.Name = "comboBox_roomno";
            this.comboBox_roomno.Size = new System.Drawing.Size(91, 24);
            this.comboBox_roomno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "签到日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "签到时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "是否在校：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox_datetime0
            // 
            this.textBox_datetime0.Location = new System.Drawing.Point(167, 192);
            this.textBox_datetime0.Name = "textBox_datetime0";
            this.textBox_datetime0.Size = new System.Drawing.Size(91, 26);
            this.textBox_datetime0.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_no1);
            this.groupBox1.Controls.Add(this.radioButton_yes1);
            this.groupBox1.Location = new System.Drawing.Point(167, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 42);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_yes1
            // 
            this.radioButton_yes1.AutoSize = true;
            this.radioButton_yes1.Checked = true;
            this.radioButton_yes1.Location = new System.Drawing.Point(6, 19);
            this.radioButton_yes1.Name = "radioButton_yes1";
            this.radioButton_yes1.Size = new System.Drawing.Size(42, 20);
            this.radioButton_yes1.TabIndex = 0;
            this.radioButton_yes1.TabStop = true;
            this.radioButton_yes1.Text = "是";
            this.radioButton_yes1.UseVisualStyleBackColor = true;
            // 
            // radioButton_no1
            // 
            this.radioButton_no1.AutoSize = true;
            this.radioButton_no1.Location = new System.Drawing.Point(48, 19);
            this.radioButton_no1.Name = "radioButton_no1";
            this.radioButton_no1.Size = new System.Drawing.Size(42, 20);
            this.radioButton_no1.TabIndex = 1;
            this.radioButton_no1.Text = "否";
            this.radioButton_no1.UseVisualStyleBackColor = true;
            // 
            // button_ok1
            // 
            this.button_ok1.Location = new System.Drawing.Point(167, 289);
            this.button_ok1.Name = "button_ok1";
            this.button_ok1.Size = new System.Drawing.Size(101, 33);
            this.button_ok1.TabIndex = 11;
            this.button_ok1.Text = "确认提交";
            this.button_ok1.UseVisualStyleBackColor = true;
            this.button_ok1.Click += new System.EventHandler(this.button_ok1_Click);
            // 
            // 寝室长
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 348);
            this.Controls.Add(this.groupBox_roomadd);
            this.MaximizeBox = false;
            this.Name = "寝室长";
            this.Text = "寝室长";
            this.Load += new System.EventHandler(this.寝室长_Load);
            this.groupBox_roomadd.ResumeLayout(false);
            this.groupBox_roomadd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_roomadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_roomno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_roomname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_no1;
        private System.Windows.Forms.RadioButton radioButton_yes1;
        private System.Windows.Forms.TextBox textBox_datetime0;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_ok1;
    }
}