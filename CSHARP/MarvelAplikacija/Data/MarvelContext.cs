using Microsoft.EntityFrameworkCore;
using MarvelAplikacija.Models;

namespace MarvelAplikacija.Data
{
    public class MarvelContext : DbContext
    {
        public MarvelContext(DbContextOptions<MarvelContext> options) : base(options) { }

        public DbSet<Identiteti> Identiteti { get; set; }
        public DbSet<Tim> Timovi { get; set; }
        public DbSet<Heroji> Heroji { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Entitet as the base type
            modelBuilder.Entity<Entitet>()
                .HasKey(e => e.Sifra);

            modelBuilder.Entity<Entitet>()
                .ToTable("Entiteti")
                .HasDiscriminator<string>("Discriminator")
                .HasValue<Entitet>("Entitet")
                .HasValue<Identiteti>("Identiteti");

            // For Heroji, ensure Sifra is auto-generated
            modelBuilder.Entity<Heroji>()
                .Property(h => h.Sifra)
                .ValueGeneratedOnAdd();

            // Configure Heroji to Identiteti relationship
            modelBuilder.Entity<Heroji>()
                .HasOne(h => h.Identitet)
                .WithMany()
                .HasForeignKey(h => h.IdentitetId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure Timovi to Heroji relationship
            modelBuilder.Entity<Heroji>()
                .HasOne(h => h.Tim)
                .WithMany(t => t.Heroji)
                .HasForeignKey(h => h.TimId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Tim>()
                .ToTable("Timovi")
                .HasMany(t => t.Heroji)
                .WithOne(h => h.Tim)
                .HasForeignKey(h => h.TimId);

            modelBuilder.Entity<Korisnik>()
                .ToTable("Korisnici");

            base.OnModelCreating(modelBuilder); ;
            modelBuilder.Entity<Identiteti>().HasData(
           new Identiteti { Sifra = 1, Ime = "Peter", Prezime = "Parker", God_rodjenja = 2001 },
           new Identiteti { Sifra = 2, Ime = "Tony", Prezime = "Stark", God_rodjenja = 1970, God_smrti = 2023 },
           new Identiteti { Sifra = 3, Ime = "Clint", Prezime = "Barton", God_rodjenja = 1970 },
           new Identiteti { Sifra = 4, Ime = "Thor", Prezime = "Odinson", God_rodjenja = 967 },
           new Identiteti { Sifra = 5, Ime = "Natalia", Prezime = "Romanoff", God_rodjenja = 1984, God_smrti = 2023 },
           new Identiteti { Sifra = 6, Ime = "Robert Bruce", Prezime = "Banner", God_rodjenja = 1969 },
           new Identiteti { Sifra = 7, Ime = "Vision", Prezime = " ", God_rodjenja = 2015, God_smrti = 2018 },
           new Identiteti { Sifra = 8, Ime = "Nicholas Joseph", Prezime = "Fury", God_rodjenja = 1950 },
           new Identiteti { Sifra = 9, Ime = "Peter Jason", Prezime = "Quill", God_rodjenja = 1986 },
           new Identiteti { Sifra = 10, Ime = "89P13" },
           new Identiteti { Sifra = 11, Ime = "Groot", God_rodjenja = 2014 },
           new Identiteti { Sifra = 12, Ime = "Drax" },
           new Identiteti { Sifra = 13, Ime = "Gamora", God_smrti = 2018 },
           new Identiteti { Sifra = 14, Ime = "Nebula" },
           new Identiteti { Sifra = 15, Ime = "Mantis"}
       );

            // Seed Timovi
            modelBuilder.Entity<Tim>().HasData(
                new Tim { Sifra = 1, Naziv = "Avengers", Mjesto = "Zemlja" },
                new Tim { Sifra = 2, Naziv = "Guardians of the Galaxy", Mjesto = "Planet X" }
            );

            // Seed Heroji
            modelBuilder.Entity<Heroji>().HasData(
                new Heroji { Sifra = 1, Ime = "Spider Man", Moc = "nadljudska snaga", Mjesto = "New York", Osobnost = "hrabar", G_dolaska = 2016, IdentitetId = 1, TimId = 1 },
                new Heroji { Sifra = 2, Ime = "Iron Man", Moc = "mocno oklopno odijelo", Mjesto = "New York", Osobnost = "inteligentan", G_dolaska = 2007, IdentitetId = 2, TimId = 1 },
                new Heroji { Sifra = 3, Ime = "Hawkeye", Moc = "Bog groma", Mjesto = "Zemlja", Osobnost = "Test", G_dolaska = 1962, IdentitetId = 3, TimId = 1 },
                new Heroji { Sifra = 4, Ime = "Thor", Moc = "Bog groma", Mjesto = "Asgard", Osobnost = "Plemenit, moćan", G_dolaska = 1962, IdentitetId = 4, TimId = 1 },
                new Heroji { Sifra = 5, Ime = "Hulk", Moc = "Nevjerojatna snaga", Mjesto = "New York", Osobnost = "Impulzivna, snažna", G_dolaska = 1962, IdentitetId = 5, TimId = 1 },
                new Heroji { Sifra = 6, Ime = "Nick Fury", Moc = "Vješt strateški um", Mjesto = "New York", Osobnost = "Ozbiljan, iskusan", G_dolaska = 1963, IdentitetId = 6, TimId = 1 },
                new Heroji { Sifra = 7, Ime = "Natasha Romanoff", Moc = "Vjeste boriacke vjestine, spijunske vjestine", Mjesto = "Rusija", Osobnost = "Inteligentna, strategija", G_dolaska = 1964, IdentitetId = 7, TimId = 1 },
                new Heroji { Sifra = 8, Ime = "Rocket", Moc = "Genijalc, majstor za oruzja", Mjesto = "Planet X", Osobnost = "Sarkastican, lojalan", G_dolaska = 2014, IdentitetId = 10, TimId = 2 },
                new Heroji { Sifra = 9, Ime = "Star Lord", Moc = "vodja, vjest pilot", Mjesto = "Zemlja", Osobnost = "Humoristican, avnturist", G_dolaska = 2014, IdentitetId = 9, TimId = 2 },
                new Heroji { Sifra = 10, Ime = "Groot", Moc = "Super snaga, regeneracija", Mjesto = "Planet X", Osobnost = "Jednostavan, prijateljski", G_dolaska = 2014, IdentitetId = 11, TimId = 2 },
                new Heroji { Sifra = 11, Ime = "Drax Razarac", Moc = "Super snaga, neunistivost", Mjesto = "Planet X", Osobnost = "Naivan, osvetoljubiv", G_dolaska = 2014, IdentitetId = 12, TimId = 2 },
                new Heroji { Sifra = 12, Ime = "Gamora", Moc = "Vjeste borilacke vjestine, atleticar", Mjesto = "Zeleni Planet", Osobnost = "Hladna, odlucna", G_dolaska = 2014, IdentitetId = 13, TimId = 2 },
                new Heroji { Sifra = 13, Ime = "Nebula", Moc = "Kierneticka nadogradnja, vjestine borbbe", Mjesto = "Titan", Osobnost = "Okruta, osvetoljubiv", G_dolaska = 2014, IdentitetId = 14, TimId = 2 },
                new Heroji { Sifra = 14, Ime = "Mantis", Moc = "Empatija, borilacke vjestine", Mjesto = "Cerberus", Osobnost = "Naivna, empaticna", G_dolaska = 2014, IdentitetId = 15, TimId = 2 }
                );
        }
    }
}
