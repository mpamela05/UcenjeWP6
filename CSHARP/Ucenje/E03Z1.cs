
namespace Ucenje
{
    internal class E03Z1
    {
        public static void Izvedi() 
        {

            int a,b;
            Console.WriteLine("Unesi dva cijela broja; ");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj je: " + (a+b));
            Console.WriteLine("Razlika je: " + (a-b));
            Console.WriteLine("Umnozak je: " + (a*b));
            Console.WriteLine("Zbroj kvadrata: " + (a*a+b*b));
            Console.WriteLine("Kvocijent je: " + (a%b));
           


          
        }
    }
}
