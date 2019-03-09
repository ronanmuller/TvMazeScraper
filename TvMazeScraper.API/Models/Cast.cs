using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TvMazeScraper.API.Models
{
    public class Cast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public virtual ICollection<CastShow> CastShow { get; set; }
    }
}
