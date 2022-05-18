using System;
namespace RealityFirst.Models
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string PaisNacimiento { get; set; }
        public int Edad {
            get {
                int age = DateTime.Now.Year - FechaNacimiento.Year;
                if (FechaNacimiento.Date > DateTime.Now.AddYears(-age)) age--;
                return age;
            }
        }
        public string Genero { get; set; }

        public Artista()
        {

        }
    }
}