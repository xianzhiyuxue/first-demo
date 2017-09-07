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
    public partial class room : Form
    {
        public room()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        static string connstr = ConfigurationSettings.AppSettings["Connstr"];
        SqlConnection conn = new SqlConnection(connstr);
        public  void roombind()
        {
            string sql = "select * from 签到 where 寝室=(select 宿舍编号 from 住宿信息 where 姓名='" + Form1.user_login + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView_room.DataSource = ds.Tables[0];
            }
        }

        private void room_Load(object sender, EventArgs e)
        {
            roombind();
        }
    }
}
