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

        public void ObsahujeBombu(int x, int y)
        {
            foreach (var item in hraciPoleList)
            {
                Console.SetCursorPosition(item.X, item.Y);
                if (item.X == x && item.Y == y && item.Bomba == true)
                {
                    Console.WriteLine("X");
                }
                else if(item.X == x && item.Y == y && item.Bomba == false)
                {
                    Console.WriteLine("O");
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
