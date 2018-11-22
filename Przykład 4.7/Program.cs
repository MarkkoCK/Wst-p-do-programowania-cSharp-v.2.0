using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile chcesz wpisać imion?");
            int rozmiar = Convert.ToInt32(Console.ReadLine());
            string[] imiona = new string[rozmiar];
            for (int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine("Podaj {0} imię", i + 1);
                imiona[i] = Console.ReadLine();
            }
            for (int i = 0; i < imiona.Length; i++)
            {
                Console.Write(imiona[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
