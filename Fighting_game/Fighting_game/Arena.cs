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
        int utok;
        int obrana;

        public Arena(Fighter fighter1, Fighter fighter2)
        {
            this.fighter1 = fighter1;
            this.fighter2 = fighter2;
        }


        public void Zapas()
        {
            while (zapas)
            {   //musím si tady dát utok i obranu do nových proměných abych je byl schopný vypsat
                utok = fighter1.Zautoc();
                obrana = fighter2.BranSe();

                fighter2.Zraneni(utok - obrana);
                Console.WriteLine($"{fighter1} zaútočil utokem o sile {utok} bojovnik {fighter2} se branil silou {obrana}");
                if (fighter2.Zivoty() <= 0)
                {
                    Console.WriteLine($"Vyhrál bojovník {fighter1}");
                    zapas = false;
                }
                else
                {

                    Console.WriteLine($"{fighter2} zbyvyjici zivoty: {fighter2.Zivoty()}");

                    utok = fighter2.Zautoc();
                    obrana = fighter1.BranSe();

                    fighter1.Zraneni(utok - obrana);

                    Console.WriteLine($"{fighter2} zaútočil utokem o sile {utok} bojovnik {fighter1} se branil silou {obrana}");
                    if (fighter1.Zivoty() <= 0)
                    {
                        Console.WriteLine($"Vyhrál bojovník {fighter2}");
                        zapas = false;
                    }
                    else
                        Console.WriteLine($"{fighter1} zbyvyjici zivoty: {fighter1.Zivoty()}");
                }




                



            }

        }

    }
}
