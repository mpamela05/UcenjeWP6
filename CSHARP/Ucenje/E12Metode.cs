﻿namespace Ucenje
{
    internal class E12Metode
    {
        public static void Izvedi()
        {
            Tip1();
            Tip1();

            Tip2(7);
            Tip2(5);

            Tip2(10, "poziv druge varijante metodde Tip2");

            int i = Tip3() + 1;
            Console.WriteLine(i);

            int[] niz = {2,3,4,5,6,7,8,9};
            Console.WriteLine(Tip4(niz));

            Tip4(niz); //nema efekta, ali ce se izvest ha haaa
        }

        static void Tip1() 
        {
            Console.WriteLine("ispis iz 1. tipa metode");
            Console.WriteLine("*********************");
            Console.WriteLine("kraj ispisa iz 1. tipa metode");
        }

        private static void Tip2(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void Tip2(int x, string naslov)
        {
            Console.WriteLine(naslov);
            Tip2(x);
        }

        private static int Tip3()
        {
            return int.MaxValue;
        }

        /// <summary>
        /// Metoa c za primljeni niz cijelih brojeva vratiti sumu
        /// </summary>
        /// <param name="niz">niz cijelih brojeva</param>
        /// <returns>suma primljenih brojeva</returns>
        private static int Tip4(int[] niz)
        {
            int suma = 0;
            foreach (int i in niz)
            {
                suma += i;
            }
            return suma;
        }
        public static int UcitajCijeliBroj(string poruka)
        {

            while (true)
            {
                Console.Write(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("problem kod ucitanja broja");   
                }
            }

            //return 0;
        }



        public static int UcitajCijeliBroj(string poruka, int min, int max)
        {
            int i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                   i = int.Parse(Console.ReadLine());
                    if(i < min || i > max)
                    {
                        Console.WriteLine("Broj nije u danom rasponu {0} - {1}", min, max);
                        continue;
                    }
                    return i;

                }
                catch
                {
                    Console.WriteLine("problem kod ucitanja broja");
                }
            }

            //return 0;
        }




        public static string UcitajString(string poruka) 
        {
            string s = "";
            while (true) 
            {
                Console.Write(poruka);
                s = Console.ReadLine().Trim();
                if(s.Length == 0 )
                {
                    Console.WriteLine("obavezan unos");
                    continue;
                }
                return s;
            }

            return "";
        }


    }
}
