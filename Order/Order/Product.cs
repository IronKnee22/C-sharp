using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }


        public Product(int Id, string Name, int Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }


        public override string ToString()
        {
            return string.Format($"Název: {Name}");
        }



    }
}
