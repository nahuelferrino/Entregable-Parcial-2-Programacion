namespace AccesoDatos.Models
{
    public class Cancion
    {
        public int Id {get; set; }
        public string Titulo {get; set; }
        public decimal Duracion {get; set; }
        public Artista Artista {get; set; }
        public int ArtistaId {get; set; }
    }
}