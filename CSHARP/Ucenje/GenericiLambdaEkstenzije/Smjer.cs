namespace Ucenje.GenericiLambdaEkstenzije
{
    internal class Smjer
    {
        public string? Naziv { get; set; }

        public int CompareTo(Smjer? other)
        {
            return Naziv.CompareTo(other?.Naziv);
        }

        public void OdradiPosao()
        {
            
        }

        
        [Obsolete("Ova metoda je depricated")]
        public string StariNaziv()
        {
            return Naziv + " stari " ?? "";
        }

        public override string ToString()
        {
            return Naziv ?? "";
        }
    }
}
