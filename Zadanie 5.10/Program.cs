using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._10
{
    class Program
    {
        //Jaki będzie rezultat metody Oblicz() wywołanej z parametrem n = 5? Zadanie wykonaj
        //najpierw bez udziału kompilatora, a dopiero później uruchom program i sprawdź otrzymany
        //wynik.
          static int Oblicz(int n)
            {
                if (n <= 1) return (1);
                else return (n + Oblicz(n - 1));
                           
            // 5 + f(5) => 4 + f(4) 15
            // 4 + f(4) => 3 + f(3) 10
            // 3 + f(3) => 2 + f(2) 6
            // 2 + f(2) => 1 + f(1) 3
            // 1 + f(1) => return 1   
            // Tadam ;)
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Oblicz(5));
            Console.Read();
        }
    }
}
