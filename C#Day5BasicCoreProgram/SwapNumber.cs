using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day5BasicCoreProgram
{
    internal class SwapNumber
    {
        public static void SwapTwoNumbers(int num1, int num2)
        {
            Console.WriteLine("Before swapping numbers: Number1= {0}, Number2= {1}", num1, num2);
            num1 = num1 * num2;
            num2 = num1 / num2; ;
            num1 = num1 / num2;
            Console.WriteLine("After swapping numbers: Number1= {0}, Number2= {1}", num1, num2);
        }
    }
}
