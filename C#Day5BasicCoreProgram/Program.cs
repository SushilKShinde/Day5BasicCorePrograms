using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace C_Day5BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the c# basic core problems");
            Console.WriteLine("Choose option for program from below options");
            Console.WriteLine("1.FlipCoin");
            int option = Convert.ToInt32(Console.ReadLine());  

            switch (option)
            {
                case 1:
                    Console.WriteLine("Coin is flipped 100 times ");
                    FlipCoin.FlipACoin();
                    break;
                case 2:
                    Console.WriteLine("Enter a 4 digit year");
                    int n = Convert.ToInt32(Console.ReadLine());
                    LeapYear.CheckForLeapYear(n);
                    break;
                case 3:
                    Console.WriteLine("Enter a number upto  which power of 2 you want an answer");
                    int m = Convert.ToInt32(Console.ReadLine());
                    PowerOf2.FindPowerOf2(m);
                    PowerOf2.TableOf2(m);
                    break;
                case 4:
                    Console.WriteLine("Enter a interger number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    HormonicNumber.FindHormonicNumber(num);
                    break;
                case 5:
                    Console.WriteLine("Enter the dividend value");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of divisor");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    QuotientAndReminder.FindQuotientAndReminder(dividend, divisor);
                    break;
                case 6:
                    Console.WriteLine("Enter the integer number");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    EvenOrOdd.FindEvenOrOdd(num1);
                    break;
                case 7:
                    //uplaoding twice
                    Console.WriteLine("Enter the fisrt integer");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    SwapNumber.SwapTwoNumbers(number1, number2);
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;

            }
        }
    }
}
