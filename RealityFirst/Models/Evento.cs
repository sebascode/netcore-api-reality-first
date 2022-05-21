using System;
using System.Collections.Generic;
using System.Linq;
using RealityFirst.DBContext;

namespace RealityFirst.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Artista Artista { get; set; }
        public string Donde { get; set; }
        public DateTime Fecha { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public string TipoEventoStr => TipoEvento.ToString();

        public Evento()
        {
            TipoEvento = TipoEvento.Otro;
        }
    }
}