namespace MarvelAplikacija.Models
{
    public class Korisnik: Entitet
    {
        public string? Nadimak { get; set; }
        public string? Lozinka { get; set; }
        public string? Mail { get; set; }
        public string? Uloga { get; set; }

    }
}