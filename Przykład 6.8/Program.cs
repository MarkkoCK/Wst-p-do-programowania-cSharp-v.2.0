using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._8
{
    //public struct MojaKlasa
    public class MojaKlasa
    {
        public int Dana { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa p1 = new MojaKlasa();
            p1.Dana = 5;
            MojaKlasa p2 = p1;
            Console.WriteLine("p1.Dana = {0}", p1.Dana);
            Console.WriteLine("p2.Dana = {0}", p2.Dana);
            p1.Dana = 8;
            Console.WriteLine();
            Console.WriteLine("Wartości po zmianie obiektu p1");
            Console.WriteLine("p1.Dana = {0}", p1.Dana);
            Console.WriteLine("p2.Dana = {0}", p2.Dana);
            Console.ReadKey();
        }
    }
}
