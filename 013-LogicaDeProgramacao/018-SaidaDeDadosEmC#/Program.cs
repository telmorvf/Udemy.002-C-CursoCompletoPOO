using System;
using System.Globalization;

namespace _018_SaidaDeDadosEmC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            Console.ReadLine();


            Console.WriteLine("---------------------------");

            Console.WriteLine("Placeholders, concatenação e interpolação");

            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";
            
            // Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
                        
            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + 
                saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            Console.ReadLine();
        }
    }
}
