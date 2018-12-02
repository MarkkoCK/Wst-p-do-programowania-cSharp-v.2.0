using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._2
{
    public class Pracownik
    {
        public string nazwisko;
        private double zarobki;
        public Pracownik(string n, double z) // konstruktor
        {
            nazwisko = n;
            zarobki = z;
        }
        public void PokazPracownika() // metoda
        {
            Console.WriteLine("{0,-15} {1,10}", nazwisko, zarobki);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik("Kowalski", 1000);
            p1.nazwisko = "Nowak";
            Console.WriteLine( p1.GetType());
            p1.PokazPracownika();
            Console.ReadKey();
        }
    }
}
