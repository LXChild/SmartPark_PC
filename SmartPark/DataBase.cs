using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

namespace SmartPark
{
    class Database
    {
        private static string REQUEST_METHOD = "POST";

        public static int ACTION_INSERT_PARK_INFO = 0;
        public static int ACTION_UPDATE_PARK_INFO = 1;
        public static int ACTION_QUERY_PARK_INFO = 2;

        public static int ACTION_INSERT_PARK_OWNER = 3;
        public static int ACTION_QUERY_PARK_OWNER = 4;

        public static int ACTION_UPDATE_STALL_INFO = 5;


        private static string INSERT_PARK_INFO_URL = "http://www.lxchildformtest.sinaapp.com/insertParkInfo.php";
        private static string UPDATE_PARK_INFO_URL = "http://www.lxchildformtest.sinaapp.com/updateParkInfo.php";
        private static string QUERY_PARK_INFO_URL = "http://www.lxchildformtest.sinaapp.com/queryPark.php";


        private static string INSERT_PARK_OWNER_URL = "http://www.lxchildformtest.sinaapp.com/insertParkOwner.php";
        private static string QUERY_PARK_OWNER_URL = "http://www.lxchildformtest.sinaapp.com/queryOwner.php";

        private static string UPDATE_STALL_INFO_URL = "http://www.lxchildformtest.sinaapp.com/updateStallInfo.php";

        private static string UPLOAD_PARK_MAP_URL = "http://www.lxchildformtest.sinaapp.com/uploadFiles.php";

        //string phone_num, string password, string parkname, int stall_total, string address, double loc_lon, double loc_lat, string price_type, string type1_name, string type2_name, string type1_price, string type2_price
        public string requestServer(int action, Dictionary<string, string> dic_params)
        {
            WebRequest request = null;
            try
            {
                // Create a request using a URL that can receive a post. 
                switch (action)
                {
                    case 0:
                        request = WebRequest.Create(INSERT_PARK_INFO_URL);
                        break;
                    case 1:
                        request = WebRequest.Create(UPDATE_PARK_INFO_URL);
                        break;
                    case 2:
                        request = WebRequest.Create(QUERY_PARK_INFO_URL);
                        break;
                    case 3:
                        request = WebRequest.Create(INSERT_PARK_OWNER_URL);
                        break;
                    case 4:
                        request = WebRequest.Create(QUERY_PARK_OWNER_URL);
                        break;
                    case 5:
                        request = WebRequest.Create(UPDATE_STALL_INFO_URL);
                        break;
                    default:
                        break;
                }

                if (request != null)
                {
                    // Set the Method property of the request to POST.
                    request.Method = REQUEST_METHOD;

                    // Create POST data and convert it to a byte array.
                    string post_params = null;
                    int i = 0;
                    foreach (KeyValuePair<string, string> param in dic_params)
                    {
                        if (i == 0)
                        {
                            post_params += param.Key + "=" + param.Value;
                        }
                        else
                        {
                            post_params += "&" + param.Key + "=" + param.Value;
                        }
                        i++;
                    }


                    byte[] byteArray = Encoding.UTF8.GetBytes(post_params);
                    // Set the ContentType property of the WebRequest.
                    request.ContentType = "application/x-www-form-urlencoded";
                    // Set the ContentLength property of the WebRequest.
                    request.ContentLength = byteArray.Length;
                    // Get the request stream.
                    Stream dataStream = request.GetRequestStream();
                    // Write the data to the request stream.
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    // Close the Stream object.
                    dataStream.Close();
                    // Get the response.
                    WebResponse response = request.GetResponse();
                    // Display the status.
                 //   Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                    // Get the stream containing content returned by the server.
                    dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();
                    // Display the content.
                  //  Console.WriteLine(responseFromServer);
                    // Clean up the streams.
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                    if (!((HttpWebResponse)response).StatusDescription.Equals("OK"))
                    {
                        return "网络连接异常，请检查网络配置！";
                    }
                    return responseFromServer;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        public static string HttpUploadFile(string path)
        {
            // 设置参数
            HttpWebRequest request = WebRequest.Create(UPLOAD_PARK_MAP_URL) as HttpWebRequest;
            CookieContainer cookieContainer = new CookieContainer();
            request.CookieContainer = cookieContainer;
            request.AllowAutoRedirect = true;
            request.Method = "POST";
            string boundary = DateTime.Now.Ticks.ToString("X"); // 随机分隔线
            request.ContentType = "multipart/form-data;charset=utf-8;boundary=" + boundary;
            byte[] itemBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "\r\n");
            byte[] endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");

            int pos = path.LastIndexOf("\\");
            string fileName = path.Substring(pos + 1);

            //请求头部信息 
            StringBuilder sbHeader = new StringBuilder(string.Format("Content-Disposition:form-data;name=\"file\";filename=\"{0}\"\r\nContent-Type:application/octet-stream\r\n\r\n", fileName));
            byte[] postHeaderBytes = Encoding.UTF8.GetBytes(sbHeader.ToString());

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] bArr = new byte[fs.Length];
            fs.Read(bArr, 0, bArr.Length);
            fs.Close();

            Stream postStream = request.GetRequestStream();
            postStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
            postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
            postStream.Write(bArr, 0, bArr.Length);
            postStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            postStream.Close();

            //发送请求并获取相应回应数据
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream instream = response.GetResponseStream();
            StreamReader sr = new StreamReader(instream, Encoding.UTF8);
            //返回结果网页（html）代码
            string content = sr.ReadToEnd();
            return content;
        }
    }
}
