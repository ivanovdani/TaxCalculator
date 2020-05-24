using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public static class  TaxCalculator
    {
        public static decimal incomeTax { get; set; } = 0.1m;
        public static decimal socTax { get; set; } = 0.15m;
        public static decimal noTaxationLimit { get; set; } = 1000;
        public static decimal socTaxLimit { get; set; } = 3000;

        public static decimal GetNet(decimal gross)
        {
            decimal deltaToTaxLimit;
            decimal totalTax = 0;
            decimal net = 0;

            deltaToTaxLimit = gross - noTaxationLimit;
            if (deltaToTaxLimit > 0)
            {
                totalTax += incomeTax * deltaToTaxLimit;
                if (deltaToTaxLimit > (socTaxLimit - noTaxationLimit))
                {
                    totalTax += socTax * (socTaxLimit - noTaxationLimit);
                }
                else
                {
                    totalTax += socTax * deltaToTaxLimit;
                }
            }

            net = gross - totalTax;
            return net;
        }
    }
}
