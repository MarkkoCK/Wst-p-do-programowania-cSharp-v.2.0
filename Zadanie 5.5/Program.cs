using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._5
{
    class Program
    {
        //Napisz program, który wypisze na ekranie znaki w kształcie prostokąta. Program ma
        //prosić użytkownika o podanie rozmiaru prostokąta: długość i szerokość, a następnie znak,
        //którym ma być zapełniony prostokąt.Napisz metodę Rysuj(), która wypisze na konsoli
        //prostokąt, przesyłając jako argument długość, szerokość oraz znak wypełnienia.Wywołaj
        //metodę dwa razy, za drugim razem podaj na odwrót argumenty dla długości i szerokości.
        //W wyniku działania programu powinny zostać wyświetlone dwa prostokąty, jeden „leżący”
        //oraz drugi „stojący”. Przykładowy przebieg działania programu na rysunku:

        static void Rysuj(int wysokosc, int szerokosc, char znak)
        {
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    Console.Write("{0}",znak);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < szerokosc; i++)
            {
                for (int j = 0; j < wysokosc; j++)
                {
                    Console.Write("{0}", znak);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int a, b;
            char znak;

            Console.Write("Podaj długość: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj szerokość: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Podaj znak: ");
            znak = char.Parse(Console.ReadLine());
            Console.WriteLine();

            Rysuj(a, b, znak);
            Console.Read();
        }
    }
}
