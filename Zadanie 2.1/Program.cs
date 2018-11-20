using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program przeliczający temperaturę w stopniach Celsjusza na temperaturę w
            //stopniach Fahrenheita. Program ma prosić użytkownika o podanie temperatury w stopniach
            //Celsjusza.Wzór: F=32+(9/5)C

            float c;
            Console.WriteLine("Podaj temerature w stoniach celcjusza: ");
            c = float.Parse(Console.ReadLine());
            float F = 32f + (9f / 5f) * c;
            Console.WriteLine("Temperatura w stopniach Celcjusza {0} \nTemperatura w stopniach Fahrenheita {1}", c,F);
            Console.ReadKey();


        }
    }
}
