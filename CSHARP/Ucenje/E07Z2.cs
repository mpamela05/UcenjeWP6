﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z2
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi prvi broj");
            int pb = int.Parse(Console.ReadLine());


            Console.WriteLine("Unesi drugi broj");
            int db = int.Parse(Console.ReadLine());
            
            for (int i = pb; i < db; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
