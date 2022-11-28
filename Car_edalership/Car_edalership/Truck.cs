using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_edalership
{
    internal class Truck:Car
    {
        
        int nostnost;



        public Truck(string znacka,int cena, int nostnost):base(znacka, cena)
        {
            this.nostnost = nostnost;
            this.cena = cena;
            this.znacka = znacka;
        }

        public override int GetCena()
        {
            return base.GetCena();
        }

        public override string ToString()
        {
            return $"{znacka} cena:{cena} nosnost: {nostnost}";
        }
    }
}
