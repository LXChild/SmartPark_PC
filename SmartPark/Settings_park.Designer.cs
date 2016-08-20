namespace SmartPark
{
    partial class Settings_park
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_park));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_jiage1 = new System.Windows.Forms.TextBox();
            this.tb_jiage2 = new System.Windows.Forms.TextBox();
            this.tb_beizhu2 = new System.Windows.Forms.TextBox();
            this.tb_beizhu1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_jishi = new System.Windows.Forms.RadioButton();
            this.rb_jici = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_lat = new System.Windows.Forms.TextBox();
            this.tb_lon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_stall = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_masterid = new System.Windows.Forms.TextBox();
            this.tb_master = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tb_name);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(201, 70);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "停车场";
            // 
            // tb_name
            // 
            this.tb_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "ParkName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_name.Location = new System.Drawing.Point(73, 30);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 21);
            this.tb_name.TabIndex = 1;
            this.tb_name.Text = global::SmartPark.Properties.Settings.Default.ParkName;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "名称:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(12, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 136);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "运营信息";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.tb_jiage1);
            this.groupBox6.Controls.Add(this.tb_jiage2);
            this.groupBox6.Controls.Add(this.tb_beizhu2);
            this.groupBox6.Controls.Add(this.tb_beizhu1);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(117, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(285, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "收费价格";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "备注2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "备注1:";
            // 
            // tb_jiage1
            // 
            this.tb_jiage1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Price_1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_jiage1.Location = new System.Drawing.Point(182, 27);
            this.tb_jiage1.Name = "tb_jiage1";
            this.tb_jiage1.Size = new System.Drawing.Size(80, 21);
            this.tb_jiage1.TabIndex = 3;
            // 
            // tb_jiage2
            // 
            this.tb_jiage2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Price_2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_jiage2.Location = new System.Drawing.Point(182, 62);
            this.tb_jiage2.Name = "tb_jiage2";
            this.tb_jiage2.Size = new System.Drawing.Size(80, 21);
            this.tb_jiage2.TabIndex = 3;
            // 
            // tb_beizhu2
            // 
            this.tb_beizhu2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Remark_2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_beizhu2.Location = new System.Drawing.Point(47, 62);
            this.tb_beizhu2.Name = "tb_beizhu2";
            this.tb_beizhu2.Size = new System.Drawing.Size(80, 21);
            this.tb_beizhu2.TabIndex = 1;
            // 
            // tb_beizhu1
            // 
            this.tb_beizhu1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Remark_1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_beizhu1.Location = new System.Drawing.Point(47, 27);
            this.tb_beizhu1.Name = "tb_beizhu1";
            this.tb_beizhu1.Size = new System.Drawing.Size(80, 21);
            this.tb_beizhu1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "价格2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "价格1:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_jishi);
            this.groupBox5.Controls.Add(this.rb_jici);
            this.groupBox5.Location = new System.Drawing.Point(7, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(86, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "收费类型";
            // 
            // rb_jishi
            // 
            this.rb_jishi.AutoSize = true;
            this.rb_jishi.Checked = global::SmartPark.Properties.Settings.Default.Type_price_count;
            this.rb_jishi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SmartPark.Properties.Settings.Default, "Type_price_count", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rb_jishi.Location = new System.Drawing.Point(14, 63);
            this.rb_jishi.Name = "rb_jishi";
            this.rb_jishi.Size = new System.Drawing.Size(47, 16);
            this.rb_jishi.TabIndex = 1;
            this.rb_jishi.TabStop = true;
            this.rb_jishi.Text = "计次";
            this.rb_jishi.UseVisualStyleBackColor = true;
            // 
            // rb_jici
            // 
            this.rb_jici.AutoSize = true;
            this.rb_jici.Checked = global::SmartPark.Properties.Settings.Default.Type_price_time;
            this.rb_jici.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SmartPark.Properties.Settings.Default, "Type_price_time", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rb_jici.Location = new System.Drawing.Point(14, 27);
            this.rb_jici.Name = "rb_jici";
            this.rb_jici.Size = new System.Drawing.Size(47, 16);
            this.rb_jici.TabIndex = 0;
            this.rb_jici.Text = "计时";
            this.rb_jici.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_address);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tb_lat);
            this.groupBox3.Controls.Add(this.tb_lon);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 130);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "停车场位置";
            // 
            // tb_address
            // 
            this.tb_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Address", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_address.Location = new System.Drawing.Point(73, 90);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(100, 21);
            this.tb_address.TabIndex = 5;
            this.tb_address.Text = global::SmartPark.Properties.Settings.Default.Address;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "地址:";
            // 
            // tb_lat
            // 
            this.tb_lat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Loc_lat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_lat.Location = new System.Drawing.Point(73, 54);
            this.tb_lat.Name = "tb_lat";
            this.tb_lat.Size = new System.Drawing.Size(100, 21);
            this.tb_lat.TabIndex = 3;
            this.tb_lat.Text = "0";
            // 
            // tb_lon
            // 
            this.tb_lon.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Loc_lon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_lon.Location = new System.Drawing.Point(73, 21);
            this.tb_lon.Name = "tb_lon";
            this.tb_lon.Size = new System.Drawing.Size(100, 21);
            this.tb_lon.TabIndex = 2;
            this.tb_lon.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "纬度:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "经度:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_stall);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(219, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 70);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "车位设置";
            // 
            // tb_stall
            // 
            this.tb_stall.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Stall_total", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_stall.Location = new System.Drawing.Point(73, 28);
            this.tb_stall.Name = "tb_stall";
            this.tb_stall.Size = new System.Drawing.Size(100, 21);
            this.tb_stall.TabIndex = 1;
            this.tb_stall.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "总车位:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_masterid);
            this.groupBox1.Controls.Add(this.tb_master);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(220, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "权限信息";
            // 
            // tb_masterid
            // 
            this.tb_masterid.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Owner_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_masterid.Enabled = false;
            this.tb_masterid.Location = new System.Drawing.Point(72, 89);
            this.tb_masterid.Name = "tb_masterid";
            this.tb_masterid.Size = new System.Drawing.Size(100, 21);
            this.tb_masterid.TabIndex = 1;
            // 
            // tb_master
            // 
            this.tb_master.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Owner", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_master.Enabled = false;
            this.tb_master.Location = new System.Drawing.Point(72, 55);
            this.tb_master.Name = "tb_master";
            this.tb_master.Size = new System.Drawing.Size(100, 21);
            this.tb_master.TabIndex = 1;
            // 
            // tb_id
            // 
            this.tb_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Park_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(72, 20);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 21);
            this.tb_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "主人ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主人:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(344, 367);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(263, 366);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 14;
            this.btn_upload.Text = "上传地图";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // Settings_park
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(433, 401);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings_park";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "停车场设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onFormClosing);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_jiage1;
        private System.Windows.Forms.TextBox tb_jiage2;
        private System.Windows.Forms.TextBox tb_beizhu2;
        private System.Windows.Forms.TextBox tb_beizhu1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_jishi;
        private System.Windows.Forms.RadioButton rb_jici;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_lat;
        private System.Windows.Forms.TextBox tb_lon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_stall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_masterid;
        private System.Windows.Forms.TextBox tb_master;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_upload;
    }
}