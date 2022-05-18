using System;
using System.Collections.Generic;
using System.Linq;

namespace RealityFirst.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Artista Artista { get; set; }
        public string Donde { get; set; }
        public DateTime Fecha { get; set; }
        public IList<TipoTicket> Categorias { get; set; }
        public decimal ValorMax => Categorias.Max(x => x.Valor);
        public decimal ValorMin => Categorias.Min(x => x.Valor);

        public Evento()
        {
            this.Categorias = new List<TipoTicket>();
        }
    }
}