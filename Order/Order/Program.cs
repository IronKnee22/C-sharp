using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Marek", "Darsa");
            Adress adress = new Adress("Kladno", "Hrdinů", 234);
            Product product = new Product(1, "Myčka", 999);
            COder cOder = new COder(1, customer, adress,product);

            Gateway gateway = new Gateway();
            gateway.ProcessOrder(cOder);


            Console.ReadKey();
        }
    }
}
