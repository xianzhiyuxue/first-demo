namespace _20151141班点名系统
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_room = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_datetime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_addinfo = new System.Windows.Forms.Button();
            this.radioButton_yes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主题设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更换主题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更多主题下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助文档ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.时间 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker_qiandao = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_qiandao = new System.Windows.Forms.DataGridView();
            this.linkLabel_room = new System.Windows.Forms.LinkLabel();
            this.linkLabel_class = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_username = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_qiandao)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.ForeColor = System.Drawing.Color.Black;
            this.label_name.Location = new System.Drawing.Point(33, 63);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(130, 24);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓    名：";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_name.Location = new System.Drawing.Point(174, 58);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(188, 35);
            this.textBox_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "寝    室：";
            // 
            // comboBox_room
            // 
            this.comboBox_room.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_room.FormattingEnabled = true;
            this.comboBox_room.Location = new System.Drawing.Point(174, 129);
            this.comboBox_room.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_room.Name = "comboBox_room";
            this.comboBox_room.Size = new System.Drawing.Size(157, 32);
            this.comboBox_room.TabIndex = 3;
            this.comboBox_room.SelectedIndexChanged += new System.EventHandler(this.comboBox_room_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "签到日期：";
            // 
            // textBox_datetime
            // 
            this.textBox_datetime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_datetime.Location = new System.Drawing.Point(174, 261);
            this.textBox_datetime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_datetime.Name = "textBox_datetime";
            this.textBox_datetime.Size = new System.Drawing.Size(188, 35);
            this.textBox_datetime.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "签到时间：";
            // 
            // button_addinfo
            // 
            this.button_addinfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_addinfo.ForeColor = System.Drawing.Color.Black;
            this.button_addinfo.Location = new System.Drawing.Point(174, 393);
            this.button_addinfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_addinfo.Name = "button_addinfo";
            this.button_addinfo.Size = new System.Drawing.Size(190, 46);
            this.button_addinfo.TabIndex = 18;
            this.button_addinfo.Text = "立即签到";
            this.button_addinfo.UseVisualStyleBackColor = true;
            this.button_addinfo.Click += new System.EventHandler(this.button_addinfo_Click);
            // 
            // radioButton_yes
            // 
            this.radioButton_yes.AutoSize = true;
            this.radioButton_yes.Checked = true;
            this.radioButton_yes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_yes.ForeColor = System.Drawing.Color.Black;
            this.radioButton_yes.Location = new System.Drawing.Point(0, 21);
            this.radioButton_yes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_yes.Name = "radioButton_yes";
            this.radioButton_yes.Size = new System.Drawing.Size(59, 28);
            this.radioButton_yes.TabIndex = 20;
            this.radioButton_yes.TabStop = true;
            this.radioButton_yes.Text = "是";
            this.radioButton_yes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "是否在校：";
            // 
            // radioButton_no
            // 
            this.radioButton_no.AutoSize = true;
            this.radioButton_no.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_no.ForeColor = System.Drawing.Color.Black;
            this.radioButton_no.Location = new System.Drawing.Point(72, 21);
            this.radioButton_no.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.Size = new System.Drawing.Size(59, 28);
            this.radioButton_no.TabIndex = 22;
            this.radioButton_no.Text = "否";
            this.radioButton_no.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息ToolStripMenuItem,
            this.主题设置ToolStripMenuItem,
            this.系统信息ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.关于我们ToolStripMenuItem,
            this.帮助文档ToolStripMenuItem,
            this.帮助文档ToolStripMenuItem1,
            this.退出系统EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1146, 34);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看个人信息ToolStripMenuItem,
            this.修改个人信息ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.个人信息ToolStripMenuItem.Text = "个人信息(&S)    ";
            this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.个人信息ToolStripMenuItem_Click);
            // 
            // 查看个人信息ToolStripMenuItem
            // 
            this.查看个人信息ToolStripMenuItem.Name = "查看个人信息ToolStripMenuItem";
            this.查看个人信息ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.查看个人信息ToolStripMenuItem.Text = "查看个人信息";
            // 
            // 修改个人信息ToolStripMenuItem
            // 
            this.修改个人信息ToolStripMenuItem.Name = "修改个人信息ToolStripMenuItem";
            this.修改个人信息ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.修改个人信息ToolStripMenuItem.Text = "修改个人信息";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 主题设置ToolStripMenuItem
            // 
            this.主题设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更换主题ToolStripMenuItem,
            this.更多主题下载ToolStripMenuItem});
            this.主题设置ToolStripMenuItem.Name = "主题设置ToolStripMenuItem";
            this.主题设置ToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.主题设置ToolStripMenuItem.Text = "  主题设置(&M)    ";
            // 
            // 更换主题ToolStripMenuItem
            // 
            this.更换主题ToolStripMenuItem.Name = "更换主题ToolStripMenuItem";
            this.更换主题ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.更换主题ToolStripMenuItem.Text = "更换主题";
            this.更换主题ToolStripMenuItem.Click += new System.EventHandler(this.更换主题ToolStripMenuItem_Click);
            // 
            // 更多主题下载ToolStripMenuItem
            // 
            this.更多主题下载ToolStripMenuItem.Name = "更多主题下载ToolStripMenuItem";
            this.更多主题下载ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.更多主题下载ToolStripMenuItem.Text = "更多主题下载";
            // 
            // 系统信息ToolStripMenuItem
            // 
            this.系统信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统介绍ToolStripMenuItem,
            this.系统功能ToolStripMenuItem});
            this.系统信息ToolStripMenuItem.Name = "系统信息ToolStripMenuItem";
            this.系统信息ToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.系统信息ToolStripMenuItem.Text = "   系统信息(&O)    ";
            this.系统信息ToolStripMenuItem.Click += new System.EventHandler(this.系统信息ToolStripMenuItem_Click);
            // 
            // 系统介绍ToolStripMenuItem
            // 
            this.系统介绍ToolStripMenuItem.Name = "系统介绍ToolStripMenuItem";
            this.系统介绍ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.系统介绍ToolStripMenuItem.Text = "系统介绍";
            // 
            // 系统功能ToolStripMenuItem
            // 
            this.系统功能ToolStripMenuItem.Name = "系统功能ToolStripMenuItem";
            this.系统功能ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.系统功能ToolStripMenuItem.Text = "系统功能";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 28);
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.关于我们ToolStripMenuItem.Text = "关于我们(&A)    ";
            this.关于我们ToolStripMenuItem.Click += new System.EventHandler(this.关于我们ToolStripMenuItem_Click_1);
            // 
            // 帮助文档ToolStripMenuItem
            // 
            this.帮助文档ToolStripMenuItem.Name = "帮助文档ToolStripMenuItem";
            this.帮助文档ToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.帮助文档ToolStripMenuItem.Text = " 常用工具(T)   ";
            this.帮助文档ToolStripMenuItem.Click += new System.EventHandler(this.帮助文档ToolStripMenuItem_Click);
            // 
            // 帮助文档ToolStripMenuItem1
            // 
            this.帮助文档ToolStripMenuItem1.Name = "帮助文档ToolStripMenuItem1";
            this.帮助文档ToolStripMenuItem1.Size = new System.Drawing.Size(130, 28);
            this.帮助文档ToolStripMenuItem1.Text = "  帮助文档(&H)";
            this.帮助文档ToolStripMenuItem1.Click += new System.EventHandler(this.帮助文档ToolStripMenuItem1_Click);
            // 
            // 退出系统EToolStripMenuItem
            // 
            this.退出系统EToolStripMenuItem.Name = "退出系统EToolStripMenuItem";
            this.退出系统EToolStripMenuItem.Size = new System.Drawing.Size(161, 28);
            this.退出系统EToolStripMenuItem.Text = "     退出系统(&E)    ";
            this.退出系统EToolStripMenuItem.Click += new System.EventHandler(this.退出系统EToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_yes);
            this.groupBox1.Controls.Add(this.radioButton_no);
            this.groupBox1.Location = new System.Drawing.Point(174, 309);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(159, 62);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.时间,
            this.toolStripStatus_user});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1146, 29);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // 时间
            // 
            this.时间.Name = "时间";
            this.时间.Size = new System.Drawing.Size(46, 24);
            this.时间.Text = "时间";
            this.时间.Click += new System.EventHandler(this.时间_Click);
            // 
            // toolStripStatus_user
            // 
            this.toolStripStatus_user.Name = "toolStripStatus_user";
            this.toolStripStatus_user.Size = new System.Drawing.Size(0, 24);
            this.toolStripStatus_user.Click += new System.EventHandler(this.toolStripStatusLabel1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker_qiandao
            // 
            this.dateTimePicker_qiandao.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker_qiandao.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker_qiandao.Location = new System.Drawing.Point(174, 192);
            this.dateTimePicker_qiandao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_qiandao.Name = "dateTimePicker_qiandao";
            this.dateTimePicker_qiandao.Size = new System.Drawing.Size(188, 31);
            this.dateTimePicker_qiandao.TabIndex = 28;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker_qiandao);
            this.groupBox2.Controls.Add(this.label_name);
            this.groupBox2.Controls.Add(this.textBox_name);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox_room);
            this.groupBox2.Controls.Add(this.button_addinfo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_datetime);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(18, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(423, 484);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加签到信息";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dataGridView_qiandao);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(450, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(678, 440);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "签到历史";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView_qiandao
            // 
            this.dataGridView_qiandao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_qiandao.Location = new System.Drawing.Point(10, 34);
            this.dataGridView_qiandao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_qiandao.Name = "dataGridView_qiandao";
            this.dataGridView_qiandao.RowTemplate.Height = 23;
            this.dataGridView_qiandao.Size = new System.Drawing.Size(658, 405);
            this.dataGridView_qiandao.TabIndex = 0;
            this.dataGridView_qiandao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // linkLabel_room
            // 
            this.linkLabel_room.AutoSize = true;
            this.linkLabel_room.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_room.Location = new System.Drawing.Point(456, 544);
            this.linkLabel_room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_room.Name = "linkLabel_room";
            this.linkLabel_room.Size = new System.Drawing.Size(154, 24);
            this.linkLabel_room.TabIndex = 31;
            this.linkLabel_room.TabStop = true;
            this.linkLabel_room.Text = "寝室签到信息";
            this.linkLabel_room.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_room_LinkClicked);
            // 
            // linkLabel_class
            // 
            this.linkLabel_class.AutoSize = true;
            this.linkLabel_class.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_class.Location = new System.Drawing.Point(646, 544);
            this.linkLabel_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_class.Name = "linkLabel_class";
            this.linkLabel_class.Size = new System.Drawing.Size(154, 24);
            this.linkLabel_class.TabIndex = 32;
            this.linkLabel_class.TabStop = true;
            this.linkLabel_class.Text = "班级签到信息";
            this.linkLabel_class.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_class_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(836, 544);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 24);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "寝室长功能";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.toolStripLabel_username,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1146, 27);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(406, 24);
            this.toolStripLabel4.Text = "                                                                        欢迎";
            // 
            // toolStripLabel_username
            // 
            this.toolStripLabel_username.Name = "toolStripLabel_username";
            this.toolStripLabel_username.Size = new System.Drawing.Size(64, 24);
            this.toolStripLabel_username.Text = "xx用户";
            this.toolStripLabel_username.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(100, 25);
            this.toolStripLabel5.Text = "使用本系统";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click_1);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 606);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel_class);
            this.Controls.Add(this.linkLabel_room);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "20151141班点名系统v1.0";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_qiandao)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_datetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_addinfo;
        private System.Windows.Forms.RadioButton radioButton_yes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主题设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更换主题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更多主题下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统介绍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统功能ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel 时间;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker_qiandao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_user;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_qiandao;
        private System.Windows.Forms.ToolStripMenuItem 帮助文档ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出系统EToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel_room;
        private System.Windows.Forms.LinkLabel linkLabel_class;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_username;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}