using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaz
{
    internal class Auto
    {
        string nazev { get; set; }
        string spz { get; set; }
        string barva { get; set; }

        public Auto(string nazev, string spz, string barva)
        {
            this.nazev = nazev;
            this.spz = spz;
            this.barva = barva;
        }

        public override string ToString()
        {
            return $"{nazev} SPZ: {spz} {barva}";
        }
    }
}
