using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._1
{
    //Napisz program, który tworzy klasę Prostokat, zawierającą dwie prywatne dane
    //składowe: dlugosc, szerokosc, dwie prywatne metody: powierzchnia(), obwod() oraz metodę
    //publiczną – Prezentuj() (która wyświetla powierzchnię i obwód prostokąta) i konstruktor
    //inicjalizujący.W metodzie Main() zdefiniuj obiekt i uruchom dla niego metodę Prezentuj().
    public class Prostokat
    {
        private float dlugosc;
        private float szerokosc;

        public Prostokat(float dlugosc, float szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        private float powierzchnia()
        {
            // Wzór P=a*b
            float P = dlugosc * szerokosc;
            return P;
        }

        private float obwod()
        {
            // Wzór Obw = 2*(a+b)
            float Obw = 2 * (dlugosc + szerokosc);
            return Obw;
        }

        public void prezentuj()
        {
            Console.WriteLine("Powierzchnia prostokąta wynosi: {0}",powierzchnia());
            Console.WriteLine("Obwód prostokąta wynosi: {0}",obwod());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float dlugosc, szerokosc;
            Console.Write("Podaj długość boku prostokąta: " );
            dlugosc = float.Parse(Console.ReadLine());
            Console.Write("Podaj szerokość boku prostokąta: ");
            szerokosc = float.Parse(Console.ReadLine());

            Prostokat p1 = new Prostokat(dlugosc, szerokosc);
            p1.prezentuj();

            Console.Read();
        }
    }
}
