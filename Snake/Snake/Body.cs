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
        public bool Nazivu=true;

        public Body(int x, int y, ConsoleColor barva)
        {
            X = x;
            Y = y;
            this.barva = barva;
        }

        public void Telo_Vykresli()
        {



            try
            {
                Console.CursorLeft = X * 2;
            }
            catch
            {
                Nazivu = false;
            }

            if(Console.CursorTop == 29 || Console.CursorTop == 1)
            {
                Nazivu = false;
            }
            else
            {
                Console.CursorTop = Y;
            }
                Console.CursorTop = Y;
                Console.ForegroundColor = barva;
                Console.Write("██");
            
            
        }
    }
}
