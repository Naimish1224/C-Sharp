using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Savings : Account
    {
        public decimal InterestRate { get; set; } = 0.12m;
        private static decimal MinBalance { get; set; } = 200.0m;

        public override void Withdraw(decimal Amount)
        {   if (Balance - Amount < MinBalance)
            {
                throw new Exception($"Amount to withdraw must be < {Balance - MinBalance}");
            }
            base.Withdraw(Amount);
        }

        public decimal CalculateInterest(int Months)
        {
            var InterestAmount = Balance * (InterestRate / 12) * Months;
            Deposit(InterestAmount);
            return InterestAmount;
        }
        public static Savings OpenSavingsAccount(decimal OpenAmountDeposit)
        {
            if (OpenAmountDeposit < MinBalance)
            {
                throw new Exception($"Opening savings requires {MinBalance} deposit.");
            }
            var savings = new Savings();
            savings.Deposit(OpenAmountDeposit);
            return savings;
        }
        private Savings() {}
        public Savings(decimal OpenAmountDeposit) : base() {
            if (OpenAmountDeposit < MinBalance)
            {
                throw new Exception($"Opening savings requires {MinBalance} deposit.");
            }
            Deposit(OpenAmountDeposit);
        }



    }


}
