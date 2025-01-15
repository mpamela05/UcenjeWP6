namespace Ucenje.E17KlasaObjekt
{
    public class Mjesto
    {
        public string Naziv { get; set; } = "";
        public string PostanskiBroj { get; set; } = ""; //svojstvo nije NULL nego je prazno

        public Zupanije Zupanija { get; set; }
    }
}