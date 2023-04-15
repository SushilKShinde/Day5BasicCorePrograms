using System;
using System.Collections.Generic;
using System.Linq;
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
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;

            }
        }
    }
}
