using System;
namespace RealityFirst.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string ImagenUri { get; set; }
        public string Escritor { get; set; }
        public string Editor { get; set; }
        public Evento Evento { get; set; }
        public string NoticiaTexto { get; set; }

        private Artista _artista;
        public Artista Artista {
            get {
                if (Evento.Equals(null) || Evento.Id == 0)
                    return _artista;
                else
                    return Evento.Artista;
            }
            set {
                _artista = value;
            }
        }

        public Noticia()
        {
        }
    }
}
