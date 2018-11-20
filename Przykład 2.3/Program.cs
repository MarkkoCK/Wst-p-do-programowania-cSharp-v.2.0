using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temp. w stopniach Fahrenheita:");
            F = double.Parse(Console.ReadLine());
            //C = 5d / 9d * (F - 32);
            C = 5.0 / 9 * (F - 32);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Temperatura w stopniach Celcjusza wynosi: " + C);
            Console.ReadKey();
        }
    }
}
