using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulacka
{
    internal class calculations
    {
        public double? prvni_cislo { get; set; }
        public double? druhe_cislo { get; set; }
        public double? vysledek { get; set; }
        public Operace operace { get; set; }


        public void Reset()
        {
            prvni_cislo = 0;
            druhe_cislo = 0;
            vysledek = 0;
            operace = Operace.nic;
        }

        public void vypocitej()
        {
            if(operace == Operace.scitani)
            {
                vysledek = prvni_cislo + druhe_cislo;
            }
            if (operace == Operace.odcitani)
            {
                vysledek = prvni_cislo - druhe_cislo;
            }
            if (operace == Operace.nasobeni)
            {
                vysledek = prvni_cislo * druhe_cislo;
            }
            if (operace == Operace.deleni)
            {
                vysledek = prvni_cislo / druhe_cislo;
            }
        }


    }
}
