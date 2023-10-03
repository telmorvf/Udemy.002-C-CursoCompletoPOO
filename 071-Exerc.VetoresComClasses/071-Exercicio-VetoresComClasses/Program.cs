using System;
using System.Diagnostics;

namespace _071_Exercicio_VetoresComClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] pensao = new Estudante[10];

            int n;
            do
            {
                do
                {
                    Console.Write("Quantos quartos serão alugados? ");
                } while (!int.TryParse(Console.ReadLine(), out n));
            } while (n < 1 || n > 10);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguer #{i}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                pensao[quarto-1] = new Estudante(name, email);
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0;i < pensao.Length ;i++)
            {   
                if (pensao[i] != null)
                {
                    Console.WriteLine($"{i+1}: {pensao[i]}");
                }
            }
        }
    }
}
