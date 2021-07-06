using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Account
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; private set; } = 0;

        public void Deposit(decimal Amount)
        {   
            if (Amount <= 0)
            {
                throw new Exception("Amount must be positive");
            }
            Balance += Amount;
        }
        public void Withdraw(decimal Amount)
        {
            if (Amount <= 0)
            {
                throw new Exception("Amount must be positive");
            }
            if (Amount > Balance)
            {
                Console.WriteLine("Insufficiant funds!!");
                return;
            }
            Balance -= Amount;
        }
    }
}
