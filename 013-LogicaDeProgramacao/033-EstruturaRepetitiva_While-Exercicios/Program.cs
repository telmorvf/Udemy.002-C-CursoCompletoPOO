using System;

namespace _033_EstruturaRepetitiva_While_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio_1();
            // Exercicio_2();
            Exercicio_3();

            static void Exercicio_1()
            {
                Console.WriteLine("1. Indique a senha correta.\n");
                Console.Write("Senha: ");
                int senha = int.Parse(Console.ReadLine());

                while (senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                    Console.Write("Senha: ");
                    senha = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Acesso Permitido");
            }

            static void Exercicio_2()
            {
                Console.WriteLine("1. Indique a coordenada x e y separadas por espaço: \n");
                Console.Write("Coordenandas: ");
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                while (x != 0 && y != 0)
                {
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                    else
                    {
                        Console.WriteLine("quarto");
                    }
                    Console.Write("Novas Coordenandas: ");
                    valores = Console.ReadLine().Split(' ');
                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                }

            }

            static void Exercicio_3()
            {
                int alcool = 0;
                int gasolina = 0;
                int diesel = 0;

                Console.WriteLine("Indique o combustível, 4 sair do menu e mostra resultados");
                Console.WriteLine("1 Alcool");
                Console.WriteLine("2 Gasolina");
                Console.WriteLine("3 Diesel");
                Console.WriteLine("4 Sair");

                Console.Write("\nIndique o combustível: ");
                int tipo = int.Parse(Console.ReadLine());

                while (tipo != 4)
                {
                    if (tipo == 1)
                    {
                        alcool = alcool + 1;
                    }
                    else if (tipo == 2)
                    {
                        gasolina = gasolina + 1;
                    }
                    else if (tipo == 3)
                    {
                        diesel = diesel + 1;
                    }
                    Console.Write("Indique novo combustível: ");
                    tipo = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nMUITO OBRIGADO");
                Console.WriteLine("Alcool: " + alcool);
                Console.WriteLine("Gasolina: " + gasolina);
                Console.WriteLine("Diesel: " + diesel);

            }
        }
    }
}
