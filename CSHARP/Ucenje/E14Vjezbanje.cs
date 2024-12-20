using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Vjezbanje
    {
        public static void Izvedi()
        {
            Console.WriteLine("Dobro dosli u vjezbanje petkom");
            Izbornik();
            Console.WriteLine("Hvala na koristenju, dovidjenja");
        }


        private static void Izbornik()
        {
            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            Console.WriteLine("1. Parnost broja");
            Console.WriteLine("2. Tablica mnozenja");
            Console.WriteLine("0. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private static void OdabirOpcijeIzbornika()
        {
            switch(E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika: ",0,2))
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
                      
               
            }
        }

        private static void TablicaMnozenja()
        {
            
            NaslovPrograma("program koji za dane brojeve redka i tupaca generira tablicu mnozennja");
           

        }

        private static void ParnostBroja()
        {
            Console.WriteLine("***************");
            Console.WriteLine("program koji provjerava da li je uneseni broj paran ili ne");
            Console.WriteLine("*****************");
            int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
            if (broj%2 == 0) 
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
            
            Zvjezdice(naslov.Length);
            Console.WriteLine(naslov);
            Zvjezdice(naslov.Length);

        }
        private static void Zvjezdice(int komada)
        {
            for (int i = 0; i <komada; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

        }
    }
}
