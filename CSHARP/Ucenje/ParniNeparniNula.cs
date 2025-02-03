namespace Ucenje
{
    internal class ParniNeparniNula
    {
        public static void Izvedi()
        {
            Console.WriteLine("upisite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 1)
            {
                Console.WriteLine("neparan");
            }
            else
            {
                Console.WriteLine("paran");
            }
        }
    }
}
