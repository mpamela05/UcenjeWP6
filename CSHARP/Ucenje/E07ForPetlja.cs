﻿namespace Ucenje
{
    internal class E07ForPetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E07");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. Osijek", i);
            }


            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("{0}. Unazad", i);
            }


            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("\t{0}", i * j);
                }
                Console.WriteLine();
            }


            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            int x = 100;
            Console.WriteLine((x + 1) * x / 2);


            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0},", i);
                }
            }
            Console.WriteLine();
            int idiOd = 12;
            int idiDo = 34;

            for (int i = idiOd; i <= idiDo; i++)
            {
                Console.WriteLine(i);
            }

            int[] brojevi = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine(brojevi[i]);
            }


            int[,] tablica =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }

                if (i == 7)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            for(int i = 0; i >= 0; i++)
            {
                Console.WriteLine(i);
                break;
            }

            for(; ; )
            {
                Console.WriteLine(new Random().NextInt64() + "" + new Random().NextInt64() + "" + new Random().NextInt64());
                Thread.Sleep(300);
                break;
            }


        }
    }
}
