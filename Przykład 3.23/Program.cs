using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dodatni wykładnik");
            int wykladnik = Convert.ToInt16(Console.ReadLine());
            if (wykladnik > 0)
            {
                int potega = 1;
                for (int i = 1; i <= wykladnik; i++)
                {
                    potega = potega * 2;
                    Console.WriteLine("2 do {0,2} = {1,2}", i, potega);
                }
            }

            //Pętla while
            //int i = 1;
            //while (i <= wykladnik)
            //{
            //    potega = potega * 2;
            //    Console.WriteLine("2 do {0,2} = {1,2}", i, potega);
            //    i++;

            ////Pętla do...while
            //int i = 1;
            //do
            //{
            //    potega = potega * 2;
            //    Console.WriteLine("2 do {0,2} = {1,2}", i, potega);
            //    i++;
            //} while (i <= wykladnik);

            Console.ReadKey();
        }
    }
}
