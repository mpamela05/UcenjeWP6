﻿namespace Ucenje
{
    internal class E07Z1
    {
        public static void Izvedi() 
        {
            //Console.WriteLine("E07Z1");
            Console.WriteLine("Unesite cijeli broj");
            int broj = int.Parse(Console.ReadLine());
            //Console.WriteLine(broj);
            if (broj % 2 == 0)
            {
                int sum = 0;
                for (int i = 1; i <= broj; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            else
            {
                for (int i = 1; i<= broj; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
