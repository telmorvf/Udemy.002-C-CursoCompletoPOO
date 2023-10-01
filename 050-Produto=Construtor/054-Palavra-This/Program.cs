using System;
using System.Globalization;

namespace _054_Palavra_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Construtor por defeito, sem construtor na classe Produto
            //Produto p = new Produto();
            //
            // Intanciar com quantidades na chamada do construtor
            // Produto p = new Produto("Telmo", 20.00, 20);
            //
            // Console.WriteLine(p.ToString());

            Console.WriteLine("Introduza os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();
            
            //Produto p3 = new Produto()
            //{
            //    Nome = nome,
            //    Preco = preco,
            //    Quantidade = 20,
            //};

            Console.WriteLine($"O valor quantidade é incializado com quantidade: {p.Quantidade}");
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao stock: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do stock: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
