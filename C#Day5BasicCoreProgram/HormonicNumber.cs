using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day5BasicCoreProgram
{
    internal class HormonicNumber
    {
        public static void FindHormonicNumber(int num)
        {
            float result = 1;
            for (int i = 1; i <= num; i++)
            {
                result += (1 / (float)i);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
