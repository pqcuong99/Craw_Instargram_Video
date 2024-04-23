using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Craw_Video.Controller
{
    public class Api_custommer
    {
        public String GetID_User_Instargram(string user_name)
        {
            try
            {
                Chilkat.Http http = new Chilkat.Http();
                string url = $"https://www.instagram.com/api/v1/users/web_profile_info/?username={user_name}";
                
                http.SetRequestHeader("Accept", "*/*");
                //http.SetRequestHeader("X-Nextjs-Data", "1");
                http.SetRequestHeader("Accept-Language", "en,vi;q=0.9,vi-VN;q=0.8");
                http.SetRequestHeader("Sec-Fetch-Site", "same-origin");
                http.SetRequestHeader("Referer", $"https://www.instagram.com/{user_name}/reels/");
                http.SetRequestHeader("Viewport-Width", "1109");
                http.SetRequestHeader("X-Asbd-Id", "129477");
                http.SetRequestHeader("X-Csrftoken", "AFKEnII1VHrdg1SSXfCS40vq6FtgR9uq");
                http.SetRequestHeader("X-Ig-App-Id", "936619743392459");
                http.SetRequestHeader("Cookie", "mid=ZavGTQALAAF59aA8q-xWUPGbd49n; ig_did=1A79E71D-504B-4DF0-B06A-20063A1F3D93; datr=TcarZWZRKXfc0oe1nvGoSdF4; fbm_124024574287414=base_domain=.instagram.com; ig_nrcb=1; ps_l=0; ps_n=0; csrftoken=AFKEnII1VHrdg1SSXfCS40vq6FtgR9uq; ds_user_id=9388035662; shbid=\"8894\\0549388035662\\0541740924700:01f76b37a361a51c6d0f733d9759ee1d698e9e1c8b58bacf1efec107f5cc021a8d55e303\"; shbts=\"1709388700\\0549388035662\\0541740924700:01f7bf60c0f36193ea135813dcca312e09e531731f1647e00f3877714ad6b877193acce4\"; sessionid=9388035662%3A5yoOSwee8Ticqa%3A10%3AAYek-Rm_O3Ivwy2Up2H6sMtduAWl7r3HCCIiShFzbw; rur=\"FRC\\0549388035662\\0541740924739:01f7ba493172602f92ef3026478543e25c7abb224011ee251a4b1687827ac2dd8d0e31b5\"; fbsr_124024574287414=JNQixnlp4r8VGa1CCefM-ZbhJ8zrkWlSjmmxQiJCo7U.eyJ1c2VyX2lkIjoiMTAwMDE3MDI5MDU5ODU4IiwiY29kZSI6IkFRQnBOR3RHUEF2eGwydlRYR0R4bmR3LXVkWktHZ3JNQVdfYzgtQk0zY253clBYRFNoVm9vMzhKY21wM1I4aGhLemd4MDE3bTVZZ1ltdk1zLXdoMDRXc0FxZEhnbm1qN3MzWnpXcmlJZm9BLVpJMmpzMGlqRUlsc09XSHBNUVdMS0RSd0JHcnhhVDktX0RZQXZDVUlJYlcwR1BES3QyQ256TjVyR2x0dmctREdnaXh1YkZkS3RvUFFaZ0M0M0l5Sm5tLXBTazg5VFN5WVVNWkFoVDY3Z25udGhRaU1YUDRlanJtWjI5dm03aVNYcGV2bzl1VFlEcWZKeG9LZlp1QkFCQVRMTDVGSDhxQkNtZWtXOWtOSklzTG01alVSWjhiQUlDRk1uZVR2ZmduSkM2RTJmc3RMeVdKM2xKUDB2ZjEzcERmcG9hYXdvMGp6MTJ5LS1uaVBGYmxBX05POHc5NHNmSXBXbHg5ZHFlRFJEZyIsIm9hdXRoX3Rva2VuIjoiRUFBQnd6TGl4bmpZQk82Sm1HUGhaQlg1eDNTc2FDSlpCTTBaQjR0OU9INWU0TEY5ZHJpRjFtNUVsY2tsem92TTF2elpBcjhOVktaQ0FXVno4b1pCcVh1UHBlWkNYZEx5NEVGUVZLM1ZmSjJ1NUJub0VjSG9yTUk1MHZzTVhmdnlUMlB2bTl0dkgzM1k1YzlaQzRmNlZaQnhFdE8wSWNsQXVxdDJLYXVEOGFSaTJmYWV0aGJaQVpCVGt6VmFaQlVkYXBsRjN3U0M1a2ZvWkQiLCJhbGdvcml0aG0iOiJITUFDLVNIQTI1NiIsImlzc3VlZF9hdCI6MTcwOTM5ODgzMn0");
                http.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
                Chilkat.HttpResponse httpResponse = http.QuickGetObj(url);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String GetUrl_Videos_User_Instargram(string uid,bool isNext = false,string endcursor = "")
        {
            try
            {
                Chilkat.Http http = new Chilkat.Http();
                string url = $"https://www.instagram.com/api/v1/clips/user/";
                string json = $"include_feed_video=true&page_size=12&target_user_id={uid}";
                if (isNext && endcursor != "")
                {
                    json = $"include_feed_video=true&max_id={endcursor}&page_size=12&target_user_id={uid}";
                }
                http.SetRequestHeader("Accept", "*/*");
                //http.SetRequestHeader("X-Nextjs-Data", "1");
                http.SetRequestHeader("Accept-Language", "en,vi;q=0.9,vi-VN;q=0.8");
                http.SetRequestHeader("Sec-Fetch-Site", "same-origin");
                http.SetRequestHeader("Referer", $"https://www.instagram.com/");
                http.SetRequestHeader("Viewport-Width", "1109");
                http.SetRequestHeader("X-Asbd-Id", "129477");
                http.SetRequestHeader("X-Csrftoken", "QKqHPhERUkp9z3vrf4hao_");
                http.SetRequestHeader("X-Ig-App-Id", "936619743392459");
                http.SetRequestHeader("Cookie", "csrftoken=QKqHPhERUkp9z3vrf4hao_; ps_n=0; ps_l=0; ig_did=E864514C-8672-41CF-A3FB-0BE1B87F729F; ig_nrcb=1; mid=ZeM6mwALAAE0tuVQduGaTAYTdNUQ");
                http.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
                Chilkat.HttpResponse httpResponse = http.PostJson(url , json);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
