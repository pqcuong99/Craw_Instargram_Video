using Craw_Video.Model;
using Craw_Video.Model.GetUrls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Craw_Video.Controller
{
    public class Instargram_Viewer
    {
        public static string encursor = "";
        public static bool isNext = false;
        public static string  GetId_User(string user_view = "")
        {
            try
            {
                Api_custommer api_ = new Api_custommer();
                string res = api_.GetID_User_Instargram(user_view);
                var cvRes = JsonConvert.DeserializeObject<Response_GetVideo>(res);

                return cvRes.data.user.id;
            }catch (Exception ex)
            {
                return "";
            }
        }
        public static List<string>  Get_Urls_Video(string id_user, bool isnext = false, string endcursor = "")
        {
            Api_custommer api_ = new Api_custommer();
            string res = api_.GetUrl_Videos_User_Instargram(id_user, isnext, endcursor);

            var cvRes = JsonConvert.DeserializeObject<GetItiems_Url_Instargram>(res);
            var arrUrls = cvRes.items;
              
            encursor = cvRes.paging_info.max_id;
            isNext = cvRes.paging_info.more_available;

            return Get_Urls(arrUrls);
        }
        public static List<string> Get_Urls(Item[] items)
        {
            List<string> urls = new List<string>();
            foreach (Item item in items)
            {
                string url = item.media.video_versions[0].url;
                if(url != "") {
                    urls.Add(url);
                }
            }

            return urls;
        }
        
    }
}
