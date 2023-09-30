using System;

namespace _039_Primeiros_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler os dados de duas pessoas,
            //  depois mostrar o nome da pessoa mais velha.

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da Primeira Pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda Pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}.");
            }
            else if  (p2.Idade > p1.Idade)
            { 
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}.");
            }
            else 
            { 
                Console.WriteLine("As duas pessoas têm a mesma idade!");
            };
        }
    }
}
