namespace SmartPark
{
    partial class ProfitStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitStatus));
            this.tabControl_profitStatus = new System.Windows.Forms.TabControl();
            this.tabPage_carNum = new System.Windows.Forms.TabPage();
            this.pictureBox_chart_carNum = new System.Windows.Forms.PictureBox();
            this.tabPage_profit = new System.Windows.Forms.TabPage();
            this.pictureBox_chart_profit = new System.Windows.Forms.PictureBox();
            this.comboBox_week = new System.Windows.Forms.ComboBox();
            this.label_week = new System.Windows.Forms.Label();
            this.label_carport = new System.Windows.Forms.Label();
            this.comboBox_carport = new System.Windows.Forms.ComboBox();
            this.tabControl_profitStatus.SuspendLayout();
            this.tabPage_carNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart_carNum)).BeginInit();
            this.tabPage_profit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart_profit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_profitStatus
            // 
            this.tabControl_profitStatus.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl_profitStatus.Controls.Add(this.tabPage_carNum);
            this.tabControl_profitStatus.Controls.Add(this.tabPage_profit);
            this.tabControl_profitStatus.Location = new System.Drawing.Point(12, 40);
            this.tabControl_profitStatus.Name = "tabControl_profitStatus";
            this.tabControl_profitStatus.SelectedIndex = 0;
            this.tabControl_profitStatus.Size = new System.Drawing.Size(411, 410);
            this.tabControl_profitStatus.TabIndex = 0;
            this.tabControl_profitStatus.SelectedIndexChanged += new System.EventHandler(this.tabControl_profitStatus_SelectedIndexChanged);
            // 
            // tabPage_carNum
            // 
            this.tabPage_carNum.Controls.Add(this.pictureBox_chart_carNum);
            this.tabPage_carNum.Location = new System.Drawing.Point(4, 4);
            this.tabPage_carNum.Name = "tabPage_carNum";
            this.tabPage_carNum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_carNum.Size = new System.Drawing.Size(403, 384);
            this.tabPage_carNum.TabIndex = 0;
            this.tabPage_carNum.Text = "车辆统计";
            this.tabPage_carNum.UseVisualStyleBackColor = true;
            // 
            // pictureBox_chart_carNum
            // 
            this.pictureBox_chart_carNum.Location = new System.Drawing.Point(7, 7);
            this.pictureBox_chart_carNum.Name = "pictureBox_chart_carNum";
            this.pictureBox_chart_carNum.Size = new System.Drawing.Size(390, 371);
            this.pictureBox_chart_carNum.TabIndex = 0;
            this.pictureBox_chart_carNum.TabStop = false;
            // 
            // tabPage_profit
            // 
            this.tabPage_profit.Controls.Add(this.pictureBox_chart_profit);
            this.tabPage_profit.Location = new System.Drawing.Point(4, 4);
            this.tabPage_profit.Name = "tabPage_profit";
            this.tabPage_profit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_profit.Size = new System.Drawing.Size(403, 384);
            this.tabPage_profit.TabIndex = 1;
            this.tabPage_profit.Text = "盈利统计";
            this.tabPage_profit.UseVisualStyleBackColor = true;
            // 
            // pictureBox_chart_profit
            // 
            this.pictureBox_chart_profit.Location = new System.Drawing.Point(7, 7);
            this.pictureBox_chart_profit.Name = "pictureBox_chart_profit";
            this.pictureBox_chart_profit.Size = new System.Drawing.Size(390, 371);
            this.pictureBox_chart_profit.TabIndex = 0;
            this.pictureBox_chart_profit.TabStop = false;
            // 
            // comboBox_week
            // 
            this.comboBox_week.FormattingEnabled = true;
            this.comboBox_week.Location = new System.Drawing.Point(298, 12);
            this.comboBox_week.Name = "comboBox_week";
            this.comboBox_week.Size = new System.Drawing.Size(121, 20);
            this.comboBox_week.TabIndex = 1;
            this.comboBox_week.Text = "上一周";
            // 
            // label_week
            // 
            this.label_week.AutoSize = true;
            this.label_week.Location = new System.Drawing.Point(251, 15);
            this.label_week.Name = "label_week";
            this.label_week.Size = new System.Drawing.Size(41, 12);
            this.label_week.TabIndex = 2;
            this.label_week.Text = "周数：";
            // 
            // label_carport
            // 
            this.label_carport.AutoSize = true;
            this.label_carport.Location = new System.Drawing.Point(16, 15);
            this.label_carport.Name = "label_carport";
            this.label_carport.Size = new System.Drawing.Size(41, 12);
            this.label_carport.TabIndex = 3;
            this.label_carport.Text = "车库：";
            // 
            // comboBox_carport
            // 
            this.comboBox_carport.FormattingEnabled = true;
            this.comboBox_carport.Location = new System.Drawing.Point(63, 12);
            this.comboBox_carport.Name = "comboBox_carport";
            this.comboBox_carport.Size = new System.Drawing.Size(121, 20);
            this.comboBox_carport.TabIndex = 4;
            this.comboBox_carport.Text = "1号车库";
            // 
            // ProfitStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(436, 462);
            this.Controls.Add(this.comboBox_carport);
            this.Controls.Add(this.label_carport);
            this.Controls.Add(this.label_week);
            this.Controls.Add(this.comboBox_week);
            this.Controls.Add(this.tabControl_profitStatus);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProfitStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运营状况";
            this.Load += new System.EventHandler(this.ProfitStatus_Load);
            this.tabControl_profitStatus.ResumeLayout(false);
            this.tabPage_carNum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart_carNum)).EndInit();
            this.tabPage_profit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart_profit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     //   private System.Windows.Forms.ListView lv_profit;
        private System.Windows.Forms.TabControl tabControl_profitStatus;
        private System.Windows.Forms.TabPage tabPage_carNum;
        private System.Windows.Forms.PictureBox pictureBox_chart_carNum;
        private System.Windows.Forms.TabPage tabPage_profit;
        private System.Windows.Forms.ComboBox comboBox_week;
        private System.Windows.Forms.Label label_week;
        private System.Windows.Forms.Label label_carport;
        private System.Windows.Forms.ComboBox comboBox_carport;
        private System.Windows.Forms.PictureBox pictureBox_chart_profit;
    }
}