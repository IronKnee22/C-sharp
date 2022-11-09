using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto ford = new Auto("Ford", "123ABC", "Červená");
            Auto kia = new Auto("Kia", "ABC123", "Modrá");
            Garaz garaz = new Garaz();

            garaz.Zaparkuj(kia);
            garaz.VypisObsahGaraze();

            garaz.Zaparkuj(ford);

            garaz.VypisObsahGaraze();


            Console.ReadKey();
        }
    }
}
