using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Fighter> fighters = new List<Fighter>();

            Fighter Jarda = new Fighter("Jarda", 100, 20,10);
            Fighter Pepa = new Fighter("Pepik", 110, 15, 15);
            //Arena arena = new Arena(Jarda, Pepa);

            fighters.Add(Jarda);
            fighters.Add(Pepa);
            fighters.Add(new Fighter("Ferda", 100, 20, 10));
            fighters.Add(new Fighter("Venda", 100, 20, 10));
            fighters.Add(new Fighter("Lužon", 100, 20, 10));
            fighters.Add(new Fighter("Tomáš", 100, 20, 10));
            fighters.Add(new Fighter("David", 100, 20, 10));
            fighters.Add(new Fighter("Bohuslav", 100, 20, 10));

            //arena.Zapas();
            








            Console.ReadKey();
        }
    }
}
