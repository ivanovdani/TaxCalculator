using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal gross;
            string input;

            if (args.Length == 0)
            {
                Console.WriteLine("Enter a numeric argument Gross Salary:");
                input = Console.ReadLine();
            }
            else
            {
                input = args[0];
            }

            try
            {
                gross = Decimal.Parse(input);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine($"{TaxCalculator.GetNet(gross)} IDR");
        }
    }
}
