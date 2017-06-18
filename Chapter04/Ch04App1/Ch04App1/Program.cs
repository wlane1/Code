using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Ch04App1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringStuff();
        }

        private static void StringStuff()
        {
            string company = "Microsoft";
            bool startsWithM = company.StartsWith("M");
            bool containsN = company.Contains("N");
            WriteLine($"Starts with M: {startsWithM}, contains an N: {containsN}");
            ReadLine();
        }
    }
}
