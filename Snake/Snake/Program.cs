namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Had had = new Had(); 
            while (had.Zivy) 
            {                
                Console.Clear(); 
                
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  _________________________________________________");
                    for (int i = 0; i < 15; i++)
                    {
                        Console.WriteLine(" |                                                 |");
                    }

                    Console.WriteLine("  -------------------------------------------------");
                } //vykreslení hracíhopole

                had.VykresliHad();
                had.VykresliJidlo();
                had.Lez(); 
                had.Zvetsit();
                Thread.Sleep(500); 
 
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo klavesa = Console.ReadKey(); 
                                                             
                    if (klavesa.Key == ConsoleKey.RightArrow)
                        had.Smer = 0;
                    if (klavesa.Key == ConsoleKey.LeftArrow)
                        had.Smer = 180;
                    if (klavesa.Key == ConsoleKey.DownArrow)
                        had.Smer = 270;
                    if (klavesa.Key == ConsoleKey.UpArrow)
                        had.Smer = 90;
                }                
            }
            if(!had.Zivy) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(22, 8);
                Console.WriteLine("Game Over");
                Console.Read();
            }
        }
    }
}