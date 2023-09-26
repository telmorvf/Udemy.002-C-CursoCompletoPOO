using System;
using System.Globalization;

namespace _039._2_Primeiros_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler os dados de duas pessoas,
            //  depois mostrar o nome da pessoa mais velha.

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do Primeiro Funcionario:");
            Console.Write("Nome: ");
            f1.Nome = Convert.ToString(Console.ReadLine());
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo Funcionario:");
            Console.Write("Nome: ");
            f2.Nome = Convert.ToString(Console.ReadLine());
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = ((f1.Salario + f2.Salario) / 2.00F);

            Console.WriteLine($"Salário Médio: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
