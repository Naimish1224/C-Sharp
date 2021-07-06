using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Savings : Account
    {
        public decimal InterestRate { get; set; } = 0.12m;
        private decimal MinBalance { get; set; } = 200.0m;

        public decimal CalculateInterest(int months)
        {
            return Balance * (InterestRate / 12) * months;
        }

    }


}
