using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        //TODO: Posouvání hada
        //TODO: Vykreslední Jídla
        static void Main(string[] args)
        {
            Snake_C snake_C = new Snake_C();
            snake_C.Had_Vykresli();


            Console.ReadKey();
        }
    }
}
