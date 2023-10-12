using _134_Heritage_BusinessAcount.Entities;
using _136_Inheritance_BusinessAcount.Entities;
using System;

namespace _136_Inheritance_BusinessAcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);


            // UPCASTING - Converssão da sub-classe para super-classe
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003,"Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);


            // DOWNCASTIMG - é inseguro
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // Não é possivel fazer o downcasting entre duas sub-classes
            // BusinessAccount acc5 = (BusinessAccount)acc3; // Erro na compilação
            if (acc3 is BusinessAccount)
            {
                // Só entra no if se o acc3 for do tipo BusinessAccount
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }
            
            if (acc3 is SavingsAccount)
            {
                // Só entra no if se o acc3 for do tipo BusinessAccount
                // SavingsAccount acc5 = (SavingsAccount)acc3;   OU
                   SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance() ;
                Console.WriteLine("Balance Updated!!!");
            }
        }
    }
}
