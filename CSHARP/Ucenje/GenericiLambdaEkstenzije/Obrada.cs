namespace Ucenje.GenericiLambdaEkstenzije
{
    internal class Obrada
    {
        public class Obrada<T> : ISucelje where T : Entitet
        {
            public T? ObjektObrade { get; set; }

            public List<T>? ListaObrade { get; set; }

            public void OdradiPosao()
            {
                Posao();
            }

            public void Posao()
            {
                Console.WriteLine(ObjektObrade?.Sifra);
            }

        }
    }
}
