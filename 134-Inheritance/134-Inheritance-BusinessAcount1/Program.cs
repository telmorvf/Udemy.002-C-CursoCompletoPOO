using System;
using _134_Heritage_BusinessAcount1.Entities;

namespace _134_Heritage_BusinessAcount1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = 
                new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.0; // error

            account.Loan(100.00);
            Console.WriteLine(account.Balance);
        }
    }
}
