﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day5BasicCoreProgram
{
    internal class Factors
    {
        public static void FindFactors(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + num);
                }
            }
        }
    }
}
