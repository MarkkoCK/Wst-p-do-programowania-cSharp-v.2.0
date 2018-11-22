using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._35
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "być albo nie być";
            int pozycja, start = 0;
            Console.WriteLine("0123456789012345"); // pomocniczo, aby numerować znaki
            Console.WriteLine(tekst);
            Console.WriteLine("szukany tekst \"być\" jest na pozycjach:");
            while ((pozycja = tekst.IndexOf("być", start)) >= 0)
            {
                Console.Write("{0}, ", pozycja);
                start = pozycja + 3; // dalsze szukanie 3 znaki dalej (bo "być" ma 3 znaki)
            }
            Console.ReadKey();
        }
    }
}
