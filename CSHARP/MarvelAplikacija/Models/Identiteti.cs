﻿namespace MarvelAplikacija.Models
{
    public class Identiteti : Entitet
    {
        public string Ime { get; set; } = "";
        public string? Prezime { get; set; }
        public int? Godine { get; set; }
        public int? God_rodjenja { get; set; }
        public int? God_smrti { get; set; }
    }
}