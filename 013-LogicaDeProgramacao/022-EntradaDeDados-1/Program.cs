using System;

namespace _022_EntradaDeDados_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Escreva ''Bom Dia'', seguido de Enter: ");
            string frase = Console.ReadLine();
            Console.Write("Indique a 1ª cor: ");
            string x = Console.ReadLine();
            Console.Write("Indique a 2ª cor: ");
            string y = Console.ReadLine();
            Console.Write("Indique a 3ª cor: ");
            string z = Console.ReadLine();
            
            Console.Write("Indique 3 nomes de frutas separadas por um espaço: ");
            string[] v = Console.ReadLine().Split(' ');     
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("\nVocê digitou: " + frase);
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
