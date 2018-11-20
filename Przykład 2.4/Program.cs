using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int komputery = 24;
            int studenci;
            double wynik;
            Console.WriteLine("Podaj liczbę studentów: ");
            //studenci = Convert.ToInt32(Console.ReadLine());
            studenci = int.Parse(Console.ReadLine());
            wynik = (double)studenci / komputery;
            //Kluczowa linia w tym programie, w której pokazujemy rzutowanie zmiennej studenci – z typu int na double. 
            //Przed nazwą tej zmiennej, dla której chcemy rzutować typ umieszczamy w okrągłych nawiasach nazwę typu, na który rzutujemy
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
