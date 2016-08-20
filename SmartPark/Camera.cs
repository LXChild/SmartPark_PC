using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPark
{
    public partial class Camera : Form
    {
        private SmartPark mainForm;

        private Video video;
        public Camera(SmartPark mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Camera_Load(object sender, EventArgs e)
        {
            video = new Video(panel_preview.Handle, panel_preview.Width, panel_preview.Height);
            this.VideoShow();
        }
        public void VideoShow()
        {
            video = new Video(panel_preview.Handle, panel_preview.Width, panel_preview.Height);
            video.StartWebCam();
            video.get();
            video.Capparms.fYield = true;
            video.Capparms.fAbortLeftMouse = false;
            video.Capparms.fAbortRightMouse = false;
            video.set();

        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            this.VideoShow();
            video.setVideoCompression();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            video.CloseWebcam(0);
            this.Close();
            this.Dispose();
        }
    }
}
