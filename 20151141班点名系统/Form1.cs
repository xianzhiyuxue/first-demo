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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();   
        }
        static string connstr = ConfigurationSettings.AppSettings["Connstr"];
        SqlConnection conn = new SqlConnection(connstr);
        //FormClosedEventHandler
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string okma = "";
        private void label1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            okma=rd.Next(00000,99999).ToString();
            label1.Text = okma;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
           // string sql="select * from 用户信息"
           if(textBox_sname.Text!=" " && textBox_pwd.Text!=" ")
            {
                if(textBox_test.Text==label1.Text)
                {
                    string sql = "select * from 用户信息 where 姓名='" + textBox_sname.Text + "'and 密码='" + textBox_pwd.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string sql0 = "select * from 用户信息 where 姓名='" + textBox_sname.Text + "'and 密码='" + textBox_pwd.Text + "'and 类别='" + comboBox_code.SelectedValue + "'";
                        SqlDataAdapter da0 = new SqlDataAdapter(sql0, conn);
                        DataSet ds0 = new DataSet();
                        da0.Fill(ds0);
                        if (ds0.Tables[0].Rows.Count > 0)
                        {
                            user_login = textBox_sname.Text;
                            user_code = comboBox_code.SelectedValue.ToString();
                            MessageBox.Show("登录成功！");
                            Form2 f = new Form2();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("请选择正确类别！");
                        }
                    }
                    else
                    {
                        label1_Click(sender, e);
                        MessageBox.Show("用户名或密码错误！");
                    }
                }
                else
                {
                    label1_Click(sender, e);
                    MessageBox.Show("您输入的验证码有误！");
                }
            }
           else
            {
                label1_Click(sender, e);
                MessageBox.Show("您输入的信息不能为空!");
            }
        }
        public static string user_login = null;
        public static string user_code = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "office2007.ssk";
            Random rd = new Random();
            okma = rd.Next(00000, 99999).ToString();
            label1.Text = okma;
            string sql = "select * from usercode";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                comboBox_code.DisplayMember = "用户类别";
                comboBox_code.ValueMember = "用户类别";
                comboBox_code.DataSource = ds.Tables[0];
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label_sno_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_findpwd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("抱歉！由于服务器限制，暂未提供找回密码功能，若忘记密码请联系管理员！");
        }
    }
}
