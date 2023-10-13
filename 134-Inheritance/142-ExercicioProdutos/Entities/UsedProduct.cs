using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142_ExercicioProdutos.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        //public override string ToString()
        //{
        //    //return base.ToString();
        //    return $"{base.Name} (used) $ {base.Price} (Manufacture date:  {ManufactureDate.ToShortDateString()})";
        //}

        public override string PriceTag()
        {
            return $"{base.Name} (used) $ {base.Price} (Manufacture date:  {ManufactureDate.ToShortDateString()})";
        }
    }
}
