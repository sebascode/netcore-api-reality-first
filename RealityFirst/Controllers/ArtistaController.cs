using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model = RealityFirst.Models;

namespace RealityFirst.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistaController : ControllerBase
    {
        IList<Model.Artista> list = new List<Model.Artista>();

        private readonly ILogger<ArtistaController> _logger;

        public ArtistaController(ILogger<ArtistaController> logger)
        {
            _logger = logger;

            list = new List<Model.Artista> {
                new Model.Artista
                {
                    Id = 1,
                    Nombre = "Shakira",
                    Genero = "Pop",
                    FechaNacimiento = new DateTime(19770203),
                    LugarNacimiento = "Barranquilla",
                    PaisNacimiento = "Colombia"
                },
                new Model.Artista
                {
                    Id = 2,
                    Nombre = "Metallica",
                    Genero = "Rock/Metal",
                    FechaNacimiento = new DateTime(01021983),
                    LugarNacimiento = "San Francisco",
                    PaisNacimiento = "Estados Unidos"
                },
                new Model.Artista
                {
                    Id = 3,
                    Nombre = "Bad bunny",
                    Genero = "Trap/Raggaeton",
                    FechaNacimiento = new DateTime(10031994),
                    LugarNacimiento = "Almirante Sur",
                    PaisNacimiento = "Puerto Rico"
                },
                new Model.Artista
                {
                    Id = 4,
                    Nombre = "Residente",
                    Genero = "Rap/Raggaeton",
                    FechaNacimiento = new DateTime(23021978),
                    LugarNacimiento = "Hato Rey Central",
                    PaisNacimiento = "San Juan/Puerto Rico"
                },
                new Model.Artista
                {
                    Id = 5,
                    Nombre = "Lit Killah",
                    Genero = "Trap/Hip Hop",
                    FechaNacimiento = new DateTime(04101992),
                    LugarNacimiento = "Gonzalez Catalán",
                    PaisNacimiento = "Argentina"
                },
                new Model.Artista
                {
                    Id = 6,
                    Nombre = "Tini",
                    Genero = "Pop",
                    FechaNacimiento = new DateTime(21031997),
                    LugarNacimiento = "Buenos Aires",
                    PaisNacimiento = "Argentina"
                },
                new Model.Artista
                {
                    Id = 7,
                    Nombre = "L-Gante",
                    Genero = "Trap/Cumbia 420",
                    FechaNacimiento = new DateTime(05042000),
                    LugarNacimiento = "General Rodriguez",
                    PaisNacimiento = "Argentina"
                },
                new Model.Artista
                {
                    Id = 8,
                    Nombre = "AK4:20",
                    Genero = "Trap/Rap",
                    FechaNacimiento = new DateTime(19122001),
                    LugarNacimiento = "Talca",
                    PaisNacimiento = "Chile"
                },
                new Model.Artista
                {
                    Id = 9,
                    Nombre = "Paililla",
                    Genero = "Trap/Rap",
                    FechaNacimiento = new DateTime(05112000),
                    LugarNacimiento = "Punta Arenas",
                    PaisNacimiento = "Chile"
                },
                new Model.Artista
                {
                    Id = 10,
                    Nombre = "Camiseta 22",
                    Genero = "Ska/Rock Latino",
                    FechaNacimiento = new DateTime(01011999),
                    LugarNacimiento = "Santiago",
                    PaisNacimiento = "Chile"
                }
            };
        }

        // GET: api/Artista
        [HttpGet]
        public IEnumerable<Model.Artista> Get()
        {
            return list;
        }

        // GET: api/Artista/5
        [HttpGet("{id}", Name = "Get")]
        public Model.Artista Get(int id)
        {
            return list.FirstOrDefault(x => x.Id == id);
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
        public void Put(int id, [FromBody] Model.Artista value)
        {
            Model.Artista obj = list.FirstOrDefault(x => x.Id == id);
            if (obj.Equals(null))
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Elemento no encontrado, verifique su ID e intente nuevamente."),
                    ReasonPhrase = "Elemento no encontrado"
                });
            }
            value.Id = id;
            obj = value;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Model.Artista obj = list.FirstOrDefault(x => x.Id == id);
            if (obj.Equals(null))
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Elemento no encontrado, verifique su ID e intente nuevamente."),
                    ReasonPhrase = "Elemento no encontrado"
                });
            }
            list.Remove(obj);
        }
    }
}
