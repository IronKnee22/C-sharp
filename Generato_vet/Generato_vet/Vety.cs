using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generato_vet
{
    internal class Vety
    {
       

        string[] podmety = { "jednorožec", "programátor", "manažer", "hroch", "T - rex" };
        string[] prisudky = { "spal", "ležel", "vařil", "uklízel", "derivoval" };
        string[] privlastky = { "modrý", "velký", "hubený", "nejlepší", "automatizovaný" };
        string[] prislovce = { "rychle", "s oblibou", "hodně", "málo", "se zpožděním" };
        string[] pum = { "pod stolem", "v lese", "u babičky", "v práci", "na stole" };

        Random random = new Random();

        public string GenerujVetu()
        {
            
            return $"{podmety[random.Next(0, 5)]} {prisudky[random.Next(0, 5)]} {privlastky[random.Next(0, 5)]} {prislovce[random.Next(0, 5)]} {pum[random.Next(0, 5)]}";
        }


    }
}
