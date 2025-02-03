namespace Ucenje
{
    internal class E11Z1Lose
    {
       public static void Izvedi()
        {
            int broj1, broj2;

            while (true)
            {
                Console.Write("unesi prvi broj: ");
                try
                {
                    broj1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch 
                {
                    Console.WriteLine("nisi unio broj");
                    
                }
            }

            while (true)
            {
                Console.Write("unesi drugi broj: ");
                try
                {
                    broj2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("nisi unio broj");

                }
            }
            Console.WriteLine("{0} + {1} = {2}", broj1, broj2, broj1+broj2);


        }
    }
}
