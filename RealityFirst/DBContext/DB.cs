using System;
using RealityFirst.Models;
using System.Collections.Generic;
using System.Linq;

namespace RealityFirst.DBContext
{
    public class DB
    {
        // Listas estáticas
        private static IList<Artista> listArtista = new List<Artista>(){
            new Artista
            {
                Id = 1,
                Nombre = "Shakira",
                Genero = "Pop",
                FechaNacimiento = new DateTime(1977,02,03),
                LugarNacimiento = "Barranquilla",
                PaisNacimiento = "Colombia"
            },
            new Artista
            {
                Id = 2,
                Nombre = "Metallica",
                Genero = "Rock/Metal",
                FechaNacimiento = new DateTime(1983,02,01),
                LugarNacimiento = "San Francisco",
                PaisNacimiento = "Estados Unidos"
            },
            new Artista
            {
                Id = 3,
                Nombre = "Bad bunny",
                Genero = "Trap/Raggaeton",
                FechaNacimiento = new DateTime(1994,03,10),
                LugarNacimiento = "Almirante Sur",
                PaisNacimiento = "Puerto Rico"
            },
            new Artista
            {
                Id = 4,
                Nombre = "Residente",
                Genero = "Rap/Raggaeton",
                FechaNacimiento = new DateTime(1978,02,23),
                LugarNacimiento = "Hato Rey Central",
                PaisNacimiento = "San Juan/Puerto Rico"
            },
            new Artista
            {
                Id = 5,
                Nombre = "Lit Killah",
                Genero = "Trap/Hip Hop",
                FechaNacimiento = new DateTime(1992,10,04),
                LugarNacimiento = "Gonzalez Catalán",
                PaisNacimiento = "Argentina"
            },
            new Artista
            {
                Id = 6,
                Nombre = "Tini",
                Genero = "Pop",
                FechaNacimiento = new DateTime(1997,03,21),
                LugarNacimiento = "Buenos Aires",
                PaisNacimiento = "Argentina"
            },
            new Artista
            {
                Id = 7,
                Nombre = "L-Gante",
                Genero = "Trap/Cumbia 420",
                FechaNacimiento = new DateTime(2000,04,05),
                LugarNacimiento = "General Rodriguez",
                PaisNacimiento = "Argentina"
            },
            new Artista
            {
                Id = 8,
                Nombre = "AK4:20",
                Genero = "Trap/Rap",
                FechaNacimiento = new DateTime(2001,11,19),
                LugarNacimiento = "Talca",
                PaisNacimiento = "Chile"
            },
            new Artista
            {
                Id = 9,
                Nombre = "Pailita",
                Genero = "Trap/Rap",
                FechaNacimiento = new DateTime(2000,11,05),
                LugarNacimiento = "Punta Arenas",
                PaisNacimiento = "Chile"
            },
            new Artista
            {
                Id = 10,
                Nombre = "Camiseta 22",
                Genero = "Ska/Rock Latino",
                FechaNacimiento = new DateTime(2021,08,23),
                LugarNacimiento = "Santiago",
                PaisNacimiento = "Chile"
            }
        };
        private static IList<Evento> listEvento = new List<Evento>() {
            new Evento
            {
                Id = 10,
                Nombre = "El Dorado Tour",
                Artista = listArtista.FirstOrDefault(x => x.Id == 1),
                Donde = "Estadio Nacional",
                Fecha = new DateTime(2022, 08, 30),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 20,
                Nombre = "Bad Bunny: World's Hottest Tour",
                Artista = listArtista.FirstOrDefault(x => x.Id == 3),
                Donde = "Estadio San Carlos de Apoquindo",
                Fecha = new DateTime(2022, 12, 05),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 30,
                Nombre = "Metallica - Elderly Wire Live",
                Artista = listArtista.FirstOrDefault(x => x.Id == 2),
                Donde = "Club Hípico",
                Fecha = new DateTime(2022, 03, 25),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 40,
                Nombre = "El Residente & Calle 13",
                Artista = listArtista.FirstOrDefault(x => x.Id == 4),
                Donde = "Estadio Bicentenario La Florida",
                Fecha = new DateTime(2023, 03, 10),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 50,
                Nombre = "Lit Killah en Chile - Santiago",
                Artista = listArtista.FirstOrDefault(x => x.Id == 5),
                Donde = "Teatro Caupolicán",
                Fecha = new DateTime(2022, 08, 15),
                TipoEvento = TipoEvento.Teatro
            },
            new Evento
            {
                Id = 51,
                Nombre = "Lit Killah en Chile - Concepción",
                Artista = listArtista.FirstOrDefault(x => x.Id == 5),
                Donde = "Teatro Teletón Concepción",
                Fecha = new DateTime(2022, 08, 16),
                TipoEvento = TipoEvento.Teatro
            },
            new Evento
            {
                Id = 52,
                Nombre = "Lit Killah en Chile - Santiago 2a Función",
                Artista = listArtista.FirstOrDefault(x => x.Id == 5),
                Donde = "Estadio Santa Laura",
                Fecha = new DateTime(2022, 08, 18),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 53,
                Nombre = "Lit Killah en Chile - Valpo/Viña",
                Artista = listArtista.FirstOrDefault(x => x.Id == 5),
                Donde = "Estadio Elias Figueroa",
                Fecha = new DateTime(2022, 08, 19),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 60,
                Nombre = "Tini en Vivo - Santiago",
                Artista = listArtista.FirstOrDefault(x => x.Id == 6),
                Donde = "Teatro Caupolicán",
                Fecha = new DateTime(2022, 10, 18),
                TipoEvento = TipoEvento.Teatro
            },
            new Evento
            {
                Id = 61,
                Nombre = "Tini en Vivo - Viña",
                Artista = listArtista.FirstOrDefault(x => x.Id == 6),
                Donde = "Quinta Vergara",
                Fecha = new DateTime(2022, 10, 20),
                TipoEvento = TipoEvento.Teatro
            },
            new Evento
            {
                Id = 62,
                Nombre = "Tini en Vivo - Concepción",
                Artista = listArtista.FirstOrDefault(x => x.Id == 6),
                Donde = "Anfiteatro Universidad de Concepción",
                Fecha = new DateTime(2022, 10, 22),
                TipoEvento = TipoEvento.Teatro
            },
            new Evento
            {
                Id = 70,
                Nombre = "Cumbia 4:20 - Chile Tour - Santiago",
                Artista = listArtista.FirstOrDefault(x => x.Id == 7),
                Donde = "Estadio Bicentenario",
                Fecha = new DateTime(2022, 4, 22),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 71,
                Nombre = "Cumbia 4:20 - Chile Tour - Viña del Mar",
                Artista = listArtista.FirstOrDefault(x => x.Id == 7),
                Donde = "Estadio Sausalito Elias Figueroa",
                Fecha = new DateTime(2022, 4, 24),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 72,
                Nombre = "Cumbia 4:20 - Chile Tour - Talca",
                Artista = listArtista.FirstOrDefault(x => x.Id == 7),
                Donde = "Bar El Caucásico",
                Fecha = new DateTime(2022, 4, 28),
                TipoEvento = TipoEvento.Teatro
            },
            new Evento
            {
                Id = 73,
                Nombre = "Cumbia 4:20 - Chile Tour - Chillán",
                Artista = listArtista.FirstOrDefault(x => x.Id == 7),
                Donde = "Estadio Nelson Oyarsún",
                Fecha = new DateTime(2022, 4, 30),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 74,
                Nombre = "Cumbia 4:20 - Chile Tour - Concepción",
                Artista = listArtista.FirstOrDefault(x => x.Id == 7),
                Donde = "Estadio Ester Roa",
                Fecha = new DateTime(2022, 4, 29),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 75,
                Nombre = "Cumbia 4:20 - Chile Tour - Iquique",
                Artista = listArtista.FirstOrDefault(x => x.Id == 7),
                Donde = "Estadio Tierra de Campeones",
                Fecha = new DateTime(2022, 5, 3),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 80,
                Nombre = "AK 4:20 en La Serena",
                Artista = listArtista.FirstOrDefault(x => x.Id == 8),
                Donde = "Estadio La Portada",
                Fecha = new DateTime(2022, 4, 24),
                TipoEvento = TipoEvento.Estadio
            },
            new Evento
            {
                Id = 90,
                Nombre = "El Carrete pa weno",
                Artista = listArtista.FirstOrDefault(x => x.Id == 9),
                Donde = "Teatro Teletón",
                Fecha = new DateTime(2022, 6, 12),
                TipoEvento = TipoEvento.Teatro
            },
            new Evento
            {
                Id = 100,
                Nombre = "Camiseta, vuelta a casa",
                Artista = listArtista.FirstOrDefault(x => x.Id == 10),
                Donde = "Bar Las Tejas",
                Fecha = new DateTime(2022, 5, 22),
                TipoEvento = TipoEvento.Teatro
            },
        };
        private static IList<TipoTicket> listTipoTicket_Estadio = new List<TipoTicket>()
        {
            new TipoTicket
            {
                Id = 1,
                Nombre = "Platea Alta",
                Valor = 50000
            },
            new TipoTicket
            {
                Id = 2,
                Nombre = "Platea Baja",
                Valor = 40000
            },
            new TipoTicket
            {
                Id = 1,
                Nombre = "Cancha",
                Valor = 35000
            },
            new TipoTicket
            {
                Id = 1,
                Nombre = "General",
                Valor = 15000
            },
            new TipoTicket
            {
                Id = 1,
                Nombre = "V.I.P.",
                Valor = 80000
            }
        };
        private static IList<TipoTicket> listTipoTicket_Otro = new List<TipoTicket>()
        {
            new TipoTicket
            {
                Id = 1,
                Nombre = "General",
                Valor = 10000
            },
            new TipoTicket
            {
                Id = 1,
                Nombre = "V.I.P.",
                Valor = 20000
            }
        };
        private static IList<Noticia> listNoticia = new List<Noticia>()
        {
            new Noticia
            {
                Id = 1,
                Editor = "Antonelo Mendoza",
                Escritor = "Marco Aurelio Jonás Do Souza",
                Evento = listEvento.FirstOrDefault(x => x.Artista.Id == 0),
                Titulo = ""
            }
        };

        // Eventos para traer la info
        public static IList<Artista> getArtistas(){ return listArtista; }
        public static IList<Evento> getEvento() { return listEvento; }
        public static IList<TipoTicket> getTipoTicket(TipoEvento tp) {
            switch (tp)
            {
                case TipoEvento.Estadio:
                    return listTipoTicket_Estadio;
                default:
                    return listTipoTicket_Otro;
            }
        }

    }
}
