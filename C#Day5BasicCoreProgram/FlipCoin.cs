using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day5BasicCoreProgram
{
    internal class FlipCoin
    {
        public static void FlipACoin()
        {
            double headPercentage = 0;
            double tailPercentage = 0;
            int heads = 0;
            int tails = 0;

            for (int i = 1; i < 100; i++)
            {
                Random random = new Random();
                int coin = random.Next(1, 3);
                if (coin == 1)
                {
                    heads += 1;
                }
                else if (coin == 2)
                {
                    tails += 1;
                }
                else
                {
                    Console.WriteLine("out ArgumentOutOfRangeException ifff");
                }

                // Console.ReadLine();
            }
            headPercentage = (heads / 10.0);
            tailPercentage = 100 - headPercentage;
            Console.WriteLine("headPercentage: " + headPercentage);
            Console.WriteLine("Head: " + heads);
            Console.WriteLine("tailPercentage: " + tailPercentage);
            Console.WriteLine("Tails: " + tails);

        }
    }
}
