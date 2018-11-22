using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._30
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Ala ma kota";
            int liczbaZnakow = 0;
            foreach (char litera in tekst)
                if (litera == 'a') liczbaZnakow++;
            Console.WriteLine("Litera a wystąpiła {0} razy", liczbaZnakow);
            Console.ReadKey();
        }
    }
}
