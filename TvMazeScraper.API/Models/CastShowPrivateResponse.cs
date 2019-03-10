using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TvMazeScraper.API.Models
{
    public class CastShowPrivateResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Cast> cast { get; set; }
    }
}
