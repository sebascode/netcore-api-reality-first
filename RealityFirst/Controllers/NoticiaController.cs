using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model = RealityFirst.Models;
using RealityFirst.DBContext;
using System.Linq;

namespace RealityFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiaController : ControllerBase
    {
        private readonly IList<Model.Noticia> list = DB.getNoticias();

        private readonly ILogger<NoticiaController> _logger;

        public NoticiaController(ILogger<NoticiaController> logger)
        {
            _logger = logger;
        }

        // GET: api/Noticia
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(list);
        }

        // GET: api/Noticia/5
        [HttpGet("{id}", Name = "GetNoticia")]
        public IActionResult Get(int id)
        {
            Model.Noticia Noticia = list.FirstOrDefault(x => x.Id == id);
            if (Noticia == null)
            {
                return NotFound();
            }
            return Ok(Noticia);
        }

        // POST: api/Noticia
        [HttpPost]
        public void Post([FromBody] Model.Noticia value)
        {
            value.Id = list.Max(x => x.Id) + 1;
            list.Add(value);
        }

        // PUT: api/Noticia/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Model.Noticia value)
        {
            Model.Noticia obj = list.FirstOrDefault(x => x.Id == id);
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
            Model.Noticia obj = list.FirstOrDefault(x => x.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            list.Remove(obj);
            return Ok();
        }
    }
}
