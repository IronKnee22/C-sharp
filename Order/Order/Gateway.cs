using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Gateway
    {
        public void ProcessOrder(IOrder order)
        {
            Console.WriteLine("Order no. {0}", order.Number);
            Console.WriteLine("=============");
            Console.WriteLine("Name:    {0} {1}", order.FirstName, order.LastName);
            Console.WriteLine("Address: {0} {1}", order.Street, order.HouseNumber);
            Console.WriteLine();
            for (int i = 0; i < order.Products.Length; i++)
            {
                Console.WriteLine("{0} {1}pcs per {2},-", order.Products[i], order.Quantities[i], order.Prices[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Total price: {0},-", order.Prices.Sum());
        }
    }
}
