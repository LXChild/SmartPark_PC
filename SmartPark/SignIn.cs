using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace SmartPark
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void SignIn_Load(object sender, EventArgs e)
        {
            Loading.showLoadingDialog();
            Loading.hideLoadingDialog();
        }
        private void button_signin_Click(object sender, EventArgs e)
        {

            playMusic();
            //double loc_lon = 113.27752;
            //double loc_lat = 23.14347;
            //int distance = 500;
            //DataBase db = new DataBase();
            //db.queryPark(loc_lon, loc_lat, distance);

            string account = tb_account.Text.ToString();
            string password = tb_psd.Text.ToString();
            if (account == null || account.Trim().Equals(""))
            {
                MessageBox.Show("账号不能为空！");
            }
            else if (password == null || password.Trim().Equals(""))
            {
                MessageBox.Show("密码不能为空！");
            }
            else
            {
                Loading.showLoadingDialog();
                string result = verifySignIn(account, password);
                Loading.hideLoadingDialog();
                if (result != "网络连接异常，请检查网络配置！")
                {
                    if (result == "succeed")
                    {
                        Properties.Settings.Default.Save();
                        goToMainForm();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("登录失败，请检查帐号密码是否错误");
                    }
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void playMusic()
        {
            SoundPlayer player = new SoundPlayer();
            player.Stream = Properties.Resources.bgm;//只能播放.wav文件.
            player.LoadAsync();
            player.Play();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            goToRegister();
        }
        private string verifySignIn(string account, string password)
        {
            Database db = new Database();
            Dictionary<string, string> dic_param = new Dictionary<string, string>();
            dic_param.Add("phone_num", account);
            dic_param.Add("password", password);

            return db.requestServer(Database.ACTION_QUERY_PARK_OWNER, dic_param);
        }
        private void goToMainForm()
        {
            SmartPark mainform = new SmartPark(this);
            mainform.Show();
            mainform.Activate();
            Application.DoEvents();
        }
        private void goToRegister()
        {
            Register register = new Register();
            register.Show();
            register.Activate();
            Application.DoEvents();
        }
    }
}
