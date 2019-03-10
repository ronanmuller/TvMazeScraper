using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TvMazeScraper.API.Models
{
    public class CastShow
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CastId { get; set; }
        public virtual Cast Cast { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShowId { get; set; }
        public virtual Show Show { get; set; }
    }
}
