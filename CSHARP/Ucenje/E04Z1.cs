namespace Ucenje
{
    internal class E04Z1
    {
        public static void Izvedi() {
            int godine;
            Console.WriteLine("unesite broj godina");
            godine=int.Parse(Console.ReadLine());
            if (godine < 1 | godine >= 122) {
                Console.WriteLine("greska");
            }
            else {
                if (godine > 17)
                {
                    Console.WriteLine("osoba je punoljetna");
                }
                else {
                    Console.WriteLine("osoba je maloljetna");

                }
            }
        }
    }
}
