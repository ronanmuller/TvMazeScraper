using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TvMazeScraper.API.Models;

namespace TvMazeScraper.API.Data.Interfaces
{
    public interface ICastShowProvider
    {
        Task<PaginatedList<CastShowPrivateResponse>> GetCastShow(int numPage, int numItems);
    }
}
