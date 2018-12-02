using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba >= 0)
            
                Console.WriteLine("Pierwiastek {0}", Math.Sqrt(liczba));
            } // Klamra do usunięcia
            Console.WriteLine("Potęga {0}", Math.Pow(liczba, 2));
            Console.ReadKey();
        }
    }
}
