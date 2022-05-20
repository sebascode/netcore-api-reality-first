using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model = RealityFirst.Models;
using RealityFirst.DBContext;

namespace RealityFirst.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class ArtistaController : ControllerBase
    {
        IList<Model.Artista> list = DB.getArtistas();

        private readonly ILogger<ArtistaController> _logger;

        public ArtistaController(ILogger<ArtistaController> logger)
        {
            _logger = logger;
        }

        // GET: api/Artista
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(list);
        }

        // GET: api/Artista/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            Model.Artista artista = list.FirstOrDefault(x => x.Id == id);
            if (artista == null)
            {
                return NotFound();
            }
            return Ok(artista);
        }

        // POST: api/Artista
        [HttpPost]
        public void Post([FromBody] Model.Artista value)
        {
            value.Id = list.Max(x => x.Id) + 1;
            list.Add(value);
        }

        // PUT: api/Artista/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Model.Artista value)
        {
            Model.Artista obj = list.FirstOrDefault(x => x.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            value.Id = id;
            obj = value;

            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Model.Artista obj = list.FirstOrDefault(x => x.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            list.Remove(obj);
            return Ok();
        }
    }
}
