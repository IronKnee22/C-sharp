using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class COder: IOrder
    {
        public int Number { get; }
        public string FirstName { get { return customer.Name;} }
        public string LastName { get { return customer.Surname;} }
        public string Street { get {return adress.Street; } }
        public int HouseNumber { get { return adress.House_num; }
        }
        public string City { get { return adress.City; } }

        public string[] Products { get { return new string[] { product.Name }; } }
        public int[] Quantities { get { return new int[] { 1 }; } }
        public int[] Prices { get { return new int[] {product.Price }; } }

        Customer customer;
        Adress adress;
        Product product;

        public COder(int number, Customer customer, Adress adress, Product product)
        {
            Number = number;
            this.customer = customer;
            this.adress = adress;
            this.product = product;
        }
    }
}
