using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace SmartPark
{
    public partial class SmartPark : Form
    {
        private SignIn signin;

        private DelegateUpdateUI updateDelegate;

        public SmartPark(SignIn signin)
        {
            InitializeComponent();
            this.signin = signin;
        }

        private void SmartPark_Load(object sender, EventArgs e)
        {
              isFirstIn();
              InitView();
              createDelegate();
            timer1.Enabled = true;
        }
        private void MenuItem_Run_Click(object sender, EventArgs e)
        {
            run();
        }
        private void MenuItem_Stop_Click(object sender, EventArgs e)
        {
            stop();
        }
        private void MenuItem_serialport_Click(object sender, EventArgs e)
        {
            goToSettingsSerialPort();
        }
        private void MenuItem_park_Click(object sender, EventArgs e)
        {
            goToSettingsPark();
        }
        private void MenuItem_stall_Click(object sender, EventArgs e)
        {
            goToSettingsStall();
        }
        private void MenuItem_SeekStall_Click(object sender, EventArgs e)
        {
            //SeekStall seekStall = new SeekStall(lv_stallInfo);
            //seekStall.Show();
            //seekStall.Activate();
            //Application.DoEvents();
        }
        private void MenuItem_camera_Click(object sender, EventArgs e)
        {
            goToCamera();
        }
        private void MenuItem_Help_Click(object sender, EventArgs e)
        {
            goToHelpWindow();
        }
        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
            about.Activate();
            Application.DoEvents();
        }
        private void MenuItem_Profit_Click(object sender, EventArgs e)
        {
            ProfitStatus profit = new ProfitStatus();
            profit.Show();
            profit.Activate();
            Application.DoEvents();
        }
        private void tsb_run_Click(object sender, EventArgs e)
        {
            run();
        }
        private void tsb_stop_click(object sender, EventArgs e)
        {
            stop();
        }
        private void tsb_settings_Click(object sender, EventArgs e)
        {
            goToSettingsSerialPort();
        }
        private void tsb_help_Click(object sender, EventArgs e)
        {
            goToHelpWindow();
        }
        private void ts_run_Click(object sender, EventArgs e)
        {
            run();
        }
        private void ts_stop_Click(object sender, EventArgs e)
        {
            stop();
        }
        private void ts_settings_Click(object sender, EventArgs e)
        {
            goToSettingsSerialPort();
        }
        private void ts_help_Click(object sender, EventArgs e)
        {
            goToHelpWindow();
        }
        private void isFirstIn()
        {
            Console.WriteLine(Properties.Settings.Default.IsFirstIn);
            if (Properties.Settings.Default.IsFirstIn)
            {
                this.Hide();
                goToSettingsPark();
            }
        }
        private void initSerialPort()
        {
            //如果有配置 则读取配置文件
            serialPort1.PortName = Properties.Settings.Default.SerialPort_num;
            serialPort1.BaudRate = Properties.Settings.Default.SerialPort_baudRate;
            switch (Properties.Settings.Default.SerialPort_parity)
            {
                case 0:
                    serialPort1.Parity = Parity.None;
                    break;
                case 1:
                    serialPort1.Parity = Parity.Odd;
                    break;
                case 2:
                    serialPort1.Parity = Parity.Even;
                    break;
                case 3:
                    serialPort1.Parity = Parity.Mark;
                    break;
                case 4:
                    serialPort1.Parity = Parity.Space;
                    break;
            }

            serialPort1.DataBits = Properties.Settings.Default.SerialPort_dataBits;

            switch (Properties.Settings.Default.SerialPort_stopBits)
            {
                case 0:
                    serialPort1.StopBits = StopBits.One;
                    break;
                case 1:
                    serialPort1.StopBits = StopBits.Two;
                    break;
                case 2:
                    serialPort1.StopBits = StopBits.OnePointFive;
                    break;
            }
        }
        private void InitView()
        {
        }
        private void run()
        {
            //打开串口
            try
            {
                Loading.showLoadingDialog();
                initSerialPort();
                serialPort1.Open();
                status_bus.Text = "当前状态：正在营业";
                this.MenuItem_Run.Enabled = false;
                this.MenuItem_Stop.Enabled = true;
                Loading.hideLoadingDialog();
            }
            catch (Exception)
            {
                Loading.hideLoadingDialog();
                MessageBox.Show("串口打开失败" + "\n" + "1.请检查配置的参数是否正确" + "\n" + "2.外围设备是否没有连接" + "\n" + "3.串口是否已经打开或被占用" + "\n" + "4.串口驱动是否没有安装");
            }
        }
        private void stop()
        {
            try
            {
                Loading.showLoadingDialog();
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    status_bus.Text = "当前状态：暂停营业";
                    this.MenuItem_Run.Enabled = true;
                    this.MenuItem_Stop.Enabled = false;
                }
                Loading.hideLoadingDialog();
            }
            catch (Exception)
            {
                Loading.hideLoadingDialog();
                MessageBox.Show("串口关闭失败" + "\n" + "请检查是否打开串口");
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string text = string.Empty;
                byte[] result = new byte[serialPort1.BytesToRead];

                serialPort1.Read(result, 0, serialPort1.BytesToRead);

                foreach (byte b in result)
                {
                    text = Convert.ToString(b, 16);
                }
                text = Hex2String(text);
                updateDelegate.mainThread(text);
                //MessageBox.Show(text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void createDelegate()
        {
            updateDelegate = new DelegateUpdateUI();
            updateDelegate.mainThread = new DelegateUpdateUI.updateDelegate(refrashStallList);
        }
        public static String Hex2String(String hex)
        {
            byte[] data = FromHex(hex);
            return Encoding.Default.GetString(data);
        }
        private static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                try
                {
                    raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                }
                catch (Exception)
                {
                    //Do Nothing
                }
            }
            return raw;
        }
        private void goToSettingsSerialPort()
        {
            Settings_serialport settings_serialport = new Settings_serialport(this);
            settings_serialport.ShowDialog();
            settings_serialport.Activate();
            Application.DoEvents();
        }
        private void goToSettingsPark()
        {
            Settings_park settings_park = new Settings_park(this);
            settings_park.ShowDialog(); 
            settings_park.Activate();
            Application.DoEvents();
        }
        private void goToSettingsStall()
        {
            Settings_stall settings_stall = new Settings_stall(this);
            settings_stall.ShowDialog();
            settings_stall.Activate();
            Application.DoEvents();
        }
        private void goToCamera()
        {
            Camera camera = new Camera(this);
            camera.ShowDialog();
            camera.Activate();
            Application.DoEvents();
        }
        private void goToHelpWindow()
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
            helpWindow.Activate();
            Application.DoEvents();
        }
        private void refrashStallList(string info)
        {
            //判断该方法是否被主线程调用，也就是创建labMessage1控件的线程，当控件的InvokeRequired属性为ture时，说明是被主线程以外的线程调用。如果不加判断，会造成异常  
            if (this.tc_carport.InvokeRequired)
            {
                //再次创建一个DelegateUpdateUI类的对象  
                DelegateUpdateUI updateUI = new DelegateUpdateUI();
                //为新对象的mainThread对象搭载方法  
                updateUI.mainThread = new DelegateUpdateUI.updateDelegate(refrashStallList);
                //this指窗体，在这调用窗体的Invoke方法，也就是用窗体的创建线程来执行mainThread对象委托的方法，再加上需要的参数(i)  
                this.Invoke(updateUI.mainThread, new object[] { info });
            }
            else
            {
                if (info != null)
                {
                  //  playMusic();
                    switch (info)
                    {
                        case "1":
                            stall1.Image = Properties.Resources.empty;
                            status_notify.Text = "当前通知：1号车位驶出车辆";
                            break;
                        case "2":
                            stall2.Image = Properties.Resources.empty;
                            status_notify.Text = "当前通知：2号车位驶出车辆";
                            break;
                        case "3":
                            stall3.Image = Properties.Resources.empty;
                            status_notify.Text = "当前通知：3号车位驶出车辆";
                            break;
                        case "A":
                            stall1.Image = Properties.Resources.car;
                            status_notify.Text = "当前通知：1号车位驶入车辆";
                            break;
                        case "B":
                            stall2.Image = Properties.Resources.car;
                            status_notify.Text = "当前通知：2号车位驶入车辆";
                            break;
                        case "C":
                            stall3.Image = Properties.Resources.car;
                            status_notify.Text = "当前通知：3号车位驶入车辆";
                            break;
                    }
                    updateStallInfo(info);
                }
            }
        }
        private void updateStallInfo(string info)
        {
            Database db = new Database();
            Dictionary<string, string> dic_param = new Dictionary<string, string>();
            dic_param.Add("stallid", Properties.Settings.Default.Park_id.ToString());
            Console.WriteLine(Properties.Settings.Default.Park_id.ToString());
            switch (info)
            {
                case "1":
                    dic_param.Add("id", "1");
                    dic_param.Add("status", "无");
                    break;
                case "2":
                    dic_param.Add("id", "2");
                    dic_param.Add("status", "无");
                    break;
                case "3":
                    dic_param.Add("id", "3");
                    dic_param.Add("status", "无");

                    break;
                case "A":
                    dic_param.Add("id", "1");
                    dic_param.Add("status", "有");
                    break;
                case "B":
                    dic_param.Add("id", "2");
                    dic_param.Add("status", "有");
                    break;
                case "C":
                    dic_param.Add("id", "3");
                    dic_param.Add("status", "有");
                    break;
            }
            String result = db.requestServer(Database.ACTION_UPDATE_STALL_INFO, dic_param);
            if (result != "succeed")
            {
                MessageBox.Show("网络连接失败，请稍后再试!" + result);
            }
            int i = 5;
            foreach (KeyValuePair<string, string> param in dic_param)
            {
                if(param.Value == "有")
                {
                    i++;
                }
            }
            status_stall.Text = "当前车位：" + i + "/" + Properties.Settings.Default.Stall_total;
        }
        private void playMusic()
        {
            SoundPlayer player = new SoundPlayer();
            player.Stream = Properties.Resources.bgm;//只能播放.wav文件.
            player.LoadAsync();
            player.Play();
        }
        private void SmartPark_FormClosing(object sender, FormClosingEventArgs e)
        {
            signin.Close();
            signin.Dispose();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private int count = 0;
        private void stall5_Click(object sender, EventArgs e)
        {
            setImage(stall5);
        }

        private void setImage(PictureBox pb)
        {
            if (count++ % 2 == 0)
            {
                pb.Image = Properties.Resources.disable;
            }
            else
            {
                pb.Image = Properties.Resources.empty;
            }
        }

        private void stall2_Click(object sender, EventArgs e)
        {
            setImage(stall2);
        }

        private void stall3_Click(object sender, EventArgs e)
        {
            setImage(stall3);
        }

        private void stall4_Click(object sender, EventArgs e)
        {
            setImage(stall4);
        }

        private void stall8_Click(object sender, EventArgs e)
        {
            setImage(stall8);
        }

        private void stall9_Click(object sender, EventArgs e)
        {
            setImage(stall9);
        }

        private void stall7_Click(object sender, EventArgs e)
        {
            setImage(stall7);
        }
    }
}
