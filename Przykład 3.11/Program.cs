using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            double cena = 0.0;
            Console.WriteLine("Podaj porcję (S / M / L)");
            string porcja = Console.ReadLine();
            switch (porcja)
            {
                case "S":
                    cena += 4.5;
                    break;
                case "M":
                    //Console.WriteLine("Cena w case M: {0}",cena);
                    cena += 2.0;
                    goto case "S";
                case "L":
                    cena += 3.0;
                    goto case "S";
                default:
                    Console.WriteLine("Podano zły symbol");
                    break;
            }
            Console.WriteLine(cena);
            Console.ReadKey();
        }
    }
}
