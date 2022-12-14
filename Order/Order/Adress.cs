using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Adress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int House_num { get; set; }


        public Adress(string City, string Street, int House_num)
        {
            this.City = City;
            this.Street = Street;
            this.House_num = House_num;
        }

        public override string ToString()
        {
            return string.Format($"Město: {City}, Ulice: {Street}, Číslo domu: {House_num}");
        }
    }
}
