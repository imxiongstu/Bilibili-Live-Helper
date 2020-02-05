using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace Bilibili_Live_Helper
{
    //为B站HTTP操作专门定义的工具类
    public static class BiliHelper
    {
        [System.Serializable]
        public static class Data
        {
            public static CookieContainer BiliCookie;
        }

        public static string BiliGetRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = new CookieContainer();
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            using (StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }
        public static string BiliGetRequest(string url, CookieContainer cookie)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = new CookieContainer();
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.CookieContainer = cookie;
            using (StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }

        public static string BiliPostRequest(string url, string postData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = new CookieContainer();
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetBytes(postData).Length);
            }
            using (StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }
        public static string BiliPostRequest(string url, string postData, CookieContainer myCookieContainer)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = myCookieContainer;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetBytes(postData).Length);
            }
            using (StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }
        public static string BiliPostRequest(string url, string postData, out CookieContainer myCookieContainer)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = new CookieContainer();
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetBytes(postData).Length);
            }
            using (StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                myCookieContainer = request.CookieContainer;
                return reader.ReadToEnd();
            }
        }

        public static string BiliSendGift(string roomId, string giftId, string giftNum, string bagId)
        {
            string anchorInfoHost = "https://api.live.bilibili.com/xlive/web-room/v1/index/getInfoByRoom?room_id=";
            JObject anchorInfoJson = JObject.Parse(BiliGetRequest(anchorInfoHost + roomId));
            string uid = anchorInfoJson["data"]["room_info"]["uid"].ToString();
            string giftPostData = "gift_id=" + giftId + "&ruid=" + uid + "&gift_num=" + giftNum + "&bag_id=" + bagId + "&biz_id=" + roomId;
            return BiliHelper.BiliPostRequest("https://api.live.bilibili.com/gift/v2/live/bag_send", giftPostData, BiliHelper.Data.BiliCookie);
        }
    }
}
