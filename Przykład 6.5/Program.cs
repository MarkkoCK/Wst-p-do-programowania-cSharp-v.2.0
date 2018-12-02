using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._5
{
    public class Pracownik
    {
        public static int liczbaPrac; // pole statyczne
        public string Nazwisko { get; set; } // właściwość
        public double Zarobki { get; set; } // właściwość
        public Pracownik(string naz, double zar) // konstruktor
        {
            liczbaPrac++;
            Nazwisko = naz;
            Zarobki = zar;
        }
        static Pracownik() //konstruktor statyczny
        {
            liczbaPrac = 0;
        }
        public void PokazPracownika() // metoda
        {
            Console.WriteLine("{0,-15} {1,10}", Nazwisko, Zarobki);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba {0}", Pracownik.liczbaPrac);
            Pracownik p1 = new Pracownik("Kowalski", 1250.0);
            p1.PokazPracownika();
            Pracownik p2 = new Pracownik("Nowak", 1340.0);
            p2.PokazPracownika();
            Console.WriteLine("Liczba {0}", Pracownik.liczbaPrac);
            Console.ReadKey();
        }
    }
}
