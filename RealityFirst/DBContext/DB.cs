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
                Evento = listEvento.FirstOrDefault(x => x.Artista.Id == 1),
                Titulo = "Shakira combina tendencias con su look en 'total black' de minifalda, transparencias y sujetador de encaje",
                Subtitulo = "Todavía no hemos decidido si nos gusta o no este look de Shakira en el que ha decidido unir transparencias con minifalda y sujetador de encaje a la vista. ¿Es de esas ocasiones en las que más es más o se ha pasado?",
                NoticiaTexto = @"En nuestro armario este año estamos dando especial protagonismo a las piezas coloridas o con estampados, pero eso no quiere decir que renunciemos a los 'total looks' que se rinden. a un color negro. Ya sea en blanco o en negro, estos modelitos siempre triunfan y nos dan un respiro estilístico en verano. Por eso no hemos podido evitar analizar el último look que ha llevado Shakira en una alfombra roja. La cantante se ha rendido al color negro con un look repleto de tendencias de verano, pero todavía no tenemos clara nuestra opinión. ¿Puede que se haya entregado demasiado o es de esas ocasiones en las que el look funciona por haber sumado muchas tendencias juntas?

En este último look de Shakira, que lució anoche en los premios The Ivor Novello 2022 que se celebraron en The Grosvenor House Hotel de Londres, hemos podido ver cómo combinaba una minifalda de estilo rockero, camisa transparente de color negro y sujetador de encaje a la vista. Seguimos dándole vueltas a cada detalle para determinar si nos gusta o no.",
                ImagenUri = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/shakira-minifalda-transparencias-sujetador-elle-00-1652975537.jpg",
            },
            new Noticia
            {
                Id = 2,
                Editor = "Antonelo Mendoza",
                Escritor = "Marco Aurelio Jonás Do Souza",
                Evento = listEvento.FirstOrDefault(x => x.Artista.Id == 3),
                Titulo = "“100 millone’ dando vuelta’ en un Can-Am”: Bad Bunny compró vehículos 4x4 a sus amigos y olvidó dárselos",
                Subtitulo = "Los autos costarían más de 30 millones de pesos cada uno.",
                NoticiaTexto = @"Como la canción “100 millones” de Bad Bunny, el cantante decidió darle a sus amigos un regalo muy especial, un can-am, un vehículo cuatro por cuatro que está hecho para andar por playas y cerros. Sin embargo, nunca se los entregó.

Así lo reveló el mismo “Conejo Malo” en una conversación con Chente Ydrach, en donde parte de su staff- que también son sus amigos- relató la situación.
“Los compra (los can-ams) tipo regalo de reyes, pasan cuatro cinco meses, y no nos dice nada. Y de pronto me dicen qué van a hacer con los can-ams, y yo qué can-am”, relató su amigo.

Luego, una de las personas que maneja las cuentas del artista decidió consultar sobre una extraña factura: “Voy donde Benito y le digo ¿tú compraste unos can ams, porque me enviaron la factura?”, ya que existía la posibilidad de que le pudieran haber falseado la identidad.",
                ImagenUri = "https://www.publimetro.cl/resizer/FFhc4kZDoaLS6Nq7xzs9QPTlQik=/800x0/filters:format(png):quality(70)/cloudfront-us-east-1.images.arcpublishing.com/metroworldnews/C4JY5IRLXRBTZAT6NGBQA5ZXRY.png",
            },
            new Noticia
            {
                Id = 3,
                Editor = "Antonelo Mendoza",
                Escritor = "Marco Aurelio Jonás Do Souza",
                Evento = listEvento.FirstOrDefault(x => x.Artista.Id == 5),
                Titulo = "KHEA, LIT KILLAH Y RUSHERKING COCINARON SU NUEVO TEMITA “PA CO” JUNTOS",
                Subtitulo = "",
                NoticiaTexto = @"Khea se rajó con un nuevo temita junto con Lit Killah y Rusherking, quienes se las dieron de chefs en el interior de la cocina de un restaurante mientras cantaban “Pa Co”.

En el videoclip podemos ver a los tres argentinos bacilando y pasándolo chancho, mientras preparan platos para una joven chica que llegó como clienta al lugar y evalúa todas las preparaciones. “Tus cocineros favoritos🧑🏻‍🍳❤️ gracias a todxs por el apoyo. A romper bebé🔥 ARGENTINA EN LA CASA”, escribieron los artistas en sus redes sociales.

A pocas horas de su estreno, el video ya cuenta con casi un millón de reproducciones, manteniéndose en el puesto #24 de las tendencias musicales del país en Youtube.",
                ImagenUri = "https://assets.megamediaradios.fm/2022/03/FM8kRXNWUAI-1_L-1024x576.jpeg",
            },
            new Noticia
            {
                Id = 4,
                Editor = "Antonelo Mendoza",
                Escritor = "Pablo Retamal N.",
                Evento = listEvento.FirstOrDefault(x => x.Artista.Id == 7),
                Titulo = "L-Gante: quién es el “Marcianeke argentino”",
                Subtitulo = "Un fenómeno explosivo del trap, que a contar de su canción RKT, se destapó. Ha tenido problemas judiciales en su país, se ha relacionado con la barra brava de Boca Juniors y es cercano a Marcianeke. Se presentará este fin de semana en Chile.",
                NoticiaTexto = @"A sus cortos 22 años, el flaco, alto y desgarbado Elian Ángel Valenzuela podría pasar como un joven argentino más. Con su tatuajes (cara incluida) y su vestimenta podría pasar colado en el público de un recital. Lo cierto es que Valenzuela es un ídolo musical allende Los Andes. Es nada menos que el actual referente del trap argentino con su nombre artístico: L-Gante.

Su ascenso al estrellato ha sido meteórico. En 2020 tuvo su primera gran canción exitosa, RKT, un fenómeno en YouTube que, hasta la fecha, lleva la friolera cifra de 290 millones de reproducciones. El tema muestra una de sus características: letras llenas de lunfardía y mundo callejero. “Comenzamo’ a entona’ y se me calienta el pico/ Vamo’ encapsulado al par’y, a ciento y pico”, dice con confianza.
Incluso, hoy se ubica por cerca de las 500.000 reproducciones diarias en Spotify. Todo un récord. Los medios al otro lado de la Cordillera hablan de su cotización actual: cada presentación suya cuesta 25.000 dólares (unos 200 millones de pesos chilenos), y en entidades como clubes va en los 15.000 si se superan los 3.000 asistentes.

Pero no todo ha sido música, beats y videos sugerentes. L-Gante también ha tenido problemas con la justicia. En febrero pasado, tuvo un entrevero con un vecino de su natal General Rodríguez, provincia de Buenos Aires. El cantante lo acusaba de querer entrar a su casa para robarle, y no solo eso, habría realizado la amenaza con una pistola en su mano y hasta habría realizado un disparo contra el piso para amedrentarlo. El hombre acudió a tribunales.

Posteriormente, la policía hizo un allanamiento en la casa de L-Gante para encontrar el arma, pero no se halló nada. Además, a fines de marzo, un joven de 17 años lo denunció por haberlo agredido en la cabeza con un arma, solo por haberle pedido una foto.",
                ImagenUri = "https://www.latercera.com/resizer/gupoN7ZSKIMOjcobC5wd4XmetAQ=/900x600/smart/cloudfront-us-east-1.images.arcpublishing.com/copesa/PIRON3TRQVHFJLRK5GXA72ZFW4.jpg",
            },
            new Noticia
            {
                Id = 1,
                Editor = "Marcia Neke",
                Escritor = "Marco Pablo Albano",
                Evento = listEvento.FirstOrDefault(x => x.Artista.Id == 10),
                Titulo = "Camiseta 22 debuta con 'Antes de las 10'",
                Subtitulo = "Agrupación cuenta con fundadores de Guachupé",
                NoticiaTexto = @"Tomás Maldonado y Robinson Acuña, cantante y guitarrista del popular conjunto nacional Guachupé, debutan con su nuevo proyecto, Camiseta 22.

'Antes de las 10' es su primer sencillo y presenta rimas que evocan a la amistad, el perdón y al ídolo azteca Juan Gabriel. Una serie de mensajes, señales y emociones que la pandemia ayudó a potenciar. Un disco de ocho canciones, un par de videoclips y hasta un documental son parte de las novedades que el dúo ha preparado, de manera silenciosa, desde mediados de 2021.

Tras el receso que Guachupé anunció en octubre de 2020 -banda a la cual ambos miembros pertenecen-, la dupla compuesta por el cantante Tomás Maldonado y el guitarrista Robinson Acuña decidió continuar la senda de la creación. Tras una pausa de varios meses, la dupla compositiva decidió seguir adelante con la producción de nuevas canciones. 'Con Robinson nos encontramos en el encierro, rodeados por la nostalgia y, a la vez, inspirados por ella. Yéndonos a casa con una melodía que finalmente se transformó en 'Antes de las 10'. Es desde ese lugar que se desarrolló naturalmente todo el proceso que nos tiene hoy acá, listos para volver a los escenarios en un reencuentro que ha sido muy anhelado', revela Maldonado.

Acompañados de destacados músicos locales como el icónico tecladista Camilo Salinas, la banda se reencuentra con la poderosa combinación de cumbia, rock, ska y reggae que en el pasado los hizo girar por Chile y países como México y España. Hoy, con nuevos matices y acercándose a otros ritmos, el grupo apuesta por encontrarse con una fanaticada que no se ha cansado de pedirlos de vuelta en los escenarios. 'Creemos que el sonido de Camiseta 22 nos encuentra más maduros en la forma que queremos sonar y también desde el punto de vista compositivo. Sentimos que es un proyecto donde las canciones crecieron espontáneamente, no se forzaron y eso nos tiene muy contentos. Creemos que la gente que, día a día, nos recuerda en redes sociales y en la calle que están esperando algo nuevo, sentirán que este single es un llamado a volver a abrazarnos', señala Acuña.",
                ImagenUri = "https://www.rockaxis.com/img/newsList/3285073.jpg",
            }
        };

        // Eventos para traer la info
        public static IList<Artista> getArtistas(){ return listArtista; }
        public static IList<Evento> getEventos() { return listEvento; }
        public static IList<Noticia> getNoticias() { return listNoticia; }
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
