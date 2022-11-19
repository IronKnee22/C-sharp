using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_tree
{
    internal class Rodokmen
    {
        string jmeno;

        private void VypisPredka(Clovek clovek)
        {
            if(clovek != null)
            {
                Console.WriteLine(clovek);
                VypisPredka(clovek.otec);
                VypisPredka(clovek.matka);
            }
           
        }

        public string VypisRodokmen(Clovek clovek)
        {

            VypisPredka(clovek);

            return jmeno;
        }


    }
}
