namespace Ucenje
{
    internal class FibonaccijevNIz
    {
        public static void Izvedi()
        {
            Console.WriteLine("Upisi broj n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Uneseni broj mora bit veci od 0");
                return;
            }
                
            long a = 0, b = 1;
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a + " ");
                a = a + b;
               
            }
            Console.WriteLine();
        }
    }
}
