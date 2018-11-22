using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._31
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Ala ma kota";
            string fragment;
            fragment = tekst.Substring(4, 6);
            Console.WriteLine(fragment); // wypisze "ma kot"
            Console.ReadKey();
        }
    }
}
