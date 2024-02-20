using System;
using System.Collections.Generic;
using _219B_HashCollections_WithOUT_GetHashCode___Equals.Entities;

namespace _219B_HashCollections_WithOUT_GetHashCode___Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));
            
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            // Dados Tipo Referência - procura por referência de memória
            // pq são objectos diferentes = False (sem override no Product)
            // Com override no Product GetHashCode() e Equals() dá = True
            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            // Dados Tipo struct - procura por Valor (passo valores e não referências de memória)
            Point point = new Point(5, 10); 
            Console.WriteLine(b.Contains(point));
        }
    }
}
