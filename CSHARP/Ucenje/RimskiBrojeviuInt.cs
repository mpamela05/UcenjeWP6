namespace Ucenje
{
    internal class RimskiBrojeviuInt
    {
        public static void Main()
        {
            Console.WriteLine("III");
            Console.WriteLine("LVIII");
            Console.WriteLine("MCMXCIV");
        }
            public static int Izvedi()
            {
            
        
            Dictionary<char, int> rimskiBrojevi = new Dictionary<char, int>();
            {
                rimskiBrojevi.Add('I', 1);
                rimskiBrojevi.Add('V', 5);
                rimskiBrojevi.Add('X', 10);
                rimskiBrojevi.Add('L', 50);
                rimskiBrojevi.Add('C', 100);
                rimskiBrojevi.Add('D', 500);
                rimskiBrojevi.Add('M', 1000);

            };
            string s = ""; 
            int ukupno = 0;
            int prijasnjaVrijednost = 0;

            for (int i = s.Length -1; i >= 0; i--)
            {
                int sadasnjeVrijednosti = rimskiBrojevi[s[i]]; 
                if ( sadasnjeVrijednosti < prijasnjaVrijednost )
                {
                    ukupno -= sadasnjeVrijednosti;
                }
                else
                {
                    ukupno += sadasnjeVrijednosti;
                }
                prijasnjaVrijednost = sadasnjeVrijednosti;
            }
            return ukupno;

            




        }
    }
}
