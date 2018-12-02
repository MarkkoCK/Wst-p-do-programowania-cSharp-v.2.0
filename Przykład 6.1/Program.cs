using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._1
{
    class Program
    {
        public class Pracownik
        {
            public string nazwisko;
            private double zarobki;
            public static int liczbaPracownikow;
            public const double etat = 1.0;
        }
        //Klasa Pracownik zawiera cztery pola:
        // nazwisko – typu string, do którego jest dostęp publiczny,
        // zarobki – typu double, do którego jest dostęp prywatny,
        // liczbaPracownikow – statyczne typu int, do którego jest dostęp publiczny,
        // etat – stałe typu double, do którego jest dostęp publiczny.
        static void Main(string[] args)
        {
        }
    }
}
