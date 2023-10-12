using _137_VirtualOverride.Entities;

namespace _137_VirtualOverride.Entities
{
    internal class SavingsAccount : Account
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

        // VIRTUAL - OVERRIDE
        public override void Withdraw(double amount)
        {
            //Balance -= amount;

            base.Withdraw(amount);     // desconta o valor na super-class Account
            Balance -= 2.0;  // mais estes 2 = 2 + 5 = 7
        }
  

    }
}
