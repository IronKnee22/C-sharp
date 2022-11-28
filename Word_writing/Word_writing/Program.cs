using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_writing
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string slovo = "";
            List<string> list = new List<string>();

            while (slovo != "konec") 
            {
                Console.Write("Zadej Slovo: ");
                slovo = Console.ReadLine();
                if(slovo != "konec")
                    list.Add(slovo);

            }

            Console.Write("Zadal jsi tato slova:");
            foreach(string s in list)
                Console.Write(s+", ");
            Console.ReadKey();
        }
    }
}
