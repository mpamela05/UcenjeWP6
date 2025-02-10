using System.Text;

namespace Ucenje.NasljedjivanjePolimorfizzam
{
    internal class Program
    {
        public Program(string s)
        {
            Console.WriteLine(s);
            var smjer = new Smjer() { Sifra = 1, Naziv = "Web programiranje" };

            Console.WriteLine(smjer); // kada se ispisuje cijeli objekt izvodi se metoda toString na kasama od dolje prema gore (zadnja je Object)


            var osoba = new Osoba() { Sifra = 1, Ime = "Pero", Prezime = "Perić" };

            osoba = new Osoba("Marija", "Zimska");

            Console.WriteLine(osoba);


            // string je immutable https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
            string s1 = "AA";

            Console.WriteLine(s1.GetHashCode()); //hashcode je reprezentant memorijske lokacije

            s1 = "BB";

            Console.WriteLine(s1.GetHashCode());

            

            var sb = new StringBuilder();

            sb.Append("AA");

            Console.WriteLine(sb.GetHashCode());

            sb.Clear().Append("BB");

            Console.WriteLine(sb.GetHashCode());


            Smjer smjer1 = new Smjer() { Naziv = "Web programiranje" };
            Smjer smjer2 = new Smjer() { Naziv = "Web programiranje" };

            Console.WriteLine(smjer1.GetHashCode());
            Console.WriteLine(smjer2.GetHashCode());

            Console.WriteLine(smjer.Equals(smjer2));


            

            var e = new EntitetImpl() { Sifra = 1 };


            
            Obrada[] obrade = new Obrada[2];

            obrade[0] = new ObradaUlazniRacun();
            obrade[1] = new ObradaIzlazniRacun();


            // polimorfizam
            foreach (Obrada o in obrade)
            {
                o.Procesuiraj();
            }


        }
    }
}
