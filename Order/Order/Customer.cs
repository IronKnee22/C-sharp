using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer(int Id, string Name, string Surname)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
        }

        public override string ToString()
        {
            return string.Format($"{Name} {Surname}");
        }


    }
}
