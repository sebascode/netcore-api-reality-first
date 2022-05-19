using System;
namespace RealityFirst.Models
{
    public class Entrada
    {
        public int Id { get; set; }
        public TipoTicket TipoTicket { get; set; }
        public Evento Evento { get; set; }
        public decimal Valor => TipoEntrada.Valor;
        public string MedioPago { get; set; }

        public Entrada()
        {

        }
    }
}