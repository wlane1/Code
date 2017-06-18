using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Console;

namespace Chapter04_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexStuff();
        }

        private static void RegexStuff()
        {
            Write("Enter your age: ");
            string input = ReadLine();
            var ageChecker = new Regex(@"^\d+");

            if (ageChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
                ReadLine();
            }
            else
            {
                WriteLine($"This is not a valid age: {input}");
                ReadLine();
            }
        }
    }
}
