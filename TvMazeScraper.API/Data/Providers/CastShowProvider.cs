using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TvMazeScraper.API.Data.Context;
using TvMazeScraper.API.Data.Interfaces;
using TvMazeScraper.API.Models;

namespace TvMazeScraper.API.Data.Providers
{
    public class CastShowProvider : ICastShowProvider
    {
        private readonly TvMazeDbContext _context;

        public CastShowProvider(TvMazeDbContext tvMazeDbContext)
        {
            this._context = tvMazeDbContext;
        }

        public async Task<PaginatedList<CastShowPrivateResponse>> GetCastShow(int numPage, int numItems)
        {     
            var list = _context.Shows.Select(o => new CastShowPrivateResponse
            {
                id = o.Id,
                name = o.Name,
                cast =  o.Casts.Select(ot => ot.Cast).OrderByDescending(ot => ot.Birthday).ToList()
            });

            var paginationModel = await PaginatedList<CastShowPrivateResponse>.CreateAsync(list, numPage, numItems );

            return paginationModel;
        }
    }
}
