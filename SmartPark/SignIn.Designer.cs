namespace SmartPark
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.tb_psd = new System.Windows.Forms.TextBox();
            this.btn_signin = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(176, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(176, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码:";
            // 
            // tb_account
            // 
            this.tb_account.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_account.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Account", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_account.Location = new System.Drawing.Point(217, 211);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(100, 21);
            this.tb_account.TabIndex = 2;
            this.tb_account.Text = global::SmartPark.Properties.Settings.Default.Account;
            // 
            // tb_psd
            // 
            this.tb_psd.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_psd.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SmartPark.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_psd.Location = new System.Drawing.Point(217, 249);
            this.tb_psd.Name = "tb_psd";
            this.tb_psd.PasswordChar = '*';
            this.tb_psd.Size = new System.Drawing.Size(100, 21);
            this.tb_psd.TabIndex = 3;
            this.tb_psd.Text = global::SmartPark.Properties.Settings.Default.Password;
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.Transparent;
            this.btn_signin.Location = new System.Drawing.Point(158, 291);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(75, 23);
            this.btn_signin.TabIndex = 4;
            this.btn_signin.Text = "登录";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.Location = new System.Drawing.Point(283, 291);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "注册";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(152, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "智能车位管理系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::SmartPark.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(178, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 144);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.tb_psd);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.TextBox tb_psd;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}