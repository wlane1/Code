using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;
using System.Security;

namespace Ch04_Internationalization
{
    class Program
    {
        static void Main(string[] args)
        {
            //cultureStuff();
            SecureString test;
            test.
        }

        private static void cultureStuff()
        {
            CultureInfo globalization = CultureInfo.CurrentCulture;
            CultureInfo localization = CultureInfo.CurrentUICulture;
            WriteLine($"The current globalization culture is " +
                $"{ globalization.Name}: { globalization.DisplayName}"); 
    WriteLine($"The current localization culture is " +
        $"{ localization.Name}: { localization.DisplayName}"); 
    WriteLine();
            WriteLine("en-US: English (United States)");
            WriteLine("da-DK: Danish (Denmark)");
            WriteLine("fr-CA: French (Canada)");
            Write("Enter an ISO culture code: ");
            string newculture = ReadLine();
            if (!string.IsNullOrEmpty(newculture))
            {
                var ci = new CultureInfo(newculture);
                //CultureInfo.CurrentCulture = ci;
                //CultureInfo.CurrentUICulture = ci;
            }
            Write("Enter your name: ");
            string name = ReadLine();
            Write("Enter your date of birth: ");
            string dob = ReadLine();
            Write("Enter your salary: ");
            string salary = ReadLine();
            DateTime date = DateTime.Parse(dob);
            int minutes = (int)DateTime.Today.Subtract(date).TotalMinutes;

            decimal result;
            decimal earns;
            bool parsed = decimal.TryParse(salary, out result);

            earns = parsed ? result : 0; 

            WriteLine($"{name} was born on a {date:dddd} and is {minutes:N0} " +
                $"minutes old and earns { earns:C}.");
            ReadLine();
        }
    }
}
