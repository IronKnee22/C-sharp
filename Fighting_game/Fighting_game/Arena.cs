using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_game
{
    internal class Arena
    {
        public Fighter fighter1 { get; private set; }
        public Fighter fighter2 { get; private set; }
        bool zapas = true;

        public Arena(Fighter fighter1, Fighter fighter2)
        {
            this.fighter1 = fighter1;
            this.fighter2 = fighter2;
        }


        public void Zapas()
        {
            while (zapas)
            {   //musím si tady dát utok i obranu do nových proměných abych je byl schopný vypsat
                fighter2.Zraneni(fighter1.Zautoc() - fighter2.BranSe());
                Console.WriteLine($"{fighter1} zaútočil utokem o sile {fighter1.Zautoc()} bojovnik {fighter2} se branil silou {fighter2.BranSe()}");
                if (fighter2.Zivoty() <= 0)
                {
                    Console.WriteLine($"Vyhrál bojovník {fighter1}");
                    zapas = false;
                }else
                Console.WriteLine($"{fighter2} zbyvyjici zivoty: {fighter2.Zivoty()}");

                fighter1.Zraneni(fighter2.Zautoc() - fighter1.BranSe());
                Console.WriteLine($"{fighter1} zaútočil utokem o sile {fighter1.Zautoc()} bojovnik {fighter2} se branil silou {fighter2.BranSe()}");
                if (fighter1.Zivoty()<=0)
                {
                    Console.WriteLine($"Vyhrál bojovník {fighter2}");
                    zapas = false;
                }else
                Console.WriteLine($"{fighter1} zbyvyjici zivoty: {fighter1.Zivoty()}");




                



            }

        }

    }
}
