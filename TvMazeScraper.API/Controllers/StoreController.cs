﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TvMazeScraper.API.Data.Interfaces;
using TvMazeScraper.API.Data.Providers;
using TvMazeScraper.API.Models;

namespace TvMazeScraper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly ICastShowStorager _storager;
        public StoreController(ICastShowStorager storager)
        {
            this._storager = storager;
        }

        /// <summary>
        /// Insert a new Show and Casts
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}/save")]
        public async Task<ActionResult<string>> StoreCastShow(int id)
        {
            var res = await _storager.StoreCastShow(id);

            return res;
        }

        /// <summary>
        /// Update a previous stored Cast Show
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}/update")]
        public async Task<ActionResult<string>> UpdateCastShow(int id)
        {
            var res = await _storager.UpdateCastShow(id);

            return res;
        }
    }
}