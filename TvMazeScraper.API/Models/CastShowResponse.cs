using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TvMazeScraper.API.Models
{
    public class CastShowResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Cast> Casts { get; set; }
    }
}
