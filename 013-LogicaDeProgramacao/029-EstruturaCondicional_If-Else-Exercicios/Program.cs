using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace _029_EstruturaCondicional_If_Else_Exercicios
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
            // Exercicio_8();

            void Exercicio_1()
            {
                Console.WriteLine("1. Ler um número inteiro, e depois dizer se este número é negativo ou não.\n");
                int N = int.Parse(Console.ReadLine());
                if (N < 0)
                {
                    Console.WriteLine("NEGATIVO");
                }
                else
                {
                    Console.WriteLine("NAO NEGATIVO");
                }
            }

            void Exercicio_2()
            {
                Console.WriteLine("2. Ler um número inteiro e dizer se este número é par ou ímpar.\n");
                int N = int.Parse(Console.ReadLine());

                if (N % 2 == 0)
                {
                    Console.WriteLine("PAR");
                }
                else
                {
                    Console.WriteLine("IMPAR");
                }
            }

            void Exercicio_3()
            {
                Console.WriteLine("3. Leia 2 valores inteiros(A e B) e indicar se \"Sao Multiplos\" ou \"Nao sao Multiplos.");

                string[] valores = Console.ReadLine().Split(' ');
                int A = int.Parse(valores[0]);
                int B = int.Parse(valores[1]);

                if (A % B == 0 || B % A == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                }
                else
                {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }

            void Exercicio_4()
            {
                Console.WriteLine("4. Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo,\n" +
                    "\t sabendo que o mesmo pode começar em um dia e terminar em outro, \n" +
                    "\t tendo uma duração mínima de 1 hora e máxima de 24 horas.\n");

                string[] valores = Console.ReadLine().Split(' ');
                int horaInicial = int.Parse(valores[0]);
                int horaFinal = int.Parse(valores[1]);

                int duracao;
                if (horaInicial < horaFinal)
                {
                    duracao = horaFinal - horaInicial;
                }
                else
                {
                    duracao = 24 - horaInicial + horaFinal;
                }

                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }

            void Exercicio_5()
            {
                Console.WriteLine("Código  Preço ");
                Console.WriteLine("1       4.00 Euros");
                Console.WriteLine("2       4.50 Euros");
                Console.WriteLine("3       5.00 Euros");
                Console.WriteLine("4       2.00 Euros");
                Console.WriteLine("5       1.50 Euros\n");

                Console.Write("Indique Código e Quantidade (separados por espaço): ");
                string[] valores = Console.ReadLine().Split(' ');
                int codigo = int.Parse(valores[0]);
                int quantidade = int.Parse(valores[1]);

                double total;
                if (codigo == 1)
                {
                    total = quantidade * 4.0;
                }
                else if (codigo == 2)
                {
                    total = quantidade * 4.5;
                }
                else if (codigo == 3)
                {
                    total = quantidade * 5.0;
                }
                else if (codigo == 4)
                {
                    total = quantidade * 2.0;
                }
                else
                {
                    total = quantidade * 1.5;
                }

                Console.WriteLine("Total: Euros " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            void Exercicio_6()
            {
                Console.WriteLine("6. Leia um valor e devolve a qual dos seguintes intervalos " +
                    "\n\t ([0,25], (25,50], (50,75], (75,100]) este valor se encontra.\n");

                double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (numero < 0.0 || numero > 100.0)
                {
                    Console.WriteLine("Fora de intervalo");
                }
                else if (numero <= 25.0)
                {
                    Console.WriteLine("Intervalo [0,25]");
                }
                else if (numero <= 50.0)
                {
                    Console.WriteLine("Intervalo (25,50]");
                }
                else if (numero <= 75.0)
                {
                    Console.WriteLine("Intervalo (50,75]");
                }
                else
                {
                    Console.WriteLine("Intervalo (75,100]");
                }
            }
            
            void Exercicio_7()
            {
                Console.WriteLine("7.Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas\r" +
                    "\n\t de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o\r" +
                    "\n\t ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).\r" +
                    "\n\n Se o ponto estiver na origem, escreva a mensagem “Origem”." +
                    "\n\n Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.");

                Console.Write("\nDados de x e y: ");
                string[] valores = Console.ReadLine().Split(' ');
                double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

                Console.Write("\nResposta: ");
                if (x == 0.0 && y == 0.0)
                {
                    Console.WriteLine("Origem");
                }
                else if (x == 0.0)
                {
                    Console.WriteLine("Eixo Y");
                }
                else if (y == 0.0)
                {
                    Console.WriteLine("Eixo X");
                }
                else if (x > 0.0 && y > 0.0)
                {
                    Console.WriteLine("Q1");
                }
                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("Q2");
                }
                else if (x < 0.0 && y < 0.0)
                {
                    Console.WriteLine("Q3");
                }
                else
                {
                    Console.WriteLine("Q4");
                }
            }
            
            void Exercicio_8()
            {
                Console.WriteLine("8. Idique o valor do salario para calcular o imposto a pagar: ");

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double imposto;
                if (salario <= 2000.0)
                {
                    imposto = 0.0;
                }
                else if (salario <= 3000.0)
                {
                    imposto = (salario - 2000.0) * 0.08;
                }
                else if (salario <= 4500.0)
                {
                    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
                }
                else
                {
                    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                }

                if (imposto == 0.0)
                {
                    Console.WriteLine("Isento");
                }
                else
                {
                    Console.WriteLine("Euros " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                }

            }

        }
    }
}
