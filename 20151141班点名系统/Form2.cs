using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace _20151141班点名系统
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_room_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        static string connstr = ConfigurationSettings.AppSettings["Connstr"];
        SqlConnection conn = new SqlConnection(connstr);

        private void Form2_Load(object sender, EventArgs e)
        {
            this.时间.Text = "系统时间：" + DateTime.Now.ToString();
            string sql = "select * from room_code";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                comboBox_room.DisplayMember = "宿舍编号";
                comboBox_room.ValueMember = "宿舍编号";
                comboBox_room.DataSource = ds.Tables[0];
            }
            qiandaobind(Form1.user_login,Form1.user_code);
            toolStripLabel_username.Text = Form1.user_login;
           
        }
        void qiandaobind(string username,string usercode)
        {
            string sql = null;
            string sql1 = "select * from 签到";
            string sql2 = "select * from 签到 where 寝室=(select 宿舍编号 from 住宿信息 where 姓名='" + username + "')";
            string sql3 = "select * from 签到 where 姓名='" + username + "'";
            if (usercode == "管理员")
            {
                sql = sql1;
            }
            else if(usercode == "寝室长")
            {
                sql = sql2;
            }
            else
            {
                sql = sql3;
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView_qiandao.DataSource = ds.Tables[0];
            }
        }
       
        //private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("你确定要关闭吗！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //    if (result == DialogResult.OK)
        //    {
        //        e.Cancel = false;  //点击OK
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
     
        private void button_addinfo_Click(object sender, EventArgs e)
        {
            string str;
            if (radioButton_yes.Checked == true)
            {
                str = radioButton_yes.Text;
            }
            else
            {
                str = radioButton_no.Text;
            }
            string sql = "insert into 签到 (姓名,签到日期,签到时间,是否在校,寝室)values('" + textBox_name.Text + "','" + dateTimePicker_qiandao.Value.ToString() + "','" + textBox_datetime.Text + "','" + str + "','" + comboBox_room.SelectedValue.ToString() + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                if (textBox_name.Text == Form1.user_login)
                {
                    MessageBox.Show("提交信息成功！");
                    qiandaobind(Form1.user_login,Form1.user_code);
                }
                else
                {
                    MessageBox.Show("提交姓名与当前登录用户名不一致，请重新填写！");
                }
                  

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            时间.Text = "系统时间：" + DateTime.Now.ToString("HH:mm:ss");
        }

        private void 帮助文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 系统信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改密码 f = new 修改密码();
            f.Show();
        }

        private void 关于我们ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void 时间_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            toolStripStatus_user.Text = Form1.user_login.ToString();
        }

        private void toolStripStatusLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            statusStrip1.Text = Form1.user_login;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //qiandaobind(Form1.user_login, Form1.user_code);
        }

        private void 更换主题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // skin f = new skin();
            //f.Show();
        }

        private void 帮助文档ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            帮助文档 bz = new 帮助文档();
            bz.ShowDialog();
        }

        private void 退出系统EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXIT f = new EXIT();
            f.Show();
        }

        private void linkLabel_room_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Form1.user_code == "普通用户")
                MessageBox.Show("您没有权限查看此信息！");
            else
            {
                room rm = new room();
                rm.Show();
            }
        }

        private void linkLabel_class_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                @class cs = new @class();
                cs.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = "select 姓名 from 用户信息 where 类别='寝室长' and 姓名='" + Form1.user_login + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count>0)
            {
                寝室长 qs = new 寝室长();
                qs.Show();
            }
            else
            {
                MessageBox.Show("您没有权限进行该操作！");
            }
        }

      

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            toolStripLabel_username.Text = Form1.user_login;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
