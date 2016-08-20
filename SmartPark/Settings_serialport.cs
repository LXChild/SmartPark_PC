using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace SmartPark
{
    public partial class Settings_serialport : Form
    {
        private SmartPark mainform;
        public Settings_serialport(SmartPark mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            InitSerialPort();
            Settings_serialport.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
            this.Dispose();
        }
        public void GetComList()
        {
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (keyCom != null)
            {
                string[] sSubKeys = keyCom.GetValueNames();
                foreach (string sName in sSubKeys)
                {
                    string sValue = (string)keyCom.GetValue(sName);
                     MessageBox.Show(sValue);
                }
            }
        }

        public void InitSerialPort()
        {
            GetComList();
            serialPort_num.SelectedItem = Properties.Settings.Default.SerialPort_num;
            serialPort_baut.SelectedItem = Properties.Settings.Default.SerialPort_baudRate + "";
            serialPort_data.SelectedItem = Properties.Settings.Default.SerialPort_dataBits + "";

            switch (Properties.Settings.Default.SerialPort_parity)
            {
                case 0:
                    serialPort_parity.SelectedItem = "None";
                    break;
                case 1:
                    serialPort_parity.SelectedItem = "Odd";
                    break;
                case 2:
                    serialPort_parity.SelectedItem = "Even";
                    break;
                case 3:
                    serialPort_parity.SelectedItem = "Mark";
                    break;
                case 4:
                    serialPort_parity.SelectedItem = "Space";
                    break;
            }

            switch (Properties.Settings.Default.SerialPort_stopBits)
            {
                case 0:
                    serialPort_stop.SelectedItem = "One";
                    break;
                case 1:
                    serialPort_stop.SelectedItem = "Two";
                    break;
                case 2:
                    serialPort_stop.SelectedItem = "OnePointFive";
                    break;
            }
        }

        private void saveSerialPortSettings()
        {
            Properties.Settings.Default.SerialPort_num = serialPort_num.SelectedItem.ToString();
            Properties.Settings.Default.SerialPort_baudRate = Convert.ToInt16(serialPort_baut.SelectedItem.ToString());
            Properties.Settings.Default.SerialPort_dataBits = Convert.ToInt16(serialPort_data.SelectedItem.ToString());
            switch (serialPort_parity.SelectedItem.ToString())
            {
                case "None":
                    Properties.Settings.Default.SerialPort_parity = 0;
                    break;
                case "Odd":
                    Properties.Settings.Default.SerialPort_parity = 1;
                    break;
                case "Even":
                    Properties.Settings.Default.SerialPort_parity = 2;
                    break;
                case "Mark":
                    Properties.Settings.Default.SerialPort_parity = 3;
                    break;
                case "Space":
                    Properties.Settings.Default.SerialPort_parity = 4;
                    break;
            }
            switch (serialPort_stop.SelectedItem.ToString())
            {
                case "One":
                    Properties.Settings.Default.SerialPort_stopBits = 0;
                    break;
                case "Two":
                    Properties.Settings.Default.SerialPort_stopBits = 1;
                    break;
                case "OnePointFive":
                    Properties.Settings.Default.SerialPort_stopBits = 2;
                    break;
            }
        }
    }
}
