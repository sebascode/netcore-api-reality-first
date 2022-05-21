using System;
namespace RealityFirst.Models
{
    public class TipoTicket
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool AsientoNumerado { get; set; }
        public decimal Valor { get; set; }

        public TipoTicket()
        {

        }
    }
}
