using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            Console.WriteLine("Podaj imię");
            tekst = Console.ReadLine();
            tekst = "Cześć " + tekst;
            Console.WriteLine(tekst);
            Console.WriteLine("ilość znaków w zminnej tekst: " + tekst.Length); // wyświetli liczbę znaków
            Console.WriteLine(tekst.ToUpper() + "!");
            Console.ReadKey();
        }
    }
}
