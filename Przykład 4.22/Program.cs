using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] zespoly = {
                new string[] { "Adam", "Karol" },
                new string[] { "Ola", "Ela", "Jan" } };
            for (int i = 0; i < zespoly.Length; i++)
            {
                for (int j = 0; j < zespoly[i].Length; j++)
                {
                    Console.Write("{0,-10}", zespoly[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
