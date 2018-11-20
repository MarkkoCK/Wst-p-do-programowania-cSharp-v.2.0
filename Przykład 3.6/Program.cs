using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie, nazwisko, tekst;
            Console.WriteLine("Podaj imie");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            nazwisko = Console.ReadLine();
            if (imie.Length + nazwisko.Length < 30)
            {
                tekst = imie + " " + nazwisko;
                Console.WriteLine(tekst);
            }
            else
            {
                Console.WriteLine("Imię i nazwisko jest za długie!");
            }
            Console.ReadKey();
        }
    }
}
