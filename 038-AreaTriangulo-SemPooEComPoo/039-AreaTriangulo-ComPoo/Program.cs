﻿using System;
using System.Globalization;

namespace _038_AreaTriangulo_ComPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Código a utilizar a POO (Classes)
            // Ler os 3 lados de qualquer tipo de triangulo e apresentar a área, utilizado a formula de Heron

            // SIMPLIFICAR - Adicionar uma Classe e criar propriedades e atribuir o Objeto mem.(Stak) que é uma
            //    referência para instanciação do objeto em mem.(Heap) onde será guardada a informação do objeto.
            //    Podemos dizer que a referência está a apontar para null.

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
