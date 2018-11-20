using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=0, y;
            write:
            Console.WriteLine("Podaj x (większe od 0): ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x > 0)
            { }
            else 
            {
                Console.WriteLine("X musi być większe od 0!!!, podaj liczbę jeszcze raz: ");
                goto write;
            }
            y = Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0));
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
