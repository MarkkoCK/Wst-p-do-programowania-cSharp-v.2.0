using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._22
{
    class Program
    {
        static void Main(string[] args)
        {
            string odpowiedz;
            do
            {
                Console.WriteLine("Czas: {0}", DateTime.Now);
                Console.WriteLine("Ponownie pokazać aktualny czas? (t/n)");
                odpowiedz = Console.ReadLine();
            } while (odpowiedz != "n");
        }
    }
}
