
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

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CastShowResponse>>Get(int id)
        {
            var res = await _provider.GetCastShow(id);
            return res;
        }      
    }
}
