namespace MarvelAplikacija.Models
{
    public class Heroji : Identiteti
   {
        public new string Ime { get; set; }
        public string Moc { get; set; } = "";
        public string? Mjesto { get; set; }
        public string Osobnost { get; set; } = "";
        public int G_dolaska { get; set; }
        public int IdentitetId { get; set; }
        public Identiteti Identitet { get; set; }
        public int? TimId { get; set; }
        public Tim Tim { get; set; }

    }

    
}

