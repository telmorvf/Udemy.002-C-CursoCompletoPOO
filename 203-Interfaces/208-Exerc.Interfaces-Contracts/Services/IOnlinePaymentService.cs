namespace _208_Exerc.Interfaces_Contracts.Services
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);

        double Interest(double amount, int months);

    }
}
