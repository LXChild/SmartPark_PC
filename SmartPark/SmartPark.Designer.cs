namespace SmartPark
{
    partial class SmartPark
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartPark));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Operate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Run = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SeekStall = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Profit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_camera = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_serialport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_park = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_stall = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_bus = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_stall = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_notify = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_run = new System.Windows.Forms.ToolStripLabel();
            this.ts_stop = new System.Windows.Forms.ToolStripLabel();
            this.ts_settings = new System.Windows.Forms.ToolStripLabel();
            this.ts_help = new System.Windows.Forms.ToolStripLabel();
            this.tc_carport = new System.Windows.Forms.TabControl();
            this.tp_carport1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_stall9 = new System.Windows.Forms.Label();
            this.lb_stall6 = new System.Windows.Forms.Label();
            this.lb_stall3 = new System.Windows.Forms.Label();
            this.lb_stall11 = new System.Windows.Forms.Label();
            this.lb_stall8 = new System.Windows.Forms.Label();
            this.lb_stall5 = new System.Windows.Forms.Label();
            this.lb_stall2 = new System.Windows.Forms.Label();
            this.lb_stall10 = new System.Windows.Forms.Label();
            this.lb_stall7 = new System.Windows.Forms.Label();
            this.lb_stall4 = new System.Windows.Forms.Label();
            this.lb_stall1 = new System.Windows.Forms.Label();
            this.tp_carport2 = new System.Windows.Forms.TabPage();
            this.lb_stall2_12 = new System.Windows.Forms.Label();
            this.lb_stall2_11 = new System.Windows.Forms.Label();
            this.lb_stall2_10 = new System.Windows.Forms.Label();
            this.lb_stall2_9 = new System.Windows.Forms.Label();
            this.lb_stall2_8 = new System.Windows.Forms.Label();
            this.lb_stall2_7 = new System.Windows.Forms.Label();
            this.lb_stall2_6 = new System.Windows.Forms.Label();
            this.lb_stall2_3 = new System.Windows.Forms.Label();
            this.lb_stall2_5 = new System.Windows.Forms.Label();
            this.lb_stall2_2 = new System.Windows.Forms.Label();
            this.lb_stall2_4 = new System.Windows.Forms.Label();
            this.lb_stall2_1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stall12 = new System.Windows.Forms.PictureBox();
            this.stall9 = new System.Windows.Forms.PictureBox();
            this.stall6 = new System.Windows.Forms.PictureBox();
            this.stall3 = new System.Windows.Forms.PictureBox();
            this.stall11 = new System.Windows.Forms.PictureBox();
            this.stall10 = new System.Windows.Forms.PictureBox();
            this.stall8 = new System.Windows.Forms.PictureBox();
            this.stall7 = new System.Windows.Forms.PictureBox();
            this.stall5 = new System.Windows.Forms.PictureBox();
            this.stall4 = new System.Windows.Forms.PictureBox();
            this.stall2 = new System.Windows.Forms.PictureBox();
            this.stall1 = new System.Windows.Forms.PictureBox();
            this.stall2_12 = new System.Windows.Forms.PictureBox();
            this.stall2_9 = new System.Windows.Forms.PictureBox();
            this.stall2_6 = new System.Windows.Forms.PictureBox();
            this.stall2_3 = new System.Windows.Forms.PictureBox();
            this.stall2_11 = new System.Windows.Forms.PictureBox();
            this.stall2_8 = new System.Windows.Forms.PictureBox();
            this.stall2_5 = new System.Windows.Forms.PictureBox();
            this.stall2_2 = new System.Windows.Forms.PictureBox();
            this.stall2_10 = new System.Windows.Forms.PictureBox();
            this.stall2_7 = new System.Windows.Forms.PictureBox();
            this.stall2_4 = new System.Windows.Forms.PictureBox();
            this.stall2_1 = new System.Windows.Forms.PictureBox();
            this.tsb_run = new System.Windows.Forms.ToolStripButton();
            this.tsb_stop = new System.Windows.Forms.ToolStripButton();
            this.tsb_settings = new System.Windows.Forms.ToolStripButton();
            this.tsb_help = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tc_carport.SuspendLayout();
            this.tp_carport1.SuspendLayout();
            this.tp_carport2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Operate,
            this.Menu_Check,
            this.Menu_Setting,
            this.Menu_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Operate
            // 
            this.Menu_Operate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Run,
            this.MenuItem_Stop});
            this.Menu_Operate.Name = "Menu_Operate";
            this.Menu_Operate.Size = new System.Drawing.Size(44, 21);
            this.Menu_Operate.Text = "操作";
            // 
            // MenuItem_Run
            // 
            this.MenuItem_Run.Name = "MenuItem_Run";
            this.MenuItem_Run.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Run.Text = "开始运营";
            this.MenuItem_Run.Click += new System.EventHandler(this.MenuItem_Run_Click);
            // 
            // MenuItem_Stop
            // 
            this.MenuItem_Stop.Enabled = false;
            this.MenuItem_Stop.Name = "MenuItem_Stop";
            this.MenuItem_Stop.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Stop.Text = "停止运营";
            this.MenuItem_Stop.Click += new System.EventHandler(this.MenuItem_Stop_Click);
            // 
            // Menu_Check
            // 
            this.Menu_Check.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_SeekStall,
            this.MenuItem_Profit,
            this.MenuItem_camera});
            this.Menu_Check.Name = "Menu_Check";
            this.Menu_Check.Size = new System.Drawing.Size(44, 21);
            this.Menu_Check.Text = "查看";
            // 
            // MenuItem_SeekStall
            // 
            this.MenuItem_SeekStall.Name = "MenuItem_SeekStall";
            this.MenuItem_SeekStall.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_SeekStall.Text = "查找车位";
            this.MenuItem_SeekStall.Click += new System.EventHandler(this.MenuItem_SeekStall_Click);
            // 
            // MenuItem_Profit
            // 
            this.MenuItem_Profit.Name = "MenuItem_Profit";
            this.MenuItem_Profit.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Profit.Text = "运营状况";
            this.MenuItem_Profit.Click += new System.EventHandler(this.MenuItem_Profit_Click);
            // 
            // MenuItem_camera
            // 
            this.MenuItem_camera.Name = "MenuItem_camera";
            this.MenuItem_camera.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_camera.Text = "摄像头";
            this.MenuItem_camera.Click += new System.EventHandler(this.MenuItem_camera_Click);
            // 
            // Menu_Setting
            // 
            this.Menu_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_serialport,
            this.MenuItem_park,
            this.MenuItem_stall});
            this.Menu_Setting.Name = "Menu_Setting";
            this.Menu_Setting.Size = new System.Drawing.Size(44, 21);
            this.Menu_Setting.Text = "设置";
            // 
            // MenuItem_serialport
            // 
            this.MenuItem_serialport.Name = "MenuItem_serialport";
            this.MenuItem_serialport.Size = new System.Drawing.Size(112, 22);
            this.MenuItem_serialport.Text = "串口";
            this.MenuItem_serialport.Click += new System.EventHandler(this.MenuItem_serialport_Click);
            // 
            // MenuItem_park
            // 
            this.MenuItem_park.Name = "MenuItem_park";
            this.MenuItem_park.Size = new System.Drawing.Size(112, 22);
            this.MenuItem_park.Text = "停车场";
            this.MenuItem_park.Click += new System.EventHandler(this.MenuItem_park_Click);
            // 
            // MenuItem_stall
            // 
            this.MenuItem_stall.Name = "MenuItem_stall";
            this.MenuItem_stall.Size = new System.Drawing.Size(112, 22);
            this.MenuItem_stall.Text = "车位";
            this.MenuItem_stall.Click += new System.EventHandler(this.MenuItem_stall_Click);
            // 
            // Menu_Help
            // 
            this.Menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Help,
            this.MenuItem_About});
            this.Menu_Help.Name = "Menu_Help";
            this.Menu_Help.Size = new System.Drawing.Size(44, 21);
            this.Menu_Help.Text = "帮助";
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Help.Text = "查看帮助";
            this.MenuItem_Help.Click += new System.EventHandler(this.MenuItem_Help_Click);
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_About.Text = "关于我们";
            this.MenuItem_About.Click += new System.EventHandler(this.MenuItem_About_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_bus,
            this.status_stall,
            this.status_notify});
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_bus
            // 
            this.status_bus.Name = "status_bus";
            this.status_bus.Size = new System.Drawing.Size(116, 17);
            this.status_bus.Text = "当前状态：暂停营业";
            // 
            // status_stall
            // 
            this.status_stall.Margin = new System.Windows.Forms.Padding(8, 3, 0, 2);
            this.status_stall.Name = "status_stall";
            this.status_stall.Size = new System.Drawing.Size(91, 17);
            this.status_stall.Text = "当前车位：N/A";
            // 
            // status_notify
            // 
            this.status_notify.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.status_notify.Name = "status_notify";
            this.status_notify.Size = new System.Drawing.Size(80, 17);
            this.status_notify.Text = "当前通知：无";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_run,
            this.ts_run,
            this.tsb_stop,
            this.ts_stop,
            this.tsb_settings,
            this.ts_settings,
            this.tsb_help,
            this.ts_help});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_run
            // 
            this.ts_run.Name = "ts_run";
            this.ts_run.Size = new System.Drawing.Size(56, 22);
            this.ts_run.Text = "开始运营";
            this.ts_run.Click += new System.EventHandler(this.ts_run_Click);
            // 
            // ts_stop
            // 
            this.ts_stop.Name = "ts_stop";
            this.ts_stop.Size = new System.Drawing.Size(56, 22);
            this.ts_stop.Text = "停止运营";
            this.ts_stop.Click += new System.EventHandler(this.ts_stop_Click);
            // 
            // ts_settings
            // 
            this.ts_settings.Name = "ts_settings";
            this.ts_settings.Size = new System.Drawing.Size(32, 22);
            this.ts_settings.Text = "设置";
            this.ts_settings.Click += new System.EventHandler(this.ts_settings_Click);
            // 
            // ts_help
            // 
            this.ts_help.Name = "ts_help";
            this.ts_help.Size = new System.Drawing.Size(56, 22);
            this.ts_help.Text = "使用说明";
            this.ts_help.Click += new System.EventHandler(this.ts_help_Click);
            // 
            // tc_carport
            // 
            this.tc_carport.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tc_carport.Controls.Add(this.tp_carport1);
            this.tc_carport.Controls.Add(this.tp_carport2);
            this.tc_carport.Location = new System.Drawing.Point(12, 53);
            this.tc_carport.Multiline = true;
            this.tc_carport.Name = "tc_carport";
            this.tc_carport.SelectedIndex = 0;
            this.tc_carport.Size = new System.Drawing.Size(670, 414);
            this.tc_carport.TabIndex = 5;
            // 
            // tp_carport1
            // 
            this.tp_carport1.Controls.Add(this.label12);
            this.tp_carport1.Controls.Add(this.lb_stall9);
            this.tp_carport1.Controls.Add(this.lb_stall6);
            this.tp_carport1.Controls.Add(this.lb_stall3);
            this.tp_carport1.Controls.Add(this.lb_stall11);
            this.tp_carport1.Controls.Add(this.lb_stall8);
            this.tp_carport1.Controls.Add(this.lb_stall5);
            this.tp_carport1.Controls.Add(this.lb_stall2);
            this.tp_carport1.Controls.Add(this.lb_stall10);
            this.tp_carport1.Controls.Add(this.lb_stall7);
            this.tp_carport1.Controls.Add(this.lb_stall4);
            this.tp_carport1.Controls.Add(this.lb_stall1);
            this.tp_carport1.Controls.Add(this.stall12);
            this.tp_carport1.Controls.Add(this.stall9);
            this.tp_carport1.Controls.Add(this.stall6);
            this.tp_carport1.Controls.Add(this.stall3);
            this.tp_carport1.Controls.Add(this.stall11);
            this.tp_carport1.Controls.Add(this.stall10);
            this.tp_carport1.Controls.Add(this.stall8);
            this.tp_carport1.Controls.Add(this.stall7);
            this.tp_carport1.Controls.Add(this.stall5);
            this.tp_carport1.Controls.Add(this.stall4);
            this.tp_carport1.Controls.Add(this.stall2);
            this.tp_carport1.Controls.Add(this.stall1);
            this.tp_carport1.Location = new System.Drawing.Point(4, 4);
            this.tp_carport1.Name = "tp_carport1";
            this.tp_carport1.Padding = new System.Windows.Forms.Padding(3);
            this.tp_carport1.Size = new System.Drawing.Size(662, 388);
            this.tp_carport1.TabIndex = 0;
            this.tp_carport1.Text = "1号车库";
            this.tp_carport1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "12号车位";
            // 
            // lb_stall9
            // 
            this.lb_stall9.AutoSize = true;
            this.lb_stall9.Location = new System.Drawing.Point(453, 232);
            this.lb_stall9.Name = "lb_stall9";
            this.lb_stall9.Size = new System.Drawing.Size(47, 12);
            this.lb_stall9.TabIndex = 1;
            this.lb_stall9.Text = "9号车位";
            // 
            // lb_stall6
            // 
            this.lb_stall6.AutoSize = true;
            this.lb_stall6.Location = new System.Drawing.Point(453, 137);
            this.lb_stall6.Name = "lb_stall6";
            this.lb_stall6.Size = new System.Drawing.Size(47, 12);
            this.lb_stall6.TabIndex = 1;
            this.lb_stall6.Text = "6号车位";
            // 
            // lb_stall3
            // 
            this.lb_stall3.AutoSize = true;
            this.lb_stall3.Location = new System.Drawing.Point(453, 39);
            this.lb_stall3.Name = "lb_stall3";
            this.lb_stall3.Size = new System.Drawing.Size(47, 12);
            this.lb_stall3.TabIndex = 1;
            this.lb_stall3.Text = "3号车位";
            // 
            // lb_stall11
            // 
            this.lb_stall11.AutoSize = true;
            this.lb_stall11.Location = new System.Drawing.Point(232, 321);
            this.lb_stall11.Name = "lb_stall11";
            this.lb_stall11.Size = new System.Drawing.Size(53, 12);
            this.lb_stall11.TabIndex = 1;
            this.lb_stall11.Text = "11号车位";
            // 
            // lb_stall8
            // 
            this.lb_stall8.AutoSize = true;
            this.lb_stall8.Location = new System.Drawing.Point(238, 232);
            this.lb_stall8.Name = "lb_stall8";
            this.lb_stall8.Size = new System.Drawing.Size(47, 12);
            this.lb_stall8.TabIndex = 1;
            this.lb_stall8.Text = "8号车位";
            // 
            // lb_stall5
            // 
            this.lb_stall5.AutoSize = true;
            this.lb_stall5.Location = new System.Drawing.Point(238, 137);
            this.lb_stall5.Name = "lb_stall5";
            this.lb_stall5.Size = new System.Drawing.Size(47, 12);
            this.lb_stall5.TabIndex = 1;
            this.lb_stall5.Text = "5号车位";
            // 
            // lb_stall2
            // 
            this.lb_stall2.AutoSize = true;
            this.lb_stall2.Location = new System.Drawing.Point(238, 39);
            this.lb_stall2.Name = "lb_stall2";
            this.lb_stall2.Size = new System.Drawing.Size(47, 12);
            this.lb_stall2.TabIndex = 1;
            this.lb_stall2.Text = "2号车位";
            // 
            // lb_stall10
            // 
            this.lb_stall10.AutoSize = true;
            this.lb_stall10.Location = new System.Drawing.Point(3, 330);
            this.lb_stall10.Name = "lb_stall10";
            this.lb_stall10.Size = new System.Drawing.Size(53, 12);
            this.lb_stall10.TabIndex = 1;
            this.lb_stall10.Text = "10号车位";
            // 
            // lb_stall7
            // 
            this.lb_stall7.AutoSize = true;
            this.lb_stall7.Location = new System.Drawing.Point(9, 232);
            this.lb_stall7.Name = "lb_stall7";
            this.lb_stall7.Size = new System.Drawing.Size(47, 12);
            this.lb_stall7.TabIndex = 1;
            this.lb_stall7.Text = "7号车位";
            // 
            // lb_stall4
            // 
            this.lb_stall4.AutoSize = true;
            this.lb_stall4.Location = new System.Drawing.Point(9, 137);
            this.lb_stall4.Name = "lb_stall4";
            this.lb_stall4.Size = new System.Drawing.Size(47, 12);
            this.lb_stall4.TabIndex = 1;
            this.lb_stall4.Text = "4号车位";
            // 
            // lb_stall1
            // 
            this.lb_stall1.AutoSize = true;
            this.lb_stall1.Location = new System.Drawing.Point(9, 39);
            this.lb_stall1.Name = "lb_stall1";
            this.lb_stall1.Size = new System.Drawing.Size(47, 12);
            this.lb_stall1.TabIndex = 1;
            this.lb_stall1.Text = "1号车位";
            // 
            // tp_carport2
            // 
            this.tp_carport2.Controls.Add(this.stall2_12);
            this.tp_carport2.Controls.Add(this.stall2_9);
            this.tp_carport2.Controls.Add(this.stall2_6);
            this.tp_carport2.Controls.Add(this.stall2_3);
            this.tp_carport2.Controls.Add(this.stall2_11);
            this.tp_carport2.Controls.Add(this.stall2_8);
            this.tp_carport2.Controls.Add(this.stall2_5);
            this.tp_carport2.Controls.Add(this.stall2_2);
            this.tp_carport2.Controls.Add(this.stall2_10);
            this.tp_carport2.Controls.Add(this.stall2_7);
            this.tp_carport2.Controls.Add(this.stall2_4);
            this.tp_carport2.Controls.Add(this.stall2_1);
            this.tp_carport2.Controls.Add(this.lb_stall2_12);
            this.tp_carport2.Controls.Add(this.lb_stall2_11);
            this.tp_carport2.Controls.Add(this.lb_stall2_10);
            this.tp_carport2.Controls.Add(this.lb_stall2_9);
            this.tp_carport2.Controls.Add(this.lb_stall2_8);
            this.tp_carport2.Controls.Add(this.lb_stall2_7);
            this.tp_carport2.Controls.Add(this.lb_stall2_6);
            this.tp_carport2.Controls.Add(this.lb_stall2_3);
            this.tp_carport2.Controls.Add(this.lb_stall2_5);
            this.tp_carport2.Controls.Add(this.lb_stall2_2);
            this.tp_carport2.Controls.Add(this.lb_stall2_4);
            this.tp_carport2.Controls.Add(this.lb_stall2_1);
            this.tp_carport2.Location = new System.Drawing.Point(4, 4);
            this.tp_carport2.Name = "tp_carport2";
            this.tp_carport2.Padding = new System.Windows.Forms.Padding(3);
            this.tp_carport2.Size = new System.Drawing.Size(662, 388);
            this.tp_carport2.TabIndex = 1;
            this.tp_carport2.Text = "2号车库";
            this.tp_carport2.UseVisualStyleBackColor = true;
            // 
            // lb_stall2_12
            // 
            this.lb_stall2_12.AutoSize = true;
            this.lb_stall2_12.Location = new System.Drawing.Point(447, 325);
            this.lb_stall2_12.Name = "lb_stall2_12";
            this.lb_stall2_12.Size = new System.Drawing.Size(53, 12);
            this.lb_stall2_12.TabIndex = 0;
            this.lb_stall2_12.Text = "12号车位";
            // 
            // lb_stall2_11
            // 
            this.lb_stall2_11.AutoSize = true;
            this.lb_stall2_11.Location = new System.Drawing.Point(220, 325);
            this.lb_stall2_11.Name = "lb_stall2_11";
            this.lb_stall2_11.Size = new System.Drawing.Size(53, 12);
            this.lb_stall2_11.TabIndex = 0;
            this.lb_stall2_11.Text = "11号车位";
            // 
            // lb_stall2_10
            // 
            this.lb_stall2_10.AutoSize = true;
            this.lb_stall2_10.Location = new System.Drawing.Point(5, 325);
            this.lb_stall2_10.Name = "lb_stall2_10";
            this.lb_stall2_10.Size = new System.Drawing.Size(53, 12);
            this.lb_stall2_10.TabIndex = 0;
            this.lb_stall2_10.Text = "10号车位";
            // 
            // lb_stall2_9
            // 
            this.lb_stall2_9.AutoSize = true;
            this.lb_stall2_9.Location = new System.Drawing.Point(453, 231);
            this.lb_stall2_9.Name = "lb_stall2_9";
            this.lb_stall2_9.Size = new System.Drawing.Size(47, 12);
            this.lb_stall2_9.TabIndex = 0;
            this.lb_stall2_9.Text = "9号车位";
            // 
            // lb_stall2_8
            // 
            this.lb_stall2_8.AutoSize = true;
            this.lb_stall2_8.Location = new System.Drawing.Point(238, 231);
            this.lb_stall2_8.Name = "lb_stall2_8";
            this.lb_stall2_8.Size = new System.Drawing.Size(47, 12);
            this.lb_stall2_8.TabIndex = 0;
            this.lb_stall2_8.Text = "8号车位";
            // 
            // lb_stall2_7
            // 
            this.lb_stall2_7.AutoSize = true;
            this.lb_stall2_7.Location = new System.Drawing.Point(11, 231);
            this.lb_stall2_7.Name = "lb_stall2_7";
            this.lb_stall2_7.Size = new System.Drawing.Size(47, 12);
            this.lb_stall2_7.TabIndex = 0;
            this.lb_stall2_7.Text = "7号车位";
            // 
            // lb_stall2_6
            // 
            this.lb_stall2_6.AutoSize = true;
            this.lb_stall2_6.Location = new System.Drawing.Point(453, 140);
            this.lb_stall2_6.Name = "lb_stall2_6";
            this.lb_stall2_6.Size = new System.Drawing.Size(47, 12);
            this.lb_stall2_6.TabIndex = 0;
            this.lb_stall2_6.Text = "6号车位";
            // 
            // lb_stall2_3
            // 
            this.lb_stall2_3.AutoSize = true;
            this.lb_stall2_3.Location = new System.Drawing.Point(453, 44);
            this.lb_stall2_3.Name = "lb_stall2_3";
            this.lb_stall2_3.Size = new System.Drawing.Size(47, 12);
            this.lb_stall2_3.TabIndex = 0;
            this.lb_stall2_3.Text = "3号车位";
            // 
            // lb_stall2_5
            // 
            this.lb_stall2_5.AutoSize = true;
            this.lb_stall2_5.Location = new System.Drawing.Point(238, 140);
            this.lb_stall2_5.Name = "lb_stall2_5";
            this.lb_stall2_5.Size = new System.Drawing.Size(47, 12);
            this.lb_stall2_5.TabIndex = 0;
            this.lb_stall2_5.Text = "5号车位";
            // 
            // lb_stall2_2
            // 
            this.lb_stall2_2.AutoSize = true;
            this.lb_stall2_2.Location = new System.Drawing.Point(238, 44);
            this.lb_stall2_2.Name = "lb_stall2_2";
            this.lb_stall2_2.Size = new System.Drawing.Size(47, 12);
            this.lb_stall2_2.TabIndex = 0;
            this.lb_stall2_2.Text = "2号车位";
            // 
            // lb_stall2_4
            // 
            this.lb_stall2_4.AutoSize = true;
            this.lb_stall2_4.Location = new System.Drawing.Point(11, 140);
            this.lb_stall2_4.Name = "lb_stall2_4";
            this.lb_stall2_4.Size = new System.Drawing.Size(47, 12);
            this.lb_stall2_4.TabIndex = 0;
            this.lb_stall2_4.Text = "4号车位";
            // 
            // lb_stall2_1
            // 
            this.lb_stall2_1.AutoSize = true;
            this.lb_stall2_1.Location = new System.Drawing.Point(11, 44);
            this.lb_stall2_1.Name = "lb_stall2_1";
            this.lb_stall2_1.Size = new System.Drawing.Size(47, 12);
            this.lb_stall2_1.TabIndex = 0;
            this.lb_stall2_1.Text = "1号车位";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "智能停车场";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stall12
            // 
            this.stall12.Image = global::SmartPark.Properties.Resources.car;
            this.stall12.Location = new System.Drawing.Point(506, 288);
            this.stall12.Name = "stall12";
            this.stall12.Size = new System.Drawing.Size(150, 88);
            this.stall12.TabIndex = 0;
            this.stall12.TabStop = false;
            // 
            // stall9
            // 
            this.stall9.Image = global::SmartPark.Properties.Resources.reserve;
            this.stall9.Location = new System.Drawing.Point(506, 194);
            this.stall9.Name = "stall9";
            this.stall9.Size = new System.Drawing.Size(150, 88);
            this.stall9.TabIndex = 0;
            this.stall9.TabStop = false;
            this.stall9.Click += new System.EventHandler(this.stall9_Click);
            // 
            // stall6
            // 
            this.stall6.Image = global::SmartPark.Properties.Resources.car;
            this.stall6.Location = new System.Drawing.Point(506, 100);
            this.stall6.Name = "stall6";
            this.stall6.Size = new System.Drawing.Size(150, 88);
            this.stall6.TabIndex = 0;
            this.stall6.TabStop = false;
            // 
            // stall3
            // 
            this.stall3.Image = global::SmartPark.Properties.Resources.empty;
            this.stall3.Location = new System.Drawing.Point(506, 6);
            this.stall3.Name = "stall3";
            this.stall3.Size = new System.Drawing.Size(150, 88);
            this.stall3.TabIndex = 0;
            this.stall3.TabStop = false;
            this.stall3.Click += new System.EventHandler(this.stall3_Click);
            // 
            // stall11
            // 
            this.stall11.Image = global::SmartPark.Properties.Resources.car;
            this.stall11.Location = new System.Drawing.Point(291, 288);
            this.stall11.Name = "stall11";
            this.stall11.Size = new System.Drawing.Size(150, 88);
            this.stall11.TabIndex = 0;
            this.stall11.TabStop = false;
            // 
            // stall10
            // 
            this.stall10.Image = global::SmartPark.Properties.Resources.car;
            this.stall10.Location = new System.Drawing.Point(62, 288);
            this.stall10.Name = "stall10";
            this.stall10.Size = new System.Drawing.Size(150, 88);
            this.stall10.TabIndex = 0;
            this.stall10.TabStop = false;
            // 
            // stall8
            // 
            this.stall8.Image = global::SmartPark.Properties.Resources.reserve;
            this.stall8.Location = new System.Drawing.Point(291, 194);
            this.stall8.Name = "stall8";
            this.stall8.Size = new System.Drawing.Size(150, 88);
            this.stall8.TabIndex = 0;
            this.stall8.TabStop = false;
            this.stall8.Click += new System.EventHandler(this.stall8_Click);
            // 
            // stall7
            // 
            this.stall7.Image = global::SmartPark.Properties.Resources.car;
            this.stall7.Location = new System.Drawing.Point(62, 194);
            this.stall7.Name = "stall7";
            this.stall7.Size = new System.Drawing.Size(150, 88);
            this.stall7.TabIndex = 0;
            this.stall7.TabStop = false;
            this.stall7.Click += new System.EventHandler(this.stall7_Click);
            // 
            // stall5
            // 
            this.stall5.Image = global::SmartPark.Properties.Resources.empty;
            this.stall5.Location = new System.Drawing.Point(291, 100);
            this.stall5.Name = "stall5";
            this.stall5.Size = new System.Drawing.Size(150, 88);
            this.stall5.TabIndex = 0;
            this.stall5.TabStop = false;
            this.stall5.Click += new System.EventHandler(this.stall5_Click);
            // 
            // stall4
            // 
            this.stall4.Image = global::SmartPark.Properties.Resources.empty;
            this.stall4.Location = new System.Drawing.Point(62, 100);
            this.stall4.Name = "stall4";
            this.stall4.Size = new System.Drawing.Size(150, 88);
            this.stall4.TabIndex = 0;
            this.stall4.TabStop = false;
            this.stall4.Click += new System.EventHandler(this.stall4_Click);
            // 
            // stall2
            // 
            this.stall2.Image = global::SmartPark.Properties.Resources.empty;
            this.stall2.Location = new System.Drawing.Point(291, 3);
            this.stall2.Name = "stall2";
            this.stall2.Size = new System.Drawing.Size(150, 88);
            this.stall2.TabIndex = 0;
            this.stall2.TabStop = false;
            this.stall2.Click += new System.EventHandler(this.stall2_Click);
            // 
            // stall1
            // 
            this.stall1.Image = global::SmartPark.Properties.Resources.reserve;
            this.stall1.Location = new System.Drawing.Point(62, 6);
            this.stall1.Name = "stall1";
            this.stall1.Size = new System.Drawing.Size(150, 88);
            this.stall1.TabIndex = 0;
            this.stall1.TabStop = false;
            // 
            // stall2_12
            // 
            this.stall2_12.Image = global::SmartPark.Properties.Resources.empty;
            this.stall2_12.Location = new System.Drawing.Point(506, 288);
            this.stall2_12.Name = "stall2_12";
            this.stall2_12.Size = new System.Drawing.Size(150, 88);
            this.stall2_12.TabIndex = 1;
            this.stall2_12.TabStop = false;
            // 
            // stall2_9
            // 
            this.stall2_9.Image = global::SmartPark.Properties.Resources.car;
            this.stall2_9.Location = new System.Drawing.Point(506, 194);
            this.stall2_9.Name = "stall2_9";
            this.stall2_9.Size = new System.Drawing.Size(150, 88);
            this.stall2_9.TabIndex = 1;
            this.stall2_9.TabStop = false;
            // 
            // stall2_6
            // 
            this.stall2_6.Image = global::SmartPark.Properties.Resources.empty;
            this.stall2_6.Location = new System.Drawing.Point(506, 100);
            this.stall2_6.Name = "stall2_6";
            this.stall2_6.Size = new System.Drawing.Size(150, 88);
            this.stall2_6.TabIndex = 1;
            this.stall2_6.TabStop = false;
            // 
            // stall2_3
            // 
            this.stall2_3.Image = global::SmartPark.Properties.Resources.car;
            this.stall2_3.Location = new System.Drawing.Point(506, 6);
            this.stall2_3.Name = "stall2_3";
            this.stall2_3.Size = new System.Drawing.Size(150, 88);
            this.stall2_3.TabIndex = 1;
            this.stall2_3.TabStop = false;
            // 
            // stall2_11
            // 
            this.stall2_11.Image = global::SmartPark.Properties.Resources.empty;
            this.stall2_11.Location = new System.Drawing.Point(291, 288);
            this.stall2_11.Name = "stall2_11";
            this.stall2_11.Size = new System.Drawing.Size(150, 88);
            this.stall2_11.TabIndex = 1;
            this.stall2_11.TabStop = false;
            // 
            // stall2_8
            // 
            this.stall2_8.Image = global::SmartPark.Properties.Resources.car;
            this.stall2_8.Location = new System.Drawing.Point(291, 194);
            this.stall2_8.Name = "stall2_8";
            this.stall2_8.Size = new System.Drawing.Size(150, 88);
            this.stall2_8.TabIndex = 1;
            this.stall2_8.TabStop = false;
            // 
            // stall2_5
            // 
            this.stall2_5.Image = global::SmartPark.Properties.Resources.car;
            this.stall2_5.Location = new System.Drawing.Point(291, 100);
            this.stall2_5.Name = "stall2_5";
            this.stall2_5.Size = new System.Drawing.Size(150, 88);
            this.stall2_5.TabIndex = 1;
            this.stall2_5.TabStop = false;
            // 
            // stall2_2
            // 
            this.stall2_2.Image = global::SmartPark.Properties.Resources.empty;
            this.stall2_2.Location = new System.Drawing.Point(291, 6);
            this.stall2_2.Name = "stall2_2";
            this.stall2_2.Size = new System.Drawing.Size(150, 88);
            this.stall2_2.TabIndex = 1;
            this.stall2_2.TabStop = false;
            // 
            // stall2_10
            // 
            this.stall2_10.Image = global::SmartPark.Properties.Resources.empty;
            this.stall2_10.Location = new System.Drawing.Point(64, 288);
            this.stall2_10.Name = "stall2_10";
            this.stall2_10.Size = new System.Drawing.Size(150, 88);
            this.stall2_10.TabIndex = 1;
            this.stall2_10.TabStop = false;
            // 
            // stall2_7
            // 
            this.stall2_7.Image = global::SmartPark.Properties.Resources.empty;
            this.stall2_7.Location = new System.Drawing.Point(64, 194);
            this.stall2_7.Name = "stall2_7";
            this.stall2_7.Size = new System.Drawing.Size(150, 88);
            this.stall2_7.TabIndex = 1;
            this.stall2_7.TabStop = false;
            // 
            // stall2_4
            // 
            this.stall2_4.Image = global::SmartPark.Properties.Resources.empty;
            this.stall2_4.Location = new System.Drawing.Point(64, 100);
            this.stall2_4.Name = "stall2_4";
            this.stall2_4.Size = new System.Drawing.Size(150, 88);
            this.stall2_4.TabIndex = 1;
            this.stall2_4.TabStop = false;
            // 
            // stall2_1
            // 
            this.stall2_1.Image = global::SmartPark.Properties.Resources.empty;
            this.stall2_1.Location = new System.Drawing.Point(64, 6);
            this.stall2_1.Name = "stall2_1";
            this.stall2_1.Size = new System.Drawing.Size(150, 88);
            this.stall2_1.TabIndex = 1;
            this.stall2_1.TabStop = false;
            // 
            // tsb_run
            // 
            this.tsb_run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_run.Image = global::SmartPark.Properties.Resources.run;
            this.tsb_run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_run.Name = "tsb_run";
            this.tsb_run.Size = new System.Drawing.Size(23, 22);
            this.tsb_run.Text = "开始运营";
            this.tsb_run.Click += new System.EventHandler(this.tsb_run_Click);
            // 
            // tsb_stop
            // 
            this.tsb_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_stop.Image = global::SmartPark.Properties.Resources.stop;
            this.tsb_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_stop.Name = "tsb_stop";
            this.tsb_stop.Size = new System.Drawing.Size(23, 22);
            this.tsb_stop.Text = "停止运营";
            this.tsb_stop.Click += new System.EventHandler(this.tsb_stop_click);
            // 
            // tsb_settings
            // 
            this.tsb_settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_settings.Image = global::SmartPark.Properties.Resources.settings;
            this.tsb_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_settings.Name = "tsb_settings";
            this.tsb_settings.Size = new System.Drawing.Size(23, 22);
            this.tsb_settings.Text = "设置";
            this.tsb_settings.Click += new System.EventHandler(this.tsb_settings_Click);
            // 
            // tsb_help
            // 
            this.tsb_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_help.Image = global::SmartPark.Properties.Resources.help;
            this.tsb_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_help.Name = "tsb_help";
            this.tsb_help.Size = new System.Drawing.Size(23, 22);
            this.tsb_help.Text = "使用说明";
            this.tsb_help.Click += new System.EventHandler(this.tsb_help_Click);
            // 
            // SmartPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(694, 499);
            this.Controls.Add(this.tc_carport);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SmartPark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能车位管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmartPark_FormClosing);
            this.Load += new System.EventHandler(this.SmartPark_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tc_carport.ResumeLayout(false);
            this.tp_carport1.ResumeLayout(false);
            this.tp_carport1.PerformLayout();
            this.tp_carport2.ResumeLayout(false);
            this.tp_carport2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stall2_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Setting;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help;
        private System.Windows.Forms.ToolStripMenuItem Menu_Operate;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Run;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stop;
        private System.Windows.Forms.ToolStripMenuItem Menu_Check;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_bus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripStatusLabel status_stall;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SeekStall;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Profit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_run;
        private System.Windows.Forms.ToolStripLabel ts_run;
        private System.Windows.Forms.ToolStripButton tsb_stop;
        private System.Windows.Forms.ToolStripLabel ts_stop;
        private System.Windows.Forms.ToolStripButton tsb_settings;
        private System.Windows.Forms.ToolStripLabel ts_settings;
        private System.Windows.Forms.ToolStripButton tsb_help;
        private System.Windows.Forms.ToolStripLabel ts_help;
        private System.Windows.Forms.TabControl tc_carport;
        private System.Windows.Forms.TabPage tp_carport1;
        private System.Windows.Forms.TabPage tp_carport2;
        private System.Windows.Forms.Label lb_stall1;
        private System.Windows.Forms.PictureBox stall1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_stall9;
        private System.Windows.Forms.Label lb_stall6;
        private System.Windows.Forms.Label lb_stall3;
        private System.Windows.Forms.Label lb_stall11;
        private System.Windows.Forms.Label lb_stall8;
        private System.Windows.Forms.Label lb_stall5;
        private System.Windows.Forms.Label lb_stall2;
        private System.Windows.Forms.Label lb_stall10;
        private System.Windows.Forms.Label lb_stall7;
        private System.Windows.Forms.Label lb_stall4;
        private System.Windows.Forms.PictureBox stall12;
        private System.Windows.Forms.PictureBox stall9;
        private System.Windows.Forms.PictureBox stall6;
        private System.Windows.Forms.PictureBox stall3;
        private System.Windows.Forms.PictureBox stall11;
        private System.Windows.Forms.PictureBox stall10;
        private System.Windows.Forms.PictureBox stall8;
        private System.Windows.Forms.PictureBox stall7;
        private System.Windows.Forms.PictureBox stall5;
        private System.Windows.Forms.PictureBox stall4;
        private System.Windows.Forms.PictureBox stall2;
        private System.Windows.Forms.PictureBox stall2_12;
        private System.Windows.Forms.PictureBox stall2_9;
        private System.Windows.Forms.PictureBox stall2_6;
        private System.Windows.Forms.PictureBox stall2_3;
        private System.Windows.Forms.PictureBox stall2_11;
        private System.Windows.Forms.PictureBox stall2_8;
        private System.Windows.Forms.PictureBox stall2_5;
        private System.Windows.Forms.PictureBox stall2_2;
        private System.Windows.Forms.PictureBox stall2_10;
        private System.Windows.Forms.PictureBox stall2_7;
        private System.Windows.Forms.PictureBox stall2_4;
        private System.Windows.Forms.PictureBox stall2_1;
        private System.Windows.Forms.Label lb_stall2_10;
        private System.Windows.Forms.Label lb_stall2_7;
        private System.Windows.Forms.Label lb_stall2_4;
        private System.Windows.Forms.Label lb_stall2_1;
        private System.Windows.Forms.Label lb_stall2_12;
        private System.Windows.Forms.Label lb_stall2_11;
        private System.Windows.Forms.Label lb_stall2_9;
        private System.Windows.Forms.Label lb_stall2_8;
        private System.Windows.Forms.Label lb_stall2_6;
        private System.Windows.Forms.Label lb_stall2_3;
        private System.Windows.Forms.Label lb_stall2_5;
        private System.Windows.Forms.Label lb_stall2_2;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_serialport;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_park;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_stall;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_camera;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripStatusLabel status_notify;
        private System.Windows.Forms.Timer timer1;
    }
}

