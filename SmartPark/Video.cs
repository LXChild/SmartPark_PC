using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SmartPark
{
    class Video
    {
        public  bool flag = true;
        public delegate void RecievedFrameEventHandler(byte[] data);
        public event RecievedFrameEventHandler RecievedFrame;
        public static ArrayList allDriver = new ArrayList();//所有视频硬件信息
        public AviCapture.CAPDRIVERCAPS CapDriverCAPS;//捕获驱动器的能力，如有无视频叠加能力、有无控制视频源、视频格式的对话框等；
        public AviCapture.CAPSTATUS CapStatus;//该结构用于保存视频设备捕获窗口的当前状态，如图像的宽、高等
        public AviCapture.CAPTUREPARMS Capparms;
        private IntPtr mControlPtr;//显示设备句柄
        public IntPtr lwndC;
        private int mWidth;//视频宽度
        private int mHeight;//视频高度
        public Bitmap ba;

        /// <summary>
        ///  构造函数   
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Video(IntPtr handle, int width, int height)
        {
            CapDriverCAPS = new AviCapture.CAPDRIVERCAPS();//捕获驱动器的能力，如有无视频叠加能力、有无控制视频源、视频格式的对话框等；
            CapStatus = new AviCapture.CAPSTATUS();//该结构用于保存视频设备捕获窗口的当前状态，如图像的宽、高等

            mControlPtr = handle;
            mWidth = width;
            mHeight = height;
            //---------------------------------------------------以下为获得机器上所有视频设备

        }

        /// <summary>
        /// 方法说明：获得本机器上的所有视频设备
        /// </summary>
        //public static void GetAllDriver()
        //{
        //    for (int i = 0; i < 6; i++)
        //    {
        //        StringBuilder name = new StringBuilder(128);
        //        StringBuilder version = new StringBuilder(128);
        //        if (AviCapture.capGetDriverDescription(i, name, 128, version, 128))//获得已经安装的 捕获的设备 名称和版本信息
        //        {
        //            AviCapture.VideoCaptureDevice vcd = new VideoCaptureDevice(i, name.ToString(), version.ToString());
        //            allDriver.Add(vcd);
        //        }
        //    }
        //}

        public void get()
        {
            AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_GET_SEQUENCE_SETUP, AviCapture.SizeOf(Capparms), ref Capparms);
        }

        public void set()
        {
            AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SET_SEQUENCE_SETUP, AviCapture.SizeOf(Capparms), ref Capparms);
        }


               /// <summary>
        ///  关闭摄像头  
        /// </summary>
        public void CloseWebcam(int index)            //关闭摄像头
        {
            CapDriverCAPS.fCaptureInitialized = false;
            AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_DRIVER_DISCONNECT, index, 0);
        }
        /// <summary>
        ///  开启摄像头 
        /// </summary>
        public void StartWebCam()           //开启摄像头
        {
            this.lwndC = AviCapture.capCreateCaptureWindow("", AviCapture.WS_CHILD | AviCapture.WS_VISIBLE, 0, 0, mWidth, mHeight, mControlPtr, 0);//AVICap类的捕捉窗口
            //AviCapture.FrameEventHandler FrameEventHandler = new AviCapture.FrameEventHandler(framecallback);
            //AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SET_CALLBACK_ERROR, 0, 0);//注册错误回调函数
            //AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SET_CALLBACK_STATUS, 0, 0);//注册状态回调函数 
            //AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SET_CALLBACK_VIDEOSTREAM, 0, 0);//注册视频流回调函数
            //AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SET_CALLBACK_FRAME, 0, FrameEventHandler);//注册帧回调函数

            //if (!CapDriverCAPS.fCaptureInitialized)//判断当前设备是否被其他设备连接已经连接
            //{

            if (AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_DRIVER_CONNECT, 0, 0))
            {
                //-----------------------------------------------------------------------
                AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_DRIVER_GET_CAPS, AviCapture.SizeOf(CapDriverCAPS), ref CapDriverCAPS);//获得当前视频 CAPDRIVERCAPS定义了捕获驱动器的能力，如有无视频叠加能力、有无控制视频源、视频格式的对话框等；
                AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_GET_STATUS, AviCapture.SizeOf(CapStatus), ref CapStatus);//获得当前视频流的尺寸 存入CapStatus结构

                AviCapture.BITMAPINFO bitmapInfo = new AviCapture.BITMAPINFO();//设置视频格式 (height and width in pixels, bits per frame). 
                bitmapInfo.bmiHeader = new AviCapture.BITMAPINFOHEADER();
                bitmapInfo.bmiHeader.biSize = AviCapture.SizeOf(bitmapInfo.bmiHeader);
                bitmapInfo.bmiHeader.biWidth = mWidth;
                bitmapInfo.bmiHeader.biHeight = mHeight;
                bitmapInfo.bmiHeader.biPlanes = 1;
                bitmapInfo.bmiHeader.biBitCount = 24;
                AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SET_PREVIEWRATE, 34, 0);//设置在PREVIEW模式下设定视频窗口的刷新率 设置每34毫秒显示一帧，即显示帧速为每秒29帧
                AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SET_SCALE, 1, 0);//打开预览视频的缩放比例
                AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SET_VIDEOFORMAT, AviCapture.SizeOf(bitmapInfo), ref bitmapInfo);


                AviCapture.CAPTUREPARMS captureparms = new AviCapture.CAPTUREPARMS();
                AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_GET_SEQUENCE_SETUP, AviCapture.SizeOf(captureparms), ref captureparms);
                if (CapDriverCAPS.fHasOverlay)
                {
                    AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SET_OVERLAY, 1, 0);//启用叠加 注：据说启用此项可以加快渲染速度    
                }
                AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SET_PREVIEW, 1, 0);//设置显示图像启动预览模式 PREVIEW
                AviCapture.SetWindowPos(this.lwndC, 0, 0, 0, mWidth, mHeight, AviCapture.SWP_NOZORDER | AviCapture.SWP_NOMOVE);//使捕获窗口与进来的视频流尺寸保持一致

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("未能连接设备，请检查设备连接及是否有其他程序占用！");
                flag = false;
                
            } 
        }

        /// <summary>
        /// 抓图到制定的路径
        /// </summary>
        /// <param name="path"></param>
        public void grabImage(string path)
        {
            IntPtr hBmp = Marshal.StringToHGlobalAnsi(path);
            AviCapture.SendMessage(lwndC, AviCapture.WM_CAP_FILE_SAVEDIB, 0, hBmp.ToInt32());
        }

        /// <summary>
        /// 弹出视频格式设置对话框  
        /// </summary>
        public void setCaptureFormat()
        {
            AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_DLG_VIDEOFORMAT, 0, 0);
            // 是否由新的图像尺寸？
            // 如果有，发送通知给父窗口，告诉它尺寸改变了

            AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_GET_STATUS, AviCapture.SizeOf(CapStatus), ref CapStatus);//获得当前视频流的尺寸 存入CapStatus结构
        }


        ///   <summary>   
        ///   开始录像
        ///   </summary>   
        ///   <param   name="path">要保存录像的路径</param>   
        public void StarKinescope(string path)
        {
            IntPtr hBmp = Marshal.StringToHGlobalAnsi(path);
            AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_FILE_SET_CAPTURE_FILE, 0, hBmp.ToInt32());
            AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_SEQUENCE, 0, 0);
        }
        /// <summary>
        /// 停止录像
        /// </summary>
        public void StopKinescope()
        {
            AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_STOP, 0, 0);
        }

      

        public void setVideoCompression()
        {
            AviCapture.SendMessage(this.lwndC, AviCapture.WM_CAP_DLG_VIDEOCOMPRESSION, 0, 0);
        }
    }
}
