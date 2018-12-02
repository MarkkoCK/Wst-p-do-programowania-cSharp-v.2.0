using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._6
{
    //Napisz program (używając klasy Punkt zdefiniowanej w poprzednim zadaniu), który
    //przechowuje dane o trzech punktach w tablicy obiektów i sprawdza przy pomocy statycznej
    //metody, czy leżą one na jednej prostej.
    class Punkt
    {
        // Współrzędne punktu zdefiniowane poprzez właściwości.
        private float _punktA { get; set; }
        private float _punktB { get; set; }

        public Punkt(float punktA, float punktB) //konstruktor
        {
            this._punktA = punktA;
            this._punktB = punktB;
        }

        public void Przesun(Punkt punkt, float a, float b)
        {
            _punktA += a;
            _punktB += b;
        }

        public void Wyswietl(Punkt punkt)
        {
            Console.WriteLine("Aktualna wspórzędna punktu A: {0}\nAktualna wspórzędna punktu B: {1}", _punktA, _punktB);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3, b = 4;
            Punkt p1 = new Punkt(a, b);
            p1.Wyswietl(p1);
            p1.Przesun(p1, 3, 4);
            p1.Wyswietl(p1);

            Console.Read();

        }
    }
}
