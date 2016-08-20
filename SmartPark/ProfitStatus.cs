using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartPark
{
    public partial class ProfitStatus : Form
    {
        public ProfitStatus()
        {
            InitializeComponent();
        }

        private void ProfitStatus_Load(object sender, EventArgs e)
        {

            initCarNumChart();
            //            useListView();
        }



        private void useListView()
        {
            //ColumnHeader ch1 = new ColumnHeader();
            //ch1.Text = "日期";   //设置列标题 
            //ch1.Width = 100;    //设置列宽度 
            //ch1.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式 

            //ColumnHeader ch2 = new ColumnHeader();
            //ch2.Text = "运营时长";   //设置列标题 
            //ch2.Width = 100;    //设置列宽度 
            //ch2.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式 

            //ColumnHeader ch3 = new ColumnHeader();
            //ch3.Text = "泊车数量";   //设置列标题 
            //ch3.Width = 100;    //设置列宽度 
            //ch3.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式 

            //ColumnHeader ch4 = new ColumnHeader();
            //ch4.Text = "盈利状况";   //设置列标题 
            //ch4.Width = 100;    //设置列宽度 
            //ch4.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式 

            //lv_profit.Columns.AddRange(new ColumnHeader[] { ch1, ch2, ch3, ch4 });//将这两列加入listView1

            //this.lv_profit.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度 
            //lv_profit.View = View.Details;//列的显示模式
            //for (int i = 1; i <= global::SmartPark.Properties.Settings.Default.Stall_total; i++)
            //{
            //    ListViewItem lvi = new ListViewItem();//创建列表项
            //    lvi.Text = "2015.06." + i;
            //    //   lvi.ForeColor = Color.Green;
            //    lvi.SubItems.Add("8:00:00");
            //    lvi.SubItems.Add("800");
            //    lvi.SubItems.Add("600元");
            //    //new string[] { i + "", "空", "1:00:00", "10元" };
            //    lv_profit.Items.Add(lvi);//将项加入listView1列表中
            //}
            //this.lv_profit.EndUpdate();  //结束数据处理，UI界面一次性绘制。 
        }

        private void tabControl_profitStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl_profitStatus.SelectedIndex == 0)
            {
                initCarNumChart();
            } else
            {
                initProfitChart();
            }
        }

        private void initCarNumChart()
        {
            string[] week = new string[7] { "日", "一", "二", "三", "四", "五", "六" };
            //  float[] d = new float[7] { 20.5f, 60, 10.8f, 15.6f, 30, 70.9f, 50.3f};
            int[] d = new int[7] { 62, 33, 57, 42, 36, 58, 72 };

            //画图初始化
            Bitmap bmap = new Bitmap(390, 370);
            Graphics gph = Graphics.FromImage(bmap);
            gph.Clear(Color.White);

            PointF cpt = new PointF(30, 340);//中心点
            PointF[] xpt = new PointF[3] { new PointF(cpt.Y + 10, cpt.Y), new PointF(cpt.Y, cpt.Y - 3), new PointF(cpt.Y, cpt.Y + 3) };//x轴三角形
            PointF[] ypt = new PointF[3] { new PointF(cpt.X, cpt.X - 10), new PointF(cpt.X - 3, cpt.X), new PointF(cpt.X + 3, cpt.X) };//y轴三角形

            //   gph.DrawString("某工厂某产品月生产量图表", new Font("宋体", 14), Brushes.Black, new PointF(cpt.X + 60, cpt.X));//图表标题

            //画x轴
            gph.DrawLine(Pens.Black, cpt.X, cpt.Y, cpt.Y, cpt.Y);
            gph.DrawPolygon(Pens.Black, xpt);
            gph.FillPolygon(new SolidBrush(Color.Black), xpt);
            gph.DrawString("星期", new Font("宋体", 10), Brushes.Black, new PointF(cpt.Y + 15, cpt.Y + 15));
            for (int i = 1; i <= week.Length; i++)
            {
                //画x轴项目
                gph.DrawString(week[i - 1].Substring(0, 1), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 40 - 5, cpt.Y + 5));
                //   gph.DrawString(month[i - 1].Substring(1, 1), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 30 - 5, cpt.Y + 20));

                //if (week[i - 1].Length > 2)
                //{
                //    gph.DrawString(week[i - 1].Substring(2, 1), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 30 - 5, cpt.Y + 35));
                //}

                //画点
                gph.DrawEllipse(Pens.Black, cpt.X + i * 40 - 1.5f, cpt.Y - d[i - 1] * 3 - 1.5f, 3, 3);
                gph.FillEllipse(new SolidBrush(Color.Black), cpt.X + i * 40 - 1.5f, cpt.Y - d[i - 1] * 3 - 1.5f, 3, 3);

                //画数值
                //画x轴刻度
                gph.DrawString(d[i - 1].ToString(), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 40, cpt.Y - d[i - 1] * 3));
                gph.DrawLine(Pens.Black, cpt.X + i * 40, cpt.Y - 3, cpt.X + i * 40, cpt.Y);

                //画折线
                if (i > 1)
                {
                    gph.DrawLine(Pens.Goldenrod, cpt.X + (i - 1) * 40, cpt.Y - d[i - 2] * 3, cpt.X + i * 40, cpt.Y - d[i - 1] * 3);
                }
            }

            //画y轴
            gph.DrawLine(Pens.Black, cpt.X, cpt.Y, cpt.X, cpt.X);
            gph.DrawPolygon(Pens.Black, ypt);
            gph.FillPolygon(new SolidBrush(Color.Black), ypt);
            gph.DrawString("单位(辆)", new Font("宋体", 10), Brushes.Black, new PointF(0, 0));
            for (int i = 1; i < 12; i++)
            {
                //画y轴刻度
                if (i < 11)
                {
                    gph.DrawString((i * 10).ToString(), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X - 30, cpt.Y - i * 30 - 6));
                    gph.DrawLine(Pens.Black, cpt.X - 3, cpt.Y - i * 30, cpt.X, cpt.Y - i * 30);
                }
            }

            //保存输出图片
            //bmap.Save(Response.OutputStream, ImageFormat.Gif);
            pictureBox_chart_carNum.Image = bmap;
        }

        private void initProfitChart()
        {
            string[] week = new string[7] { "日", "一", "二", "三", "四", "五", "六" };
            //  float[] d = new float[7] { 20.5f, 60, 10.8f, 15.6f, 30, 70.9f, 50.3f};
            int[] d = new int[7] { 81, 44, 78, 63, 57, 79, 91 };

            //画图初始化
            Bitmap bmap = new Bitmap(390, 370);
            Graphics gph = Graphics.FromImage(bmap);
            gph.Clear(Color.White);

            PointF cpt = new PointF(30, 340);//中心点
            PointF[] xpt = new PointF[3] { new PointF(cpt.Y + 10, cpt.Y), new PointF(cpt.Y, cpt.Y - 3), new PointF(cpt.Y, cpt.Y + 3) };//x轴三角形
            PointF[] ypt = new PointF[3] { new PointF(cpt.X, cpt.X - 10), new PointF(cpt.X - 3, cpt.X), new PointF(cpt.X + 3, cpt.X) };//y轴三角形

            //   gph.DrawString("某工厂某产品月生产量图表", new Font("宋体", 14), Brushes.Black, new PointF(cpt.X + 60, cpt.X));//图表标题

            //画x轴
            gph.DrawLine(Pens.Black, cpt.X, cpt.Y, cpt.Y, cpt.Y);
            gph.DrawPolygon(Pens.Black, xpt);
            gph.FillPolygon(new SolidBrush(Color.Black), xpt);
            gph.DrawString("星期", new Font("宋体", 10), Brushes.Black, new PointF(cpt.Y + 15, cpt.Y + 15));
            for (int i = 1; i <= week.Length; i++)
            {
                //画x轴项目
                gph.DrawString(week[i - 1].Substring(0, 1), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 40 - 5, cpt.Y + 5));
                //   gph.DrawString(month[i - 1].Substring(1, 1), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 30 - 5, cpt.Y + 20));

                //if (week[i - 1].Length > 2)
                //{
                //    gph.DrawString(week[i - 1].Substring(2, 1), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 30 - 5, cpt.Y + 35));
                //}

                //画点
                gph.DrawEllipse(Pens.Black, cpt.X + i * 40 - 1.5f, cpt.Y - d[i - 1] * 3 - 1.5f, 3, 3);
                gph.FillEllipse(new SolidBrush(Color.Black), cpt.X + i * 40 - 1.5f, cpt.Y - d[i - 1] * 3 - 1.5f, 3, 3);

                //画数值
                //画x轴刻度
                gph.DrawString(d[i - 1].ToString(), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 40, cpt.Y - d[i - 1] * 3));
                gph.DrawLine(Pens.Black, cpt.X + i * 40, cpt.Y - 3, cpt.X + i * 40, cpt.Y);

                //画折线
                if (i > 1)
                {
                    gph.DrawLine(Pens.Goldenrod, cpt.X + (i - 1) * 40, cpt.Y - d[i - 2] * 3, cpt.X + i * 40, cpt.Y - d[i - 1] * 3);
                }
            }

            //画y轴
            gph.DrawLine(Pens.Black, cpt.X, cpt.Y, cpt.X, cpt.X);
            gph.DrawPolygon(Pens.Black, ypt);
            gph.FillPolygon(new SolidBrush(Color.Black), ypt);
            gph.DrawString("单位(元)", new Font("宋体", 10), Brushes.Black, new PointF(0, 0));
            for (int i = 1; i < 12; i++)
            {
                //画y轴刻度
                if (i < 11)
                {
                    gph.DrawString((i * 10).ToString(), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X - 30, cpt.Y - i * 30 - 6));
                    gph.DrawLine(Pens.Black, cpt.X - 3, cpt.Y - i * 30, cpt.X, cpt.Y - i * 30);
                }
            }

            //保存输出图片
            //bmap.Save(Response.OutputStream, ImageFormat.Gif);
            pictureBox_chart_profit.Image = bmap;

        }
    }
}
