using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day5BasicCoreProgram
{
    internal class QuotientAndReminder
    {
        public static void FindQuotientAndReminder(int dividend, int divisor)
        {
            float quotient = (dividend / divisor);
            float reminder = dividend % divisor;
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Reminder: " + reminder);
        }
    }
}
