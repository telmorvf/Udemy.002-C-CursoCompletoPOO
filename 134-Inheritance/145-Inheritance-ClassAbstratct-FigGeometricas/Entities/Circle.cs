using System;
using _145_Inheritance_ClassAbstratct_FigGeometricas.Entities.Enums;


namespace _145_Inheritance_ClassAbstratct_FigGeometricas.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
