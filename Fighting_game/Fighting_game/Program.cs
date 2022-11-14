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
            Fighter Jarda = new Fighter("Jarda", 100, 20,10);
            Fighter Pepa = new Fighter("Pepik", 120, 15, 15);
            Arena arena = new Arena(Jarda, Pepa);



            arena.Zapas();
            








            Console.ReadKey();
        }
    }
}
