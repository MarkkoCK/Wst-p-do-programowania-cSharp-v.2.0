using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._4
{
    //Zdefiniuj klasę, która pozwoli na rejestrację zużycia energii elektrycznej. Klasa
    //powinna pozwalać na:
    //* rejestrację początkowego i bieżącego stanu licznika energii,
    //* uzyskanie danych o początkowym oraz bieżącym stanie licznika,
    //* obliczanie zużytej energii.

    class ZuzyciePradu
    {
        private float stanpoczatkowy;
        private float stankoncowy;
        
        public ZuzyciePradu(float stanpoczatkowy, float stankoncowy) //konstruktor
        {
            this.stanpoczatkowy = stanpoczatkowy;
            this.stankoncowy = stankoncowy;
        }

        public void WyswietlStanyLicznikow()
        {
            Console.WriteLine("Stan początkowy licznika: {0}\nStan końcowy licznika: {1}",stanpoczatkowy,stankoncowy);
        }

        public void ZuzycieEnergii() // Metoda publiczna oblicza zużycie energii
        {
            if (stanpoczatkowy > stankoncowy)
            {
                Console.WriteLine("Podano złą wartość stanu początkowego lub końcowego.\nStan końcowy nie może być mniejszy od początkowego.");
            }
            else
            {
                float zuzycie = 0;
                zuzycie = stankoncowy - stanpoczatkowy;
                Console.WriteLine("Zuzycie wyniosło {0}KWh", zuzycie);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            float stanpoczatkowy, stankoncowy;
            Console.Write("Podaj początkowy stan licznika: ");
            stanpoczatkowy = float.Parse(Console.ReadLine());
            Console.Write("Podaj podaj aktualny stan licznika: ");
            stankoncowy = float.Parse(Console.ReadLine());

            ZuzyciePradu mieszkanie1 = new ZuzyciePradu(stanpoczatkowy,stankoncowy);
            mieszkanie1.WyswietlStanyLicznikow();
            mieszkanie1.ZuzycieEnergii();


            Console.Read();
        }
    }
}
