using System.Globalization;

namespace _200_Exercicio_WorkingWithCsvFiles.Entities
{
    internal class OutputCSV
    {
        public string Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public OutputCSV()
        {
        }
        public OutputCSV(string product, double price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
            TotalPrice = 0.00;
        }

        public double MyOutFile(double price, int quantity)
        {
            TotalPrice = price * quantity;
            return TotalPrice;
        }

        public override string ToString()
        {
            return $"{Product};{(MyOutFile(Price, Quantity)).ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
