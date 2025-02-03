namespace Ucenje
{
    internal class E09DoWhilePetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E09");

            do
            {
                Console.WriteLine("Osijek");
            } while (false);

            // zbroj prvih 100 brojeva
            int i = 1, suma = 0;
            do
            {
                suma += i;
            } while (++i <= 100);

            Console.WriteLine(suma);


        }
    }
}
