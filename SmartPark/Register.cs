using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartPark
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text.ToString();
            string gender = tb_gender.Text.ToString();
            string phone_num = tb_phone.Text.ToString();
            string email = tb_email.Text.ToString();
            string psd1 = tb_psd1.Text.ToString();
            string psd2 = tb_psd2.Text.ToString();
            if (name == null || name.Trim().Equals(""))
            {
                MessageBox.Show("姓名不能为空!");
            }
            else if (gender == null || gender.Trim().Equals(""))
            {
                MessageBox.Show("性别不能为空!");
            }
            else if (phone_num == null || phone_num.Trim().Equals(""))
            {
                MessageBox.Show("手机号码不能为空!");
            }
            else if (email == null || email.Trim().Equals(""))
            {
                MessageBox.Show("电子邮件不能为空!");
            }
            else if (psd1 == null || psd1.Trim().Equals("") || psd2 == null || psd2.Trim().Equals(""))
            {
                MessageBox.Show("密码不能为空!");
            }
            else if (!psd1.Equals(psd2))
            {
                MessageBox.Show("两次密码输入不一致!");
            }
            else
            {
                Database db = new Database();
                Dictionary<string, string> dic_param = new Dictionary<string, string>();
                dic_param.Add("name", name);
                dic_param.Add("gender", gender);
                dic_param.Add("phone_num", phone_num);
                dic_param.Add("psd1", psd1);

                if (db.requestServer(Database.ACTION_INSERT_PARK_OWNER, dic_param) == "succeed")
                {
                    DialogResult dr = MessageBox.Show("恭喜你注册成功", "提示");
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                        this.Dispose();
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("网络连接失败", "提示");
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                        this.Dispose();
                    }
                }

            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
