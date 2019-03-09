using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TvMazeScraper.API.Models;

namespace TvMazeScraper.API.Data.Providers
{
    public static class CastShowHttpProvider
    {

        const string ShowEndpoint = "http://api.tvmaze.com/shows";
        static HttpClient client = new HttpClient();

        public static async Task<string> GetShowCast(int id)
        {
            string res = "";
            HttpResponseMessage response = await client.GetAsync(ShowEndpoint + id + "?embed=cast");
            if (response.IsSuccessStatusCode)
            {
                res = await response.Content.ReadAsAsync<string>();
            }
            return res;
        }
    }
}
