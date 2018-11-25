using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który dla zadeklarowanej niżej zmiennej łańcuchowej wyświetli jej
            //zawartość, poda liczbę wierszy oraz poda liczbę znaków w każdym wierszu.

            // fragment powieści A. A. Milne, "Kubuś Puchatek"
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
            "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
            "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
            "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
            "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
            int pozycja, start = 0;
            int licznikNowaLinia = 1;
            while ((pozycja = tekst.IndexOf("\n", start)) >= 0)
            {
                licznikNowaLinia++;
                start = pozycja + 2;
            } 

            Console.WriteLine("Ilość wierszy: {0}", licznikNowaLinia);
            Console.WriteLine("Ilość znaków: "+ tekst.Length);
            Console.Read();
        }
    }
}
