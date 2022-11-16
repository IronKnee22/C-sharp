using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_game
{
    internal class Turnament
    {

        public List<Fighter> fighters { get; private set; }


        public Turnament(List<Fighter> fighters)
        {
            this.fighters = fighters;
        }


        public List<Arena> CreateTrees(List<Fighter> fighters)
        {
            List<Arena> Fight = new List<Arena>();

            for(int i = 0; i < fighters.Count; i += 2)
            {
                Fight.Add(new Arena(fighters[i], fighters[i+1]));
            }
            return Fight;

        }




    }
}
