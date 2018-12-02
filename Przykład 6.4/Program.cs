using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._4
{
    public class Pracownik
    {
        public string nazwisko;
        public double Zarobki { get; set; } // automatyczna właściwość
        public void PokazPracownika() // metoda
        {
            Console.WriteLine("{0,-15} {1,10}", nazwisko, Zarobki);
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
