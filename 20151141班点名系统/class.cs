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
    public partial class @class : Form
    {
        public @class()
        {
            InitializeComponent();
        }

        private void class_Load(object sender, EventArgs e)
        {
            classbind();
        }
        static string connstr = ConfigurationSettings.AppSettings["Connstr"];
        SqlConnection conn = new SqlConnection(connstr);
        public void classbind()
        {
            string sql = "select * from 签到";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView_class.DataSource = ds.Tables[0];
            }
        }
    }
}
