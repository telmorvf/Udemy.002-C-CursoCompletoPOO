using System;

namespace ConvencoesParaNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();

            Console.WriteLine($"Saldo: {contaBancaria.GetSaldo()}");
        }
    }

    class ContaBancaria
    {
        public string Titular { get; set; }

        private double _saldo;

        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }

        public double GetSaldo()
        {
            _saldo = 1;
            return _saldo;
        }
    }
}
