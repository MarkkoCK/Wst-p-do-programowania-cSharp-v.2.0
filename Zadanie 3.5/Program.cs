using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** Do sprawedzenia poprawności wyników ****
            //Napisz program obliczający liczbę pierwiastków równania kwadratowego. Program ma
            //prosić użytkownika o podanie współczynników równania, a następnie ma wyświetlić
            //stosowny komunikat.
            float a, b, c;
            float delta;
            Console.WriteLine("Podaj liczbę a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c: ");
            c = float.Parse(Console.ReadLine());
            delta = (b * b) - (4 * a * c);

            Console.WriteLine("Delta dla równania kwadratowego = {0}", delta);
            Console.ReadKey();

            if (delta > 0)
            {
                Console.WriteLine("Delta > 0 - dwa rozwiązania, obliczam x1 i x1");
                float x1 = -b + ((float)Math.Sqrt(delta) / 2 * a);
                float x2 = -b - ((float)Math.Sqrt(delta) / 2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}",x1,x2);
            }
            else if (delta == 0)
            {
                Console.WriteLine("Delta == 0 - jest jedno rozwiązanie x=-b/2a");
                float x = -b / 2 * a;
                Console.WriteLine("x = {0}",x);

            }
            else
            {
                // delta ujemna
                Console.WriteLine("Delta < 0 - brak rozwiązania");
            }
            Console.ReadKey();
        }
    }
}
