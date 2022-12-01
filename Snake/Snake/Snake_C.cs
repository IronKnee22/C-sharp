using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake_C
    {
        Random random = new Random(); 
        List<Body> body = new List<Body>();
        public ConsoleColor barva = ConsoleColor.Green;
        public ConsoleColor barva_jidlo = ConsoleColor.Red;
        public int Smer { get; set; }
        public bool Nazivu;
        public bool jidlo_sebrano = true;
        public int jidlo_X;
        public int jidlo_Y;
        public int hlavaX;
        public int hlavaY;

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
                Nazivu = bod.Nazivu;
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
            


            hlavaX = novaHlava.X;
            hlavaY = novaHlava.Y;
            body.Insert(0, novaHlava);

            body.Remove(body[body.Count-1]);
            jidlo();

            



            if (novaHlava.X == jidlo_X && novaHlava.Y == jidlo_Y)
            {
                Body novyOcas = new Body(body[0].X, body[0].Y, barva);
                novyOcas.X = jidlo_X;
                novyOcas.Y = jidlo_Y;
                jidlo_sebrano = true;
                body.Insert(body.Count, novyOcas);
            }



        }
        public void jidlo()
        {
            if (jidlo_sebrano)
            {
                jidlo_X =random.Next(10, 50);
                jidlo_Y = random.Next(10, 20);
                //jidlo_X = 10;
                //jidlo_Y = 10;
                jidlo_sebrano = false;
            }
            Console.CursorLeft = 2 * jidlo_X;
            Console.CursorTop = jidlo_Y;
            Console.ForegroundColor = barva_jidlo;
            Console.WriteLine("██");

        }
    }
}
