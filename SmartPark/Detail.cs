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
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        //private void InitView()
        //{
        //    ColumnHeader ch1 = new ColumnHeader();
        //    ch1.Text = "车位编号";   //设置列标题 
        //    ch1.Width = 100;    //设置列宽度 
        //    ch1.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式 

        //    ColumnHeader ch2 = new ColumnHeader();
        //    ch2.Text = "车位状态";   //设置列标题 
        //    ch2.Width = 100;    //设置列宽度 
        //    ch2.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式 

        //    ColumnHeader ch3 = new ColumnHeader();
        //    ch3.Text = "停车时长";   //设置列标题 
        //    ch3.Width = 100;    //设置列宽度 
        //    ch3.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式 

        //    ColumnHeader ch4 = new ColumnHeader();
        //    ch4.Text = "缴费金额";   //设置列标题 
        //    ch4.Width = 100;    //设置列宽度 
        //    ch4.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式 

        //    lv_stallInfo.Columns.AddRange(new ColumnHeader[] { ch1, ch2, ch3, ch4 });//将这两列加入listView1

        //    this.lv_stallInfo.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度 
        //    lv_stallInfo.View = View.Details;//列的显示模式
        //    for (int i = 0; i < global::SmartPark.Properties.Settings.Default.Stall_total; i++)
        //    {
        //        ListViewItem lvi = new ListViewItem();//创建列表项
        //        lvi.Text = i + 1 + "";
        //        //   lvi.ForeColor = Color.Green;
        //        lvi.SubItems.Add("空");
        //        lvi.SubItems.Add("00:00:00");
        //        lvi.SubItems.Add("0元");
        //        lv_stallInfo.Items.Add(lvi);//将项加入listView1列表中
        //    }
        //    this.lv_stallInfo.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        //}

        //private void refrashStallList(string info)
        //{
        //    //判断该方法是否被主线程调用，也就是创建labMessage1控件的线程，当控件的InvokeRequired属性为ture时，说明是被主线程以外的线程调用。如果不加判断，会造成异常  
        //    if (this.lv_stallInfo.InvokeRequired)
        //    {
        //        //再次创建一个DelegateUpdateUI类的对象  
        //        DelegateUpdateUI updateUI = new DelegateUpdateUI();
        //        //为新对象的mainThread对象搭载方法  
        //        updateUI.mainThread = new DelegateUpdateUI.updateDelegate(refrashStallList);
        //        //this指窗体，在这调用窗体的Invoke方法，也就是用窗体的创建线程来执行mainThread对象委托的方法，再加上需要的参数(i)  
        //        this.Invoke(updateUI.mainThread, new object[] { info });
        //    }
        //    else
        //    {
        //        if (info != null)
        //        {
        //            this.richTextBox1.Text += info + "";

        //            this.lv_stallInfo.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度 
        //            switch (info)
        //            {
        //                case "1":
        //                    lv_stallInfo.Items[Convert.ToInt16(0)].SubItems[1].Text = "无";
        //                    break;
        //                case "2":
        //                    lv_stallInfo.Items[Convert.ToInt16(1)].SubItems[1].Text = "无";
        //                    break;
        //                case "3":
        //                    lv_stallInfo.Items[Convert.ToInt16(2)].SubItems[1].Text = "无";
        //                    break;
        //                case "A":
        //                    lv_stallInfo.Items[Convert.ToInt16(0)].SubItems[1].Text = "有";
        //                    break;
        //                case "B":
        //                    lv_stallInfo.Items[Convert.ToInt16(1)].SubItems[1].Text = "有";
        //                    break;
        //                case "C":
        //                    lv_stallInfo.Items[Convert.ToInt16(2)].SubItems[1].Text = "有";
        //                    break;
        //            }
        //            this.lv_stallInfo.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        //        }
        //    }
        //}
    }
}
