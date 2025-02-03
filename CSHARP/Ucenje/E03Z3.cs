namespace Ucenje
{
    internal class E03Z3
    {
        public static void Izvedi()
        {

            Console.WriteLine("E03");
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("{0} je manji od {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} je manji od {1}", b, a);
            }
        }
        }
    }
