﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._26
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                if (i == 4)
                    continue; // pomiń dalsze instrukcje i wznów pętle
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
