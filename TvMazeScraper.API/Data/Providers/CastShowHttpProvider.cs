using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
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

        public static async Task<CastShowPublicResponse> GetPublicShowCast(int id)
        {
            CastShowPublicResponse model = null;
            string connection = string.Format("{0}{1}{2}", ShowEndpoint, "/" + id, "?embed=cast");
            HttpResponseMessage response = await client.GetAsync(connection);
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsStringAsync();
                 model = JsonConvert.DeserializeObject<CastShowPublicResponse>(res);
            }
            else
                return null;

            return model;
        }
    }
}
