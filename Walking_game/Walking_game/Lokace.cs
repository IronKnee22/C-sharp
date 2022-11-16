using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking_game
{
    internal class Lokace
    {
        
        public string nazev { get; private set; }
        public string popis { get; private set; }

        public Lokace sever;
        public Lokace jih;
        public Lokace zapad;
        public Lokace vychod;

       
        public Lokace(string nazev, string popis)
        {
            this.nazev = nazev;
            this.popis = popis;
        }

        public override string ToString()
        {
            string smer ="";
            smer += "Můžeš jít:";
            if (sever != null)
                smer += " sever,";
            if (vychod != null)
                smer += " vychod,";
            if (jih != null)
                smer += " jih,";
            if (zapad != null)
                smer += " zapad,";

            return smer;
        }



    }
}
