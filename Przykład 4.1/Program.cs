using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int uczestnik1 = 19;
            int uczestnik2 = 34;
            int uczestnik3 = 23;
            int uczestnik4 = 54;
            int uczestnik5 = 31;
            double srednia = (uczestnik1 + uczestnik2 + uczestnik3 +
            uczestnik4 + uczestnik5) / 5.0;
            Console.WriteLine(srednia);
            Console.ReadKey();
        }
    }
}
