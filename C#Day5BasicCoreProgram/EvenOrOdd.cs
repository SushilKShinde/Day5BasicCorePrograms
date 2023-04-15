using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day5BasicCoreProgram
{
    internal class EvenOrOdd
    {
        public static void FindEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is even", num);
            }
            else
            {
                Console.WriteLine("{0} is odd", num);
            }
        }
    }
}
