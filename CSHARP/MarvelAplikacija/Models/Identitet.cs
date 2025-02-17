namespace MarvelAplikacija.Models
{
    public class identiteti : Entitet
    {
        public string ime { get; set; } = "";
        public string prezime { get; set; }
        public int godine { get; set; }
        public int god_rodjenja { get; set; }
        public int god_smrti { get; set; }
    }
}
