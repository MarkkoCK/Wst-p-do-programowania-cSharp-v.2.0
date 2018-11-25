using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze
            //miesiąc i wyświetli jego nazwę słownie.

            DateTime data = DateTime.UtcNow.Date;
            Console.WriteLine("Dzisiajsza data: {0}",data.ToString("dd-MM-yyyy"));
            Console.WriteLine(String.Format("Dzisiajsza data: {0:MMMM }", data));
            Console.WriteLine(String.Format("Mamy dzisiaj {0:dd} {0:MMMM} {0:yyyy}r", data));
            Console.Read();
        }
    }
}
