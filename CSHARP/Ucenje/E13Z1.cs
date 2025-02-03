namespace Ucenje
{
    internal class E13Z1
    {
        public static void Izvedi()
        {

            Console.WriteLine("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            while (broj < 0 || broj > 10)
            {
                Console.WriteLine("upisi broj od 1 do 9");
                broj = int.Parse(Console.ReadLine());
            }
            

            Console.WriteLine(Faktorijel(broj));
            
        }
        private static int Faktorijel(int broj)
        {
            if (broj == 1)
            {
                return 1;
            }
            return broj * Faktorijel(broj - 1);
        }
    }
}
