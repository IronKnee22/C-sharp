using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_edalership
{
    internal class Car
    {
        public string znacka { get; set; }
        public int cena { get; set; }

        public Car(string znacka, int cena)
        {
            this.znacka = znacka;
            this.cena = cena;
        }


        public override string ToString()
        {
            return $"{znacka} cena:{cena}";
        }


    }
}
