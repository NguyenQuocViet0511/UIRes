using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.DAL.API
{
    class BaseAPI : BaseAPIInterface
    {
        private static BaseAPI instance;

        public static BaseAPI Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaseAPI();
                return instance;

            }
            set => instance = value;
        }

        public String All(string url, NameValueCollection Table, string Method)
        {

                    WebClient Client = new WebClient();
                    Client.Encoding = Encoding.UTF8;
                    var responsebytes = Client.UploadValues(url, Method, Table);
                    string reponsive = UnicodeEncoding.UTF8.GetString(responsebytes);
                    return reponsive;
     


        }


        public string Get(string url)
        {
            WebClient Client = new WebClient();
            try
            {
                using (Client.OpenRead(url))
                {
                    var json = Client.DownloadString(url);
                    return json;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi Máy Chủ Hoặc Không Có Phản Hồi Vui Lòng Thử Lại !");
                return null;
            }


        }
    }
}
