using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program pobierający od użytkownika 3 liczby. Program ma wyświetlić wartość
            //największej z nich.

            int a, b, c;
            Console.WriteLine("Podaj 3 liczby:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                if (a > c)
                {
                    Console.WriteLine("Największa liczba to: {0}",a);
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine("Największa liczba to: {0}", b);
                    }
                    else
                    {
                        Console.WriteLine("Największa liczba to: {0}", c);
                    }
                    
                }
            }
            else
            {
                if (b >= c)
                {
                    Console.WriteLine("Największa liczba to: {0}", b);
                }
            }
            Console.ReadKey();
        }
    }
}
