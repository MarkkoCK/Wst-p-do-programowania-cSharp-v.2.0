using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który oblicza deltę dla równania kwadratowego a*(x*x)+b*x+c=0.
            //Program ma prosić użytkownika o podanie współczynników równania a, b oraz c.Wzór: Delta=(b*b)-4ac
            float a,b,c;
            float delta;
            Console.WriteLine("Podaj liczbę a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c: ");
            c = float.Parse(Console.ReadLine());
            delta = (b * b) - (4 * a * c);

            Console.WriteLine("Delta dla równania kwadratowego = {0}",delta);
            Console.ReadKey();
        }
    }
}
