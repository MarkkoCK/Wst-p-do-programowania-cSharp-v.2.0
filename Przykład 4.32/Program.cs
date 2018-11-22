using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolejną użyteczną metodą jest Compare(). Pozwala ona na porównanie dwóch tekstów.
            int wynik;
            string tekst1 = "Kowalski";
            string tekst2 = "Nowak";
            wynik = String.Compare(tekst1, tekst2); // wypisze -1
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
