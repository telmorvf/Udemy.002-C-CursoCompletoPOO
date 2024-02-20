using System;
using GetHashCode___Equals.Entities;

namespace GetHashCode___Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine("Cliente a = " + a.Name + " - " + a.Email);
            Console.WriteLine("Cliente b = " + b.Name + " - " + b.Email);

            Console.WriteLine($"\na.Equals(b) = {a.Equals(b)} -> Objetos iguais do ponto de vista do conteudo.\n"); 

            Console.WriteLine($"a == b = {a == b} -> Objetos diferentes do ponto de vista da referência.\n");

            // uso o GetHashCode() "99% certeza + rápido" para buscas grande,
            // no final reconfirmo com o Equals() "100% certeza + lento"
            // para determinar se os valores são verdadeiramente iguais
            Console.WriteLine("a.GetHashCode() = " + a.GetHashCode());
            Console.WriteLine("b.GetHashCode() = " + b.GetHashCode());
        }
    }
}
