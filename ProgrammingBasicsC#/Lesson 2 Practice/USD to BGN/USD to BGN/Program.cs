﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = 1.79549;

            double toBGN = USD * BGN;

            Console.WriteLine($"{toBGN:F2}");
        }
    }
}