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
    public partial class 确认修改 : Form
    {
        public 确认修改()
        {
            InitializeComponent();
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //public 修改密码 f;
        private void button_确认修改_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationSettings.AppSettings["Connstr"];
            SqlConnection conn = new SqlConnection(connstr);
            if (textBox_newpwd01.Text==textBox_newpwd02.Text)
            {
                string sql1 = "update 用户信息 set 密码='"+textBox_newpwd01.Text+"' where 姓名='"+Form1.user_login+"'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql1, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("两次密码输入不一致！");
            }
        }

        private void 确认修改_Load(object sender, EventArgs e)
        {

        }
    }
}
