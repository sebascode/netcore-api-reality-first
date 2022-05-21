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
    public class TipoTicketController : ControllerBase
    {
        private readonly IList<Model.TipoTicket> listEstadio = DB.getTipoTicket(TipoEvento.Estadio);
        private readonly IList<Model.TipoTicket> listOtro = DB.getTipoTicket(TipoEvento.Otro);

        private readonly ILogger<TipoTicketController> _logger;

        public TipoTicketController(ILogger<TipoTicketController> logger)
        {
            _logger = logger;
        }

        // GET: api/TipoTicket
        [HttpGet]
        public IActionResult GetEstadio()
        {
            var list = listEstadio.Union(listOtro);
            return Ok(list);
        }

        // GET: api/TipoTicket/5
        [HttpGet("PorId/{id}", Name = "GetPrecios")]
        public IActionResult Get(int id)
        {
            var list = listEstadio.Union(listOtro);
            Model.TipoTicket TipoTicket = list.FirstOrDefault(x => x.Id == id);
            if (TipoTicket == null)
            {
                return NotFound();
            }
            return Ok(TipoTicket);
        }

        // GET: api/TipoTicket/5
        [HttpGet("PorTipo/{id}", Name = "GetPreciosPorTipo")]
        public IActionResult GetPorTipo(int id)
        {
            TipoEvento tipoEvento = (TipoEvento)(id);

            IList<Model.TipoTicket> list =
                tipoEvento == TipoEvento.Estadio ?
                    listEstadio : listOtro;

            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }


        // POST: api/TipoTicket
        [HttpPost]
        public void Post([FromBody] Model.TipoTicket value)
        {
            value.Id = listOtro.Max(x => x.Id) + 1;
            listOtro.Add(value);
        }

        // PUT: api/TipoTicket/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Model.TipoTicket value)
        {
            Model.TipoTicket obj = listOtro.FirstOrDefault(x => x.Id == id);
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
            Model.TipoTicket obj = listOtro.FirstOrDefault(x => x.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            listOtro.Remove(obj);
            return Ok();
        }
    }
}