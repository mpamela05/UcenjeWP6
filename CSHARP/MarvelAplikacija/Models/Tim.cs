namespace MarvelAplikacija.Models
{
    public class Tim: Entitet
    {
        public string Naziv { get; set; } = "";
        public string Mjesto { get; set; } = "";
        public ICollection<Heroji> Heroji { get; set; } = new List<Heroji>();
    }

    
}
