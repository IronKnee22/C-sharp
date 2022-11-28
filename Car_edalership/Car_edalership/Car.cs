using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_edalership
{
    internal class Car
    {
        protected string znacka;
        protected int cena;

        public Car(string znacka, int cena)
        {
            this.znacka = znacka;
            this.cena = cena;
        }

        public virtual int GetCena()
        { 
          return cena;
        }

        public override string ToString()
        {
            return $"{znacka} cena:{cena}";
        }


    }
}
