using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TvMazeScraper.API.Data.Context;
using TvMazeScraper.API.Data.Interfaces;
using TvMazeScraper.API.Models;

namespace TvMazeScraper.API.Data.Providers
{
    public class ShowCastProvider : ICastShowProvider
    {
        private readonly TvMazeDbContext _context;

        public ShowCastProvider(TvMazeDbContext context)
        {
            _context = context;
        }

        public async Task<CastShowResponse> GetCastShow(int showId)
        {          
            // get from database, format like CastShowResponse and return

            return null;
        }
    }
}
