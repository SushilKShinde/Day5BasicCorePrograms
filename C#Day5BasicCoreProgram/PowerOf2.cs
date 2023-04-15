using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day5BasicCoreProgram
{
    internal class PowerOf2
    {
        public static void FindPowerOf2(int num)
        {
            double power = Math.Pow(2, num);
            Console.WriteLine("The {0}th power of 2 is: {1} ", num, power);
        }

        public static void TableOf2(int num)
        {
            ; for (int i = 1; i <= num; i++)
            {
                double power = Math.Pow(2, i);
                Console.WriteLine(power);
            }
        }
    }
}
