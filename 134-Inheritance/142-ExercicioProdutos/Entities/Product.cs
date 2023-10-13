using System.Globalization;

namespace _142_ExercicioProdutos.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //public override string ToString()
        //{
        //    return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        //}

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
