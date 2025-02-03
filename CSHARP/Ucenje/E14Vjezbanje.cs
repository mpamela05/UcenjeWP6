namespace Ucenje
{
    internal class E14Vjezbanje
    {
        //3.program: za dani cijeli broj izmedju 20 i 50 ispisi koja mu je vrijednost jeinice
        //34 treba ispisat 4
        // 21 treba ispisat 1
        public static void Izvedi()
        {
            Console.WriteLine("Dobro dosli u vjezbanje petkom");
            Izbornik();
            Console.WriteLine("Hvala na koristenju, dovidjenja");
        }


        private static void Izbornik()
        {

            string[] programi =
            {
                "Parnost broja",
                "Tablica mnozenja",
                "Jedinicna vrijednost",
                "Broj znakoa naiva mjesta"
            };

            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            for(int i = 0;i < programi.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i+1,  programi[i]);
            }
            Console.WriteLine("0. Izlaz iz programa");
            OdabirOpcijeIzbornika(programi.Length);
        }

        private static void OdabirOpcijeIzbornika(int brojPrograma)
        {
            switch (E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika: ", 0,brojPrograma))
            {
                case 0:
                    break;
                case 1:
                    ParnostBroja();
                    Izbornik();
                    break;
                case 2:
                    TablicaMnozenja();
                    Izbornik();
                    break;
                case 3:
                    JedinicnaVrijednost();
                    Izbornik();
                    break;
                case 4:
                    BrojZnakovaNaziaMjesta();
                    Izbornik();
                    break;



            }
        }

        private static void BrojZnakovaNaziaMjesta()
        {
            NaslovPrograma("Za uneseni naziv mjesta ispisuje koliko ima znaova");
            Console.WriteLine("Unesite naziv mjesta: ");
            string ime = E12Metode.UcitajString("Unesi ime grada: ");
            Console.WriteLine(ime.Length);
        }

        private static void TablicaMnozenja()
        {

            NaslovPrograma("program koji za dane brojeve redka i tupaca generira tablicu mnozennja");
            int redaka = E12Metode.UcitajCijeliBroj("unesi broj redaka: ", 2, 10);
            int stupaca = E12Metode.UcitajCijeliBroj("unesi broj stupaca: ", 2, 10);

            for (int i = 1; i <= redaka; i++)
            {
                for (int j = 1; j <= stupaca; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();
            }

        }

        private static void ParnostBroja()
        {

            Console.WriteLine("program koji provjerava da li je uneseni broj paran ili ne");

            int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
            if (broj % 2 == 0)
            {
                Console.WriteLine("uneseni broj {0} je PARAN", broj);
            }
            else
            {
                Console.WriteLine("uneseni broj {0} je NEPARAN", broj);
            }


        }
        private static void NaslovPrograma(string naslov)
        {

            NaglasiNaslov(naslov.Length);
            Console.WriteLine(naslov);
            NaglasiNaslov(naslov.Length);

        }
        private static void NaglasiNaslov(int komada)
        {
            for (int i = 0; i < komada; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

        }
        private static void JedinicnaVrijednost()
        {
            NaslovPrograma("JedinicnaVrijdnost");
            Console.WriteLine("unesite cijeli broj izmedju 20 i 50");
            int broj = int.Parse(Console.ReadLine());
            if (broj >= 20 && broj <= 50)
            {
                int jedinica = broj % 10;
                Console.WriteLine("vrijednost jedinica broja {0} je {1}", broj,jedinica);
            } 
            else
            {
                Console.WriteLine("Broj mora biti izmedju 20 i 50");
            }
        }
    }
}
