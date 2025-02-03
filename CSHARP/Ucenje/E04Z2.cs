namespace Ucenje
{
    internal class E04Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 1) 
            {
                Console.WriteLine("neparan");
            }
            else
            {
                Console.WriteLine("paran");
            }
            //Console.WriteLine(broj % 2 == 0 ? "paran" : "neparan");
        }
    }
}
