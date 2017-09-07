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
    public partial class 寝室长 : Form
    {
        public 寝室长()
        {
            InitializeComponent();
        }
        static string connstr = ConfigurationSettings.AppSettings["Connstr"];
        SqlConnection conn = new SqlConnection(connstr);

        private void comboBox_roomname_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        void ComboBox_roomname()
        {
            string sql = "select 姓名 from 住宿信息 where 宿舍编号=(select 宿舍编号 from 住宿信息 where 姓名 ='" + Form1.user_login + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                comboBox_roomname.DisplayMember = "姓名";
                comboBox_roomname.ValueMember = "姓名";
                comboBox_roomname.DataSource = ds.Tables[0];
            }
        }
        void ComboBox_roomno()
        {
            string sql = "select * from room_code";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                comboBox_roomno.DisplayMember = "宿舍编号";
                comboBox_roomno.ValueMember = "宿舍编号";
                comboBox_roomno.DataSource = ds.Tables[0];
            }
        }

        private void button_ok1_Click(object sender, EventArgs e)
        {
            string str;
            if (radioButton_yes1.Checked == true)
            {
                str = radioButton_yes1.Text;
            }
            else
            {
                str = radioButton_no1.Text;
            }
            string sql = "insert into 签到 (姓名,签到日期,签到时间,是否在校,寝室)values('" + comboBox_roomname.SelectedValue.ToString() + "','" + dateTimePicker1+ "','" + textBox_datetime0.Text + "','" + str + "','" + comboBox_roomno.SelectedValue.ToString() + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                     
                MessageBox.Show("提交信息成功！");
                room rm = new room();
                rm.roombind();
                @class cs = new @class();
                cs.classbind();                 
            }
        }

        private void 寝室长_Load(object sender, EventArgs e)
        {
            ComboBox_roomname();
            ComboBox_roomno();
        }
    }
}
