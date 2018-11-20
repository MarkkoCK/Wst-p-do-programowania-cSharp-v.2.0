using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę z zakresu 0-2");
            int liczba = int.Parse(Console.ReadLine());
            switch (liczba)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    break;
                default:
                    Console.WriteLine("Nieznana wartość");
                    break;
            }
            Console.ReadKey();
        }
    }
}
