using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model = RealityFirst.Models;
using RealityFirst.DBContext;

namespace RealityFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private readonly IList<Model.Evento> list = DB.getEventos();

        private readonly ILogger<EventoController> _logger;

        public EventoController(ILogger<EventoController> logger)
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
        [HttpGet("{id}", Name = "GetEvento")]
        public IActionResult Get(int id)
        {
            Model.Evento artista = list.FirstOrDefault(x => x.Id == id);
            if (artista == null)
            {
                return NotFound();
            }
            return Ok(artista);
        }

        // GET: api/Artista/5
        [HttpGet("PorArtista/{id}", Name = "GetEventosPorArtista")]
        public IActionResult GetEventosPorArtista(int id)
        {
            Model.Evento artista = list.FirstOrDefault(x => x.Artista.Id == id);
            if (artista == null)
            {
                return NotFound();
            }
            return Ok(artista);
        }

        // POST: api/Artista
        [HttpPost]
        public void Post([FromBody] Model.Evento value)
        {
            value.Id = list.Max(x => x.Id) + 1;
            list.Add(value);
        }

        // PUT: api/Artista/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Model.Evento value)
        {
            Model.Evento obj = list.FirstOrDefault(x => x.Id == id);
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
            Model.Evento obj = list.FirstOrDefault(x => x.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            list.Remove(obj);
            return Ok();
        }
    }
}