using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaz
{
    internal class Garaz
    {
        List<Auto> auta = new List<Auto>();


        public void Zaparkuj(Auto auto)
        {
            auta.Add(auto);
        }

        public void VypisObsahGaraze()
        {
            Console.WriteLine(String.Join("; ", auta));
        }





    }
}
