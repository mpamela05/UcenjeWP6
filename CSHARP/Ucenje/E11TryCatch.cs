using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E11TryCatch
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E11");
            int broj;
            while (true)
            {

                try
                {
                    Console.Write("unesi cijeli broj: ");
                    broj = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("nisi unio cijeli broj!");
                }

            }
            Console.WriteLine("unijeli ste {0}", broj);

            int godine;
            while (true)
            {
                Console.Write("unesi svoj broj godina");
                try
                {
                    godine = int.Parse(Console.ReadLine());
                    if (godine < 1 || godine > 104)
                    {
                        Console.WriteLine("uneseni broj godina nije dobar");
                        continue;
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("nisi dobro unio broj godina");
                   
                }
            }
            Console.WriteLine("broj godina osobe je {0}", godine);

            string grad;
            int ascii;
            bool ok;
            for (; ; )
            {
                Console.Write("unesi ime grada: ");
                grad = Console.ReadLine().Trim();
                if (grad.Length == 0)
                {
                    Console.WriteLine("nisi unio grad");
                    continue;
                }
                try
                {
                    int.Parse(grad);
                    Console.WriteLine("ime grada ne moze biti broj!!!");
                    continue;
                }
                catch 
                {

                    
                }
                ok = true;
                foreach(char c in grad.ToUpper())
                {
                    ascii = (int)c;
                    if(ascii < 65 || ascii > 90)
                    {
                        ok = false;
                        break;
                    }
                }
                if(!ok)
                {
                    Console.WriteLine("problem s jednim od znakova u nazivu grada");
                    continue;
                }


                break;
            }
            Console.WriteLine("unijeli ste >{0}<", grad);

        }
    }
}

