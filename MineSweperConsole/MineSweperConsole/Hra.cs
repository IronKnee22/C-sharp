using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweperConsole
{
    internal class Hra
    {
        
        public List<HraciPole> hraciPoleList;
        public bool hra { get; set; } = true;
        public Hra()
        {
            hraciPoleList = new List<HraciPole>();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    hraciPoleList.Add(new HraciPole(i+1, j+1, GenerujBombu()));
                }
            }
            VykresleniHracihoPole();
        }

        public void BombOkoloPole(HraciPole hracipole)
        {
            int X = hracipole.X;
            int Y = hracipole.Y;

            foreach (var item in hraciPoleList)
            {
                //x**
                //***
                //***
                if (item.X -1 == X && item.Y + 1 == Y && item.Bomba == true)
                {
                    hracipole.BombOkolo += 1;
                }

                //*x*
                //***
                //***
                if (item.X == X && item.Y + 1 == Y && item.Bomba == true)
                {
                    hracipole.BombOkolo += 1;
                }

                //**x
                //***
                //***
                if (item.X + 1 == X && item.Y + 1 == Y && item.Bomba == true)
                {
                    hracipole.BombOkolo += 1;
                }

                //***
                //x**
                //***
                if (item.X-1 == X && item.Y == Y && item.Bomba == true)
                {
                    hracipole.BombOkolo += 1;
                }

                //***
                //**x
                //***
                if (item.X + 1 == X && item.Y  == Y && item.Bomba == true)
                {
                    hracipole.BombOkolo += 1;
                }

                //***
                //***
                //x**
                if (item.X - 1== X && item.Y - 1 == Y && item.Bomba == true)
                {
                    hracipole.BombOkolo += 1;
                }

                //***
                //***
                //*x*
                if (item.X == X && item.Y-1 == Y && item.Bomba == true)
                {
                    hracipole.BombOkolo += 1;
                }

                //***
                //***
                //**x
                if (item.X + 1 == X && item.Y - 1 == Y && item.Bomba == true)
                {
                    hracipole.BombOkolo += 1;
                }
            }

        }

        public void ObsahujeBombu(int x, int y)
        {
            int i = 0;
            foreach (var item in hraciPoleList)
            {
                
                //if (item.Bomba)
                //{
                //    Console.SetCursorPosition(20, 20+i);
                //    Console.WriteLine($"{item.X}, {item.Y}");
                //    i++;
                //}
                
                Console.SetCursorPosition(item.X, item.Y);
                if (item.X == x && item.Y == y && item.Bomba == true)
                {
                    Console.WriteLine("X");
                    hra = false;
                }
                else if(item.X == x && item.Y == y && item.Bomba == false)
                {
                    BombOkoloPole(item);//spočítá nám to kolik bomb je okolo

                    Console.WriteLine(item.BombOkolo);
                }
            }
        }
        //změní hodnotu políčka podle toho jestli obsahuje bombu

        public bool GenerujBombu()
        {
            if (Random.Shared.Next(100) < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//vrací nám bool jestli obsahuje bombu

        public void VykresleniHracihoPole()
        {
            Console.WriteLine(" 12345");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1);
            }
            foreach (var item in hraciPoleList)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.WriteLine(item.Vykresleni);
            }
        }
    }
}
