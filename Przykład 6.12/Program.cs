using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._12
{
    public class Pracownik
    {
        private string nazwisko;
        private double zarobki;
        public Pracownik(string naz, double zar)
        {
            nazwisko = naz;
            zarobki = zar;
        }
        public override string ToString()
        {
            return String.Format("{0,-15} {1,10}", nazwisko, zarobki);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik("Kowalski", 1250.0);
            Console.WriteLine(p1.ToString()); // wyświetlenie danych pracownika
            Console.ReadKey();
        }
    }
}
