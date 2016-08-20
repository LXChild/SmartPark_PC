using System;
using System.Windows.Forms;

namespace SmartPark
{
    public partial class Settings_stall : Form
    {
        private SmartPark mainForm;
        public Settings_stall(SmartPark mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {

        }
    }
}
