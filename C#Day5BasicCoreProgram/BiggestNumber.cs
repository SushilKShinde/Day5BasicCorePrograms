using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day5BasicCoreProgram
{
    internal class BiggestNumber
    {
        public static void FindBeggerNumber(int n1, int n2, int n3)
        {
            if (n1 >= n2 && n1 >= n3) //5 5 1
            {
                Console.WriteLine("{0} is bigger number.", n1);
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine("{0} is biggest number.", n2);
            }
            else
            {
                Console.WriteLine("{0} is biggest number.", n3);
            }
        }
    }
}
