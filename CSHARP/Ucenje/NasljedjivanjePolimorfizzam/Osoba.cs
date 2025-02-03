namespace Ucenje.NasljedjivanjePolimorfizzam
{
    internal class Osoba
    {

        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";

        public Osoba()
        {
        }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
    }
}

