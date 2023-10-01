using System;
using System.Globalization;

namespace _060_Classes_Encapsulamento_ContaBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique o número de conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Indique o titular da conta: ");
            string titular = Convert.ToString(Console.ReadLine());

            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());

            ContaBancaria cont;
            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double quantiaIn = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cont = new ContaBancaria(conta, titular, quantiaIn);
            }
            else
            {
                cont = new ContaBancaria(conta, titular);
            }

            Console.WriteLine("\nDados da conta.");
            Console.WriteLine(cont.ToString());

            Console.Write("\nEntre um valor para o depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cont.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cont.ToString());

            Console.Write("\nEntre um valor para o saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cont.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cont.ToString());
        }
    }
}
