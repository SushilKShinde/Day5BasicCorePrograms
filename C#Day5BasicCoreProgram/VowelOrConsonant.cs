using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day5BasicCoreProgram
{
    internal class VowelOrConsonant
    {
        public static void CheckTheAlphabet(char character)
        {
            switch (character)
            {
                case 'a':
                    Console.WriteLine("{0} is a vowel", character);
                    break;
                case 'e':
                    Console.WriteLine("{0} is a vowel", character);
                    break;
                case 'i':
                    Console.WriteLine("{0} is a vowel", character);
                    break;
                case 'o':
                    Console.WriteLine("{0} is a vowel", character);
                    break;
                case 'u':
                    Console.WriteLine("{0} is a vowel", character);
                    break;
                default:
                    Console.WriteLine("{0} is a Consonant", character);
                    break;
            }
        }
    }
}
