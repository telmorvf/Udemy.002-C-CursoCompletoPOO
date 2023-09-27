using System;
using System.Globalization;

namespace _042_ExercicioProdutoStock
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 042 Stock de Produtos - Métodos
            Produto produto;

            produto = new Produto();

            Console.WriteLine("Introduza os dados do produto: ");
            Console.Write("Produto Desc.: ");
            produto.Nome = Convert.ToString(Console.ReadLine());
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em Stock: ");
            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto" + produto);

            int qtd = 0;
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser adicionados ao Stock: ");
            qtd = int.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            produto.AdicionarProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + produto);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a serem removidos do Stock: ");
            qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.RemoverProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + produto);
        }

    }
}
