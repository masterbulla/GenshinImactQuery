﻿using System.Threading.Tasks;
using RestSharp;

namespace GenshinImpactProfileQuery.Utils
{
    public static class HttpTools
    {
        public static async Task<IRestResponse> GetAsync(string uid)
        {
            //https://api-takumi.mihoyo.com/game_record/genshin/api/index?server=cn_gf01&role_id=112075042

            var client = new RestClient(
                $"https://api-takumi.mihoyo.com/game_record/genshin/api/index?server=cn_gf01&role_id={uid}");

            client.AddDefaultHeader("Accept",
                "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            client.AddDefaultHeader("Accept-Encoding", "gzip, deflate");
            client.AddDefaultHeader("Accept-Language", "zh-CN,zh;q=0.9,zh-HK;q=0.8");
            client.AddDefaultHeader("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.102 Safari/537.36");

            return await client.ExecuteAsync(new RestRequest(Method.GET));
        }
    }
}