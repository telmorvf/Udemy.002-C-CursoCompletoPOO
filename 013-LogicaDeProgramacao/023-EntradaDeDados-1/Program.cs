using System;
using System.Globalization;

namespace _022_EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique um numero inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Indique um char: ");
            char ch = char.Parse(Console.ReadLine());

            Console.Write("Indique um numero double, com décimas: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Indique nome, sexo, idade, altura, separados por espaço: ");
            string[] vet = Console.ReadLine().Split(' ');
            
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("\nVocê digitou:");
            Console.WriteLine("Número Inteiro: " + n1);
            Console.WriteLine("Char: " + ch);
            Console.WriteLine("Nome: " + n2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\nNome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
