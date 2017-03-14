using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demoNumbers = new int[8];
            int x;
            int userEntry;
            string inputString;

            for(x = 0; x < demoNumbers.Length; ++x)
            {
                Write("Enter in eight integers {0}: ", x + 1);
                inputString = ReadLine();
                demoNumbers[x] = Convert.ToInt32(inputString);
            }

            WriteLine("\n---------------");
            WriteLine("Numbers in original order: ");

            for(x = 0; x < demoNumbers.Length; ++x)
                Write("{0, 6}", demoNumbers[x]);
         

            WriteLine("\n---------------");
            Array.Sort(demoNumbers);
            WriteLine("Numbers in sorted order: ");

            for(x = 0; x < demoNumbers.Length; ++x)
                Write("{0, 6}", demoNumbers[x]);


            WriteLine("\n-----------------");
            Array.Reverse(demoNumbers);
            WriteLine("Numbers in reverse order: ");

            for(x = 0; x < demoNumbers.Length; ++x)
                Write("{0, 6}", demoNumbers[x]);


            WriteLine("\n-----------------");
            WriteLine("Enter in your favorite number position from one through eight {0}: ");
            inputString = ReadLine();
            userEntry = Convert.ToInt32(inputString);
            x = Array.BinarySearch(demoNumbers, userEntry);
            if (x < 0)
                WriteLine("Number {0} not found", userEntry);
            else
                WriteLine("Number {0} found at position {1} ", userEntry, x);

            ReadKey();
                
        }
    }
}
