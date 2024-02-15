using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace _024_EstruturaSequencial_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercicio_1();
            //Exercicio_2();
            //Exercicio_3();
            //Exercicio_4();
            //Exercicio_5();
            Exercicio_6();


            void Exercicio_1()
            {
                int A, B, soma;

                Console.WriteLine("Soma de dois inteiros.\n");
                
                Console.Write("Indique o 1º inteiro: ");
                A = int.Parse(Console.ReadLine());

                Console.Write("Indique o 2º inteiro: ");
                B = int.Parse(Console.ReadLine());

                soma = A + B;

                Console.WriteLine("\nSOMA = " + soma);
            }

            void Exercicio_2()
            {
                double R, A, pi = 3.14159;
                Console.Write("Indique o raio do círculo, com duas casas décimais: ");

                R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                A = pi * R * R;

                Console.WriteLine("Área = " + A.ToString("F4", CultureInfo.InvariantCulture));
            }

            void Exercicio_3()
            {
                int A, B, C, D, dif;

                Console.WriteLine("Calcula a diferença de inteiros entre dois produtos (A * B - C * D)\n");
                Console.Write("Indique A: ");
                A = int.Parse(Console.ReadLine());
                Console.Write("Indique B: ");
                B = int.Parse(Console.ReadLine());
                Console.Write("Indique C: ");
                C = int.Parse(Console.ReadLine());
                Console.Write("Indique D: ");
                D = int.Parse(Console.ReadLine());

                dif = A * B - C * D;

                Console.WriteLine("DIFERENCA = " + dif);
            }

            void Exercicio_4()
            {
                int numero, horas;
                double valorHora, salario;

                Console.Write("Indique número de funcionário 'int': ");
                numero = int.Parse(Console.ReadLine());

                Console.Write("Indique número de horas extra trabalhadas 'int': ");
                horas = int.Parse(Console.ReadLine());

                Console.Write("Indique o valor por hora 'double': ");
                valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                salario = valorHora * horas;

                Console.WriteLine("\nNúmero de Empregado = " + numero);
                Console.WriteLine("Horas Extra * Valor Hora = euro : " + salario.ToString("F2", CultureInfo.InvariantCulture));
            }

            void Exercicio_5()
            {
                int cod1, cod2, qte1, qte2;
                double preco1, preco2, total;

                Console.WriteLine("Calcula o valor a ser pago de 2 artigos com respetivas quantidades e preços.\n");
                Console.WriteLine("1 - Indique código'int', quantidade'int', preço'double': ");
                string[] valores = Console.ReadLine().Split(' ');
                cod1 = int.Parse(valores[0]);
                qte1 = int.Parse(valores[1]);
                preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                Console.WriteLine("2 - Indique código'int', quantidade'int', preço'double': ");
                valores = Console.ReadLine().Split(' ');
                cod2 = int.Parse(valores[0]);
                qte2 = int.Parse(valores[1]);
                preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                total = preco1 * qte1 + preco2 * qte2;

                Console.WriteLine("VALOR A PAGAR: Euros: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            void Exercicio_6()
            {
                double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;
                
                Console.WriteLine("Leia três valores com ponto flutuante de dupla precisão: A, B e C.");
                string[] valores = Console.ReadLine().Split(' ');
                A = double.Parse(valores[0], CultureInfo.InvariantCulture);
                B = double.Parse(valores[1], CultureInfo.InvariantCulture);
                C = double.Parse(valores[2], CultureInfo.InvariantCulture);

                triangulo = A * C / 2.0;
                circulo = 3.14159 * C * C;
                trapezio = (A + B) / 2.0 * C;
                quadrado = B * B;
                retangulo = A * B;

                Console.WriteLine("\n\na) a área do triângulo retângulo que tem A por base e C por altura.");
                Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));

                Console.WriteLine("\nb) a área do círculo de raio C. (pi = 3.14159)");
                Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));

                Console.WriteLine("\nc) a área do trapézio que tem A e B por bases e C por altura.");
                Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));

                Console.WriteLine("\nd) a área do quadrado que tem lado B.");
                Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));

                Console.WriteLine("\ne) a área do retângulo que tem lados A e B.");
                Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));









            }

        }
    }
}
