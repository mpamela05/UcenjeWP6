namespace Ucenje.E17KlasaObjekt.Edunova
{
    public class Polaznik
    {
        public int Sifra { get; set; }
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";
        public string Email { get; set; } = "";
        public string? Oib{ get; set; }

       public string ImePrezime()
        {
            return Ime + " " +Prezime;
        }

    }
}
