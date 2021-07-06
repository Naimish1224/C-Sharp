using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var sav1 = Savings.OpenSavingsAccount(200);
            Console.WriteLine($"Balance is {sav1.Balance}");
            var sav3 = new Savings(300);
            Console.WriteLine($"Balance is {sav1.Balance}");



            var acct1 = new Account() { 
                 Id = 123, Description = "My First Account"
            };
            acct1.Deposit(1000);
            acct1.Withdraw(300);
            Console.WriteLine($"Balance is {acct1.Balance}");
            acct1.Deposit(-200);
            Console.WriteLine($"Balance is {acct1.Balance}");
        }

    }
}
