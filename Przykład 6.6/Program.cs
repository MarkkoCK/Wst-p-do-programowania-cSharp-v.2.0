using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._6
{
    public class Pracownik
    {
        public string Nazwisko { get; set; } // właściwość
        public double Zarobki { get; set; } // właściwość
        public Pracownik(string naz, double zar) // konstruktor
        {
            Nazwisko = naz;
            Zarobki = zar;
        }
        public void PokazPracownika() // metoda
        {
            Console.WriteLine("{0,-15} {1,10}", Nazwisko, Zarobki);
        }
        public static double Sumuj(Pracownik[] tab) // metoda statyczna
        {
            double suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i].Zarobki;
            }
            return suma;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik[] tab = new Pracownik[3];
            tab[0] = new Pracownik("Kowalski", 1250.0);
            tab[1] = new Pracownik("Nowak", 1340.0);
            tab[2] = new Pracownik("Abacki", 2210.0);
            //foreach (Pracownik p in tab)
            //{
            //    p.PokazPracownika();
            //}
            // Pętla for
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i].PokazPracownika();
            }
            Console.WriteLine("Suma {0}", Pracownik.Sumuj(tab));
            Console.ReadKey();
        }
    }
}
