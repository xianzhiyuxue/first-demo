using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20151141班点名系统
{
    public partial class skin : Form
    {
        public skin()
        {
            InitializeComponent();
            //this.skinEngine1.SkinAllForm = true;
            //this.skinEngine1.SkinFile = comboBox_skin.Text;
            //this.skinEngine1.SkinFile = "SteelBlack.ssk";
        }
        
        private void skin_Load(object sender, EventArgs e)
        {
            //this.skinEngine1.SkinFile = comboBox_skin.Text;

        }
        public static string text_skin = null;
        private void button1_Click(object sender, EventArgs e)
        {
            //text_skin = comboBox_skin.Text;
            //皮肤 pf = new 皮肤();
            //pf.ShowDialog();
           // skinEngine1.SkinFile = System.Environment.CurrentDirectory +"\\"+ comboBox_skin.Text;
            //MessageBox.Show("更换成功！");
            //comboBox_skin_SelectedIndexChanged(sender, e);
        }

        public void comboBox_skin_SelectedIndexChanged(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = System.Environment.CurrentDirectory +"\\"+ comboBox_skin.Text;
        }
    }
}
