using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Body
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor barva { get; set; }

        public Body(int x, int y, ConsoleColor barva)
        {
            X = x;
            Y = y;
            this.barva = barva;
        }

        public void Telo_Vykresli()
        {
            Console.CursorLeft = X * 2;
            Console.CursorTop = Y;
            Console.ForegroundColor = barva;
            Console.Write("██");
        }
    }
}
