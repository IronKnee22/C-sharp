using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dvek,ddny;
            int ivek;
            DateTime naroze_1;

            Console.Write("Zadej datum svého narození: "); 
            DateTime narozeni = DateTime.Parse(Console.ReadLine());
            



            TimeSpan vek = DateTime.Today - narozeni;
            dvek = Math.Floor(vek.Days / 365.25);



            ivek = Convert.ToInt32(dvek);
            //Console.WriteLine(dvek);
            naroze_1 = narozeni.AddYears(ivek);
           // Console.WriteLine(naroze_1);
            TimeSpan dny = naroze_1 - DateTime.Today;
            ddny = dny.Days + 365;
            //Console.WriteLine(ddny);

            Console.WriteLine($"Je ti {dvek} a narozeni budes mit za {ddny}");






            Console.ReadKey();
        }
    }
}
