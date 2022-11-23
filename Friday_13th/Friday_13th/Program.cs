using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_13th
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadej první datum: ");
            DateTime prvni = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhé datum: ");
            DateTime druhy = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine(prvni.DayOfWeek);
            //Console.WriteLine(druhy);


            while (prvni.DayOfWeek != DayOfWeek.Friday)
            {
                prvni = prvni.AddDays(1);
            }
            //Console.WriteLine(prvni.DayOfWeek);

            while (prvni <= druhy)
            {
                if (prvni.Day == 13)
                {
                    Console.Write($"{prvni}, ");                  
                }
                prvni = prvni.AddDays(7);
            }





            Console.ReadKey();

        }
    }
}
