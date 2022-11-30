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
        
        //TODO: Vykreslední Jídla
        //TODO: Zvetšení hada po tom co se nají
        static void Main(string[] args)
        {
            Snake_C snake_C = new Snake_C();
            snake_C.Had();


            //snake_C.Had_Vykresli();


            do
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
            } while (snake_C.Nazivu);


            Console.Clear();
            Console.CursorLeft = 57;
            Console.CursorTop = 15;
            Console.WriteLine("Game over");


            Console.ReadKey();
        }
    }
}
