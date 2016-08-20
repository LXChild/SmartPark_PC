namespace SmartPark
{
    partial class Settings_serialport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort_stop = new System.Windows.Forms.ComboBox();
            this.serialPort_data = new System.Windows.Forms.ComboBox();
            this.serialPort_baut = new System.Windows.Forms.ComboBox();
            this.serialPort_parity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort_num = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "停止位:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "数据位:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "校验位:";
            // 
            // serialPort_stop
            // 
            this.serialPort_stop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPort_stop.FormattingEnabled = true;
            this.serialPort_stop.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointFive"});
            this.serialPort_stop.Location = new System.Drawing.Point(103, 150);
            this.serialPort_stop.Name = "serialPort_stop";
            this.serialPort_stop.Size = new System.Drawing.Size(72, 20);
            this.serialPort_stop.TabIndex = 3;
            // 
            // serialPort_data
            // 
            this.serialPort_data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPort_data.FormattingEnabled = true;
            this.serialPort_data.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.serialPort_data.Location = new System.Drawing.Point(103, 117);
            this.serialPort_data.Name = "serialPort_data";
            this.serialPort_data.Size = new System.Drawing.Size(72, 20);
            this.serialPort_data.TabIndex = 3;
            // 
            // serialPort_baut
            // 
            this.serialPort_baut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPort_baut.FormattingEnabled = true;
            this.serialPort_baut.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.serialPort_baut.Location = new System.Drawing.Point(103, 51);
            this.serialPort_baut.Name = "serialPort_baut";
            this.serialPort_baut.Size = new System.Drawing.Size(72, 20);
            this.serialPort_baut.TabIndex = 3;
            // 
            // serialPort_parity
            // 
            this.serialPort_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPort_parity.FormattingEnabled = true;
            this.serialPort_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.serialPort_parity.Location = new System.Drawing.Point(103, 84);
            this.serialPort_parity.Name = "serialPort_parity";
            this.serialPort_parity.Size = new System.Drawing.Size(72, 20);
            this.serialPort_parity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率:";
            // 
            // serialPort_num
            // 
            this.serialPort_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPort_num.FormattingEnabled = true;
            this.serialPort_num.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.serialPort_num.Location = new System.Drawing.Point(103, 18);
            this.serialPort_num.Name = "serialPort_num";
            this.serialPort_num.Size = new System.Drawing.Size(72, 20);
            this.serialPort_num.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(145, 213);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(72, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Settings_serialport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(222, 248);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serialPort_parity);
            this.Controls.Add(this.serialPort_stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialPort_data);
            this.Controls.Add(this.serialPort_num);
            this.Controls.Add(this.serialPort_baut);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings_serialport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口设置";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox serialPort_stop;
        public System.Windows.Forms.ComboBox serialPort_data;
        public System.Windows.Forms.ComboBox serialPort_baut;
        public System.Windows.Forms.ComboBox serialPort_parity;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox serialPort_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
    }
}