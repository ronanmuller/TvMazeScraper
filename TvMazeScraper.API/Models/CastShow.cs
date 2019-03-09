using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TvMazeScraper.API.Models
{
    public class CastShow
    {
        public int CastId { get; set; }
        public virtual Cast Cast { get; set; }
        public int ShowId { get; set; }
        public virtual Show Show { get; set; }
    }
}
