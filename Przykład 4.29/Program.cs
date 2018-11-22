using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._29
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Ala ma kota";
            for (int i = tekst.Length - 1; i >= 0; i--)
                Console.Write(tekst[i]);
            Console.ReadKey();
        }
    }
}
