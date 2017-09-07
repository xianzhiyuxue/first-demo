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
    public partial class 修改密码 : Form
    {
        public 修改密码()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connstr = ConfigurationSettings.AppSettings["Connstr"];
            //SqlConnection conn = new SqlConnection(connstr);
            //string sql = "select * from 用户信息 where 学号='" + textBox_sno00.Text + "'and 密码='" + textBox_oldpwd.Text + "'";
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    string sql1 = "uadate table 用户信息 set ";
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql1, conn);
            //    int i = cmd.ExecuteNonQuery();
            //    conn.Close();
            //    if (i > 0)
            //    {
            //        MessageBox.Show("修改成功！");

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("个人信息确认有误！");
            //}
        }
        public static string uname_changepwd =null;
        private void button1_Click_1(object sender, EventArgs e)
        {
            string connstr = ConfigurationSettings.AppSettings["Connstr"];
            SqlConnection conn = new SqlConnection(connstr);
            if(textBox_sname000.Text==Form1.user_login)
            {
                string sql = "select * from 用户信息 where 姓名='" + textBox_sname000.Text + "'and 密码='" + textBox_oldpwd.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    确认修改 f = new 确认修改();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("个人信息确认有误！");
                }
            }
            else
            {
                MessageBox.Show("提交用户名与当前登陆用户名不一致！");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void textBox_sno00_TextChanged(object sender, EventArgs e)
        {

        }

        private void 修改密码_Load(object sender, EventArgs e)
        {

        }
    }
}
