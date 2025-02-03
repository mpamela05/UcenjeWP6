namespace Ucenje.KonzolnaAplikacija.Model
{
    internal class Grupa
    {
        public string? Naziv { get; set; }
        public Smjer? Smjer { get; set; }
        public string? Predavac { get; set; }
        public int? VelicinaGrupe { get; set; }
        public List<Polaznik>? Polaznici { get; set; }
    }
}
