using _145_Inheritance_ClassAbstratct_FigGeometricas.Entities.Enums;

namespace _145_Inheritance_ClassAbstratct_FigGeometricas.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
