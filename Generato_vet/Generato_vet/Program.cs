using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generato_vet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vety vety = new Vety();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(vety.GenerujVetu());
            }
            Console.ReadKey();
        }
    }
}
