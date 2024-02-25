using Enum1.Entities.Enums;
using System;
using System.Runtime.Intrinsics.X86;

namespace Enum1.Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            // string - enum: ---------------------------------------
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
            Console.WriteLine();

            // para o tipo original: use casting ---------------------
            OrderStatus os1 = (OrderStatus)2;
            int n1 = (int)OrderStatus.Shipped;

            Console.WriteLine(os1);
            Console.WriteLine(n1);
        }
    }
}
