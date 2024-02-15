using System;

namespace _027_EstruturaCondicional_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Para Ou Impar
            //Program_1();
            
            // 2 - Bom, Dia, Boa Tarde, Boa Noite
            Program_2();


            // --------------------------------------------------------------------------
            // 1 - Para Ou Impar
            // Estrutura Condicional Composta
            void Program_1()
            {
                int n = 0;
                while (n < 2)
                {
                    Console.Write($"Entre {n+1}º com um número inteiro: ");
                    int x = int.Parse(Console.ReadLine());
                    if (x % 2 == 0)
                    {
                        Console.WriteLine($"O valor {x} é Par!\n");
                    }
                    else
                    {
                        Console.WriteLine($"O valor {x} é Impar!\n");
                    }
                    n++;
                } 
            }

            // 2 - Bom, Dia, Boa Tarde, Boa Noite
            // Estrutura Condicional Encadeamento
            void Program_2()
            {
                int n = 0;
                while (n < 3)
                {
                    Console.Write("Qual a hora atual? ");
                    int hora = int.Parse(Console.ReadLine());
                    if (hora < 12)
                    {
                        Console.WriteLine("Bom dia!\n");
                    }
                    else if (hora < 18)
                    {
                        Console.WriteLine("Boa tarde!\n");
                    }
                    else
                    {
                        Console.WriteLine("Boa noite!\n");
                    }

                    n++;
                }


            }
        }
    }
}
