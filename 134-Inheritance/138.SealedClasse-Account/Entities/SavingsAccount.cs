using _138.SealedClasse_Account.Entities;

namespace _138.SealedClasse_Account.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // SEALED CLASS
        // VIRTUAL - OVERRIDE
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);  // desconta o valor na super-class Account
            Balance -= 2.0;         // mais estes 2 = 2 + 5 = 7
        }
  

    }
}
