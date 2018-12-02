using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._3
{
    public class Pracownik
    {
        public string nazwisko;
        private double zarobki;
        public double Zarobki // właściwość dla pola zarobki
        {
            get { return zarobki; }
            set { zarobki = value; }
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
            Pracownik p1 = new Pracownik();
            p1.nazwisko = "Kowalski";
            p1.Zarobki = 1250.0; // użycie akcesora set
            p1.PokazPracownika();
            Console.WriteLine(p1.Zarobki); // użycie akcesora get
            Console.ReadKey();
        }
    }
}
