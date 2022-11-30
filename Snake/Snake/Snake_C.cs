using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake_C
    {

        List<Body> body = new List<Body>();
        public ConsoleColor barva = ConsoleColor.Green;
        public int Smer { get; set; }

        public void Had()
        {
            body.Add(new Body(15, 14, barva));
            body.Add(new Body(14, 14, barva));
            body.Add(new Body(14, 13, barva));
            
        }

        public void Had_Vykresli()
        {
            
            foreach(Body bod in body)
            {
                bod.Telo_Vykresli();
            }
        }

        public void Had_Posun()
        {
            Body novaHlava = new Body(body[0].X, body[0].Y, barva);

            if(Smer == 0)
            {
                novaHlava.X++;
            }
            if (Smer == 180)
            {
                novaHlava.X--;
            }
            if (Smer == 270)
            {
                novaHlava.Y++;
            }
            if (Smer == 90)
            {
                novaHlava.Y--;
            }

            body.Insert(0, novaHlava);
            body.Remove(body[body.Count-1]);
        }
    }
}
