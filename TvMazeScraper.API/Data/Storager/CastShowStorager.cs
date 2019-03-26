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
        public async Task<string> StoreCastShow(int idShow)
        {
            try
            {
                // Get show from database using idShow
                var show = await _context.Shows.FindAsync(idShow);

                List<CastShow> listNewCastShow = new List<CastShow>();

                // if show == null => store new show using httpProvider
                if (show == null)
                {
                    using (var transaction = _context.Database.BeginTransaction())
                    {

                        CastShowPublicResponse response = await CastShowHttpProvider.GetPublicShowCast(idShow);

                        if (response != null)
                        {
                            var newShow = new Show()
                            {
                                Id = response.Id,
                                Name = response.Name
                            };

                            foreach (var auxCast in response._embedded.cast)
                            {
                                var newCast = new Cast()
                                {
                                    Id = auxCast.person.Id,
                                    Name = auxCast.person.Name,
                                    Birthday = auxCast.person.Birthday
                                };

                                var storedCastShow = listNewCastShow.Find(x => x.CastId == auxCast.person.Id && x.ShowId == response.Id);
                                if (storedCastShow == null)
                                {
                                    var castShow = new CastShow { Cast = newCast, Show = newShow };
                                    await _context.AddRangeAsync(castShow);
                                    listNewCastShow.Add(castShow);
                                }
                            }

                            await _context.SaveChangesAsync();

                            // Commit transaction if all commands succeed, transaction will auto-rollback
                            // when disposed if either commands fails
                            transaction.Commit();
                        }
                        else
                            return "Show not found";

                    }

                }
                else
                    return "Show is already stored. Try update";

            }
            catch (Exception ex)
            {
                return "Error";
            }


            return "Success";

        }

        public async Task<string> UpdateCastShow(int id)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
