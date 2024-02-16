using System;
using System.Globalization;

namespace _035_EstruturaRepetitiva_For_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio_1();
            // Exercicio_2();
            // Exercicio_3();
            // Exercicio_4();
            // Exercicio_5();
            // Exercicio_6();
             Exercicio_7();

            static void Exercicio_1()
            {
                Console.WriteLine("1. Leia um valor inteiro, em seguida mostra os impares até a esse inteiro.\n");
                Console.Write("Numero inteiro: ");
                int x = int.Parse(Console.ReadLine());

                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            static void Exercicio_2()
            {
                Console.Write("2. Número de inteiros a introduzir: ");
                int n = int.Parse(Console.ReadLine());

                int cont_in = 0;
                int cont_out = 0;

                Console.WriteLine($"Conta os {n} inteiros no intervalo de [10,20]");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i+1}º Valor: ");
                    int x = int.Parse(Console.ReadLine());
                    if (x >= 10 && x <= 20)
                    {
                        cont_in = cont_in + 1;
                    }
                    else
                    {
                        cont_out = cont_out + 1;
                    }
                }
                Console.WriteLine("\n" + cont_in + " in");
                Console.WriteLine(cont_out + " out");
            }

            static void Exercicio_3()
            {
                Console.WriteLine("3. Leia um valor inteiro N, que representa o número de casos de teste que vem a seguir.");
                Console.Write("Numero de Casos: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Caso {i+1}: Indique os 3 valores reais separados por espaço: ");
                    string[] line = Console.ReadLine().Split(' ');
                    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                    Console.Write("A média ponderada é: ");
                    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture) + "\n");
                }
            }

            static void Exercicio_4()
            {
                Console.Write("4. Número de inteiros a introduzir: \n");
                Console.Write("Número de Casos: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nLeia N pares de números e mostre a divisão do primeiro pelo " +
                    $"segundo.\r\n\t Se o denominador for igual a zero, mostrar a mensagem \"divisao impossivel\".\n");
                
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Caso {i + 1}: Indique os 2 valores inteiros separados por espaço: ");
                    string[] line = Console.ReadLine().Split(' ');
                    int x = int.Parse(line[0]);
                    int y = int.Parse(line[1]);

                    if (y == 0)
                    {
                        Console.WriteLine("divisao impossivel\n");
                    }
                    else
                    {
                        double div = (double)x / y;
                        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture) + "\n");
                    }
                }
            }

            static void Exercicio_5()
            {
                Console.WriteLine("5.  Calcular e escrever seu respectivo fatorial. \n");
                Console.Write("Ler o valor: ");
                int n = int.Parse(Console.ReadLine());

                int fat = 1;
                for (int i = 1; i <= n; i++)
                {
                    fat = fat * i;
                }
                Console.Write($"O fatorial de {n} é: ");
                Console.Write(fat);

                Console.ReadKey();
            }

            static void Exercicio_6()
            {
                Console.WriteLine("6. Ler um número inteiro N e calcular todos os seus divisores, ou seja quando dá resto de zero.\n");
                Console.Write("Ler o valor: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Os Divisores são: ");
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            static void Exercicio_7()
            {
                Console.WriteLine("7. Mostra o nr. da linha o quadrado e o cubo.\n");
                Console.Write("Ler o valor: ");

                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("\nOs valores são: ");
                for (int i = 1; i <= n; i++)
                {
                    int primeiro = i;
                    int segundo = i * i;
                    int terceiro = i * i * i;
                    Console.WriteLine($"{primeiro} \t {segundo} \t {terceiro}");
                }
            }
        }
    }
}
