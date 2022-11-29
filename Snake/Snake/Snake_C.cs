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

        public void Had()
        {
            body.Add(new Body(15, 14, barva));
            body.Add(new Body(14, 14, barva));
            body.Add(new Body(14, 13, barva));
            
        }

        public void Had_Vykresli()
        {
            Had();
            foreach(Body bod in body)
            {
                bod.Telo_Vykresli();
            }
        }
    }
}
