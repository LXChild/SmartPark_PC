using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartPark
{
    public partial class Settings_park : Form
    {
        private SmartPark mainForm;

        public Settings_park(SmartPark mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text.ToString();
            int stall = Convert.ToInt32(tb_stall.Text.ToString());
            string address = tb_address.Text.ToString();
            double loc_lon = Convert.ToDouble(tb_lon.Text.ToString());
            double loc_lat = Convert.ToDouble(tb_lat.Text.ToString());
            string price_type = rb_jishi.Checked == true ? "计时" : "计次";
            string type1_name = tb_beizhu1.Text.ToString();
            string type2_name = tb_beizhu2.Text.ToString();
            string type1_price = tb_jiage1.Text.ToString();
            string type2_price = tb_jiage2.Text.ToString();

            Database db = new Database();
            string phone_num = Properties.Settings.Default.Account;
            string password = Properties.Settings.Default.Password;
            Dictionary<string, string> dic_param = new Dictionary<string, string>();
            dic_param.Add("phone_num", phone_num);
            dic_param.Add("password", password);
            dic_param.Add("parkname", name);
            dic_param.Add("stall_total", stall.ToString());
            dic_param.Add("address", address);
            dic_param.Add("loc_lon", loc_lon.ToString());
            dic_param.Add("loc_lat", loc_lat.ToString());
            dic_param.Add("price_type", price_type);
            dic_param.Add("type1_name", type1_name);
            dic_param.Add("type2_name", type2_name);
            dic_param.Add("type1_price", type1_price);
            dic_param.Add("type2_price", type2_price);

            string result = db.requestServer(Database.ACTION_INSERT_PARK_INFO, dic_param);
          //  Console.WriteLine(result);

            if (result != "failed")
            {
                Console.WriteLine(result);
                string[] result_arr = result.Split(new char[] { ',' });
                Properties.Settings.Default.IsFirstIn = false;
                Properties.Settings.Default.Park_id = result_arr[0];
                Properties.Settings.Default.Owner_id = result_arr[1];
                Properties.Settings.Default.Owner = result_arr[2];

                Properties.Settings.Default.Save();
                DialogResult dr = MessageBox.Show("信息上传成功");
                if (dr == DialogResult.OK)
                {
                    this.Close();
                    this.Dispose();
                    mainForm.Show();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("网络连接失败");
                if (dr == DialogResult.OK)
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            //创建浏览文件对话框的实例
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //获取文件的全路径
                Console.WriteLine(ofd.FileName);

                Console.WriteLine(Database.HttpUploadFile(ofd.FileName));

            }
        }

        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.IsFirstIn)
                { 
                    Application.Exit();
                }
            } 
            catch (Exception en)
            {
              //  Console.WriteLine(en.ToString());
            }
        }

    }
}
