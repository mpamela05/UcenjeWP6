using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.GenericiLambdaEkstenzije
{
    internal class Obrada
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
