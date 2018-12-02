using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._2
{
    //Uzupełnij program z poprzedniego zadania o definicje tablicy obiektów dla
    //prostokątów.W metodzie Main() wyświetl powierzchnie oraz obwód wszystkich prostokątów
    //w tablicy używając(wewnątrz pętli foreach) metody publicznej Prezentuj().
    public class Prostokat
    {
        private float dlugosc;
        private float szerokosc;

        public Prostokat(float dlugosc, float szerokosc) // konstruktor
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        private float powierzchnia() // metoda prywatna
        {
            // Wzór P=a*b
            float P = dlugosc * szerokosc;
            return P;
        }

        private float obwod() // metoda prywatna
        {
            // Wzór Obw = 2*(a+b)
            float Obw = 2 * (dlugosc + szerokosc);
            return Obw;
        }

        public void prezentuj() // metoda publiczna
        {
            Console.WriteLine("Powierzchnia prostokąta wynosi: {0}", powierzchnia());
            Console.WriteLine("Obwód prostokąta wynosi: {0}", obwod());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaracja tablicy obiektów i osobno inicjalizacja elementów
            Prostokat[] tabProstokat = new Prostokat[3];
            tabProstokat[0] = new Prostokat(10, 10);
            tabProstokat[1] = new Prostokat(5, 7.5f);
            tabProstokat[2] = new Prostokat(2.3f, 8.5f);

            foreach  (Prostokat item in tabProstokat)
            {
                item.prezentuj();
            }

            // Deklaracja tablicy obiektów wraz z inicjalizacją elementów
            //Prostokat[] tab = {new Prostokat(10, 10),
            //                    new Prostokat(5, 7.5f),
            //                    new Prostokat(2.3f, 8.5f)};

            // z Zadania 6.1
            //float dlugosc, szerokosc;
            //Console.Write("Podaj długość boku prostokąta: ");
            //dlugosc = float.Parse(Console.ReadLine());
            //Console.Write("Podaj szerokość boku prostokąta: ");
            //szerokosc = float.Parse(Console.ReadLine());
            //Prostokat p1 = new Prostokat(dlugosc, szerokosc);
            //p1.prezentuj();

            Console.Read();
        }
    }
}
