using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPark
{
    public partial class SeekStall : Form
    {
        private ListView lv;
        public SeekStall(ListView lv)
        {
            InitializeComponent();
            this.lv = lv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem foundItem = this.lv.FindItemWithText(this.textBox1.Text, false, 0);    //参数1：要查找的文本；参数2：是否子项也要查找；参数3：开始查找位置 

            if (foundItem != null)
            {
                this.lv.TopItem = foundItem;  //定位到该项 
                foundItem.ForeColor = Color.Red;
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("未找到该车位", "提示");
            }
        }
    }
}
