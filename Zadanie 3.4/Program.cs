using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program – prosty kalkulator, który wczytuje od użytkownika wartości dwóch
            //zmiennych typu double oraz znak operacji(+lub – lub* lub /), a następnie wyświetla wynik 
            //operacji dla podanych wartości. Przykładowo użytkownik wprowadził znak „+” i liczby 1,5
            //oraz 2,5, program powinien wyświetlić sumę obu liczb, czyli 4,0.

            double zm1, zm2;
            start:
            Console.WriteLine("Podaj dwie liczby: ");
            Console.WriteLine("Liczba 1: ");
            zm1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Liczba 2: ");
            zm2 = double.Parse(Console.ReadLine());
            int funkcja;
            Console.WriteLine("Jakie działanie chcesz wykoanć: ");
            Console.WriteLine("1 - dodawanie");
            Console.WriteLine("2 - odejmowanie");
            Console.WriteLine("3 - mnożenie");
            Console.WriteLine("4 - dzielenie");
            funkcja = int.Parse(Console.ReadLine());
            double wynik;
            switch (funkcja)
            {
                case 1:
                    wynik = zm1 + zm2;
                    Console.WriteLine("{0} + {1} = " + wynik,zm1,zm2);
                    break;
                case 2:
                    wynik = zm1 - zm2;
                    Console.WriteLine("{0} - {1} = " + wynik, zm1, zm2);
                    break;
                case 3:
                    wynik = zm1 * zm2;
                    Console.WriteLine("{0} * {1} = " + wynik, zm1, zm2);
                    break;
                case 4:
                    wynik = zm1 / zm2;
                    Console.WriteLine("{0} / {1} = " + wynik, zm1, zm2);
                    break;
                default:
                    Console.WriteLine("Nie wybrano poprawnej opcji.");
                    break;
            }
            Console.ReadKey();
            goto start;
        }
    }
}
