using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._9
{
    public class MojaKlasa
    {
        public int Dana { get; set; }

        public MojaKlasa(int d) // konstruktor
        {
            this.Dana = d;
        }
        public MojaKlasa(MojaKlasa kopia) // konstruktor kopiujący
        {
            this.Dana = kopia.Dana;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa p1 = new MojaKlasa(5);
            MojaKlasa p2 = new MojaKlasa(p1); // wywołanie konstr. kopiującego
            Console.WriteLine("p1.Dana = {0}", p1.Dana);
            Console.WriteLine("p2.Dana = {0}", p2.Dana);
            p1.Dana = 8;
            Console.WriteLine();
            Console.WriteLine("Wartości po zmianie obiektu p1");
            Console.WriteLine("p1.Dana = {0}", p1.Dana);
            Console.WriteLine("p2.Dana = {0}", p2.Dana);
            Console.ReadKey();
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.Equals(p2));
            Console.ReadKey();
        }
    }
}
