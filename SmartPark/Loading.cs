using System.Windows.Forms;

namespace SmartPark
{
    class Loading
    {
        public static SplashWindow splash;
        public static void showLoadingDialog()
        {
            splash = new SplashWindow();
            splash.Show();
            splash.Activate();
            Application.DoEvents();

        }

        public static void hideLoadingDialog()
        {
            splash.Close();
            splash.Dispose();
        }
    }
}
