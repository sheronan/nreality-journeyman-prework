using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            for (int i = 1; i <= 100; i++)
            {
                result = i.ToString();
                if (i % 15 == 0)
                    result = "FizzBuzz";
                else if (i % 5 == 0)
                    result = "Buzz";
                else if (i % 3 == 0)
                    result = "Fizz";
                Console.WriteLine(result);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
