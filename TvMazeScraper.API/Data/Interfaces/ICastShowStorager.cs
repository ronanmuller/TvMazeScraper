using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TvMazeScraper.API.Models;

namespace TvMazeScraper.API.Data.Interfaces
{
    public interface ICastShowStorager
    {
        Task<string> StoreCastShow(int idShow);
        Task<string> UpdateCastShow(int id);
    }
}
