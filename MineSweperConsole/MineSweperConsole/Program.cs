﻿namespace MineSweperConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hra hra = new Hra();
            int SouradniceX;
            int SouradniceY;


            do
            {
                Console.SetCursorPosition(0, 7);
                {
                    Console.Write("Zadej číselné X: ");
                    SouradniceX = int.Parse(Console.ReadLine());

                    Console.Write("Zadej číselné Y: ");
                    SouradniceY = int.Parse(Console.ReadLine());
                }//načítaní souřadnic pro použití
                hra.ObsahujeBombu(SouradniceX, SouradniceY);
            } while (hra.hra);
            Console.WriteLine("Gamer Over");



            Console.ReadKey();
            
        }
    }
}