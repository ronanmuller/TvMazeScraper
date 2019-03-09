using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TvMazeScraper.API.Data.Context;
using TvMazeScraper.API.Data.Interfaces;
using TvMazeScraper.API.Data.Providers;
using TvMazeScraper.API.Models;

namespace TvMazeScraper.API.Data.Storager
{
 
    public class CastShowStorager : ICastShowStorager
    {
        private readonly TvMazeDbContext _context;

        public CastShowStorager(TvMazeDbContext context)
        {
            _context = context;
        }
        public async Task StoreCastShow(int idShow)
        {
            // Get show from database using idShow
            // if show == null => store show using httpProvider

            // for each Cast in Http provider
               // get cast from database
               // if cast == null => store cast

            // get ShowCast from database using showId and castId
               // if showcast == null => store showcast
               // if showcast == null => store showcast

        }
    }
}
