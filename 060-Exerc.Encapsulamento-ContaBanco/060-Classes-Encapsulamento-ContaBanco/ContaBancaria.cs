using System.Globalization;

namespace _060_Classes_Encapsulamento_ContaBanco
{
    internal class ContaBancaria
    {
        //Propridades
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Construtores
        public ContaBancaria() { }
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double saldo)
            : this (numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        // Metodo Override Polimorfismo
        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}