using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        //TODO: Hlidani vyjetí z obrazovky
        //TODO: Vykreslední Jídla
        static void Main(string[] args)
        {
            Snake_C snake_C = new Snake_C();
            snake_C.Had();

            //snake_C.Had_Vykresli();


            while (true)
            {
                snake_C.Had_Posun();
                snake_C.Had_Vykresli();
                Thread.Sleep(50);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo klavesa = Console.ReadKey(); 

                    if (klavesa.Key == ConsoleKey.RightArrow)
                        snake_C.Smer = 0;
                    if (klavesa.Key == ConsoleKey.LeftArrow)
                        snake_C.Smer = 180;
                    if (klavesa.Key == ConsoleKey.DownArrow)
                        snake_C.Smer = 270;
                    if (klavesa.Key == ConsoleKey.UpArrow)
                        snake_C.Smer = 90;
                }
                Console.Clear();
            }





            Console.ReadKey();
        }
    }
}
