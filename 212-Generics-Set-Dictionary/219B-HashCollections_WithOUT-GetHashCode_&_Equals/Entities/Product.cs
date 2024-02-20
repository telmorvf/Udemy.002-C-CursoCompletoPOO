namespace _219B_HashCollections_WithOUT_GetHashCode___Equals.Entities
{
    class Product
    {
        //Tipo Referência
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Com Ovverride passa a comparar o conteúdo
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        // Com Override passa a comparar o conteúdo
        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }
            // fazer o downcasting do Obj para Product
            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
