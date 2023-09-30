using System;
using System.Globalization;

namespace _045._2_FuncionarioSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = (Console.ReadLine());
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func.ToString());

            Console.WriteLine();
            Console.Write("Digite a precentagem para aumentar o salário: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            func.AumentarSalario(percent);
            Console.WriteLine("Dados Atualizados: " + func.ToString());
        }
    }
}
