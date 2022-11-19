using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_tree
{
    internal class Clovek
    {

        string jmeno;
        public Clovek otec { get; private set; }
        public Clovek matka { get; private set; }


        public Clovek(string jmeno, Clovek otec = null, Clovek matka = null)
        {
            this.jmeno = jmeno;
            this.otec = otec;
            this.matka = matka;
        }

        public override string ToString()
        {
            return $"{jmeno}";
        }
    }
}
