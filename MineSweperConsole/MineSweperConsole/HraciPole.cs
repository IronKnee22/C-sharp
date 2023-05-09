using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweperConsole
{
    internal class HraciPole
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool Bomba { get; set; }
        public string Vykresleni { get; } = "#";

        public HraciPole(int X, int Y, bool Bomba) 
        {
            this.X = X;
            this.Y = Y;
            this.Bomba = Bomba;
        }

        
    }
}
