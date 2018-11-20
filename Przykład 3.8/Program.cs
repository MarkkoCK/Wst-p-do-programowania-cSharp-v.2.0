using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            if (numer == "1")
                Console.WriteLine("Poniedziałek");
            else if (numer == "2")
                Console.WriteLine("Wtorek");
            else if (numer == "3")
                Console.WriteLine("Środa");
            else if (numer == "4")
                Console.WriteLine("Czwartek");
            else if (numer == "5")
                Console.WriteLine("Piątek");
            else if (numer == "6")
                Console.WriteLine("Sobota");
            else if (numer == "7")
                Console.WriteLine("Niedziela");
            else
                Console.WriteLine("Nie ma takiego dnia tygodnia");
            Console.ReadKey();
        }
    }
}
