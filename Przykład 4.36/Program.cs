using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._36
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Ala ma kota";
            string nowyTekst;
            nowyTekst = tekst.Insert(7, "kanarka i ");
            Console.WriteLine(nowyTekst);
            Console.ReadKey();
        }
    }
}
