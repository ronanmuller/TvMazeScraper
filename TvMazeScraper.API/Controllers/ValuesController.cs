﻿
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TvMazeScraper.API.Data.Interfaces;
using TvMazeScraper.API.Models;

namespace TvMazeScraper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICastShowProvider _provider;

        public ValuesController(ICastShowProvider provider)
        {
            this._provider = provider;
        }     

        // GET api/values/1/5
        /// <summary>
        /// Get a paginated list of Shows and respectives cast
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet("{page}/{pageSize}")]
        public async Task<ActionResult<PaginatedList<CastShowPrivateResponse>>> Get(int page, int pageSize)
        {

            var res = await _provider.GetCastShow(page, pageSize);

            if (res == null)
                return NotFound();

            return res;
        }
    }
}
