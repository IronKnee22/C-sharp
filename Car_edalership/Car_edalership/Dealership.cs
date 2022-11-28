using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_edalership
{
    internal class Dealership
    {
        
        int pokladna = 5000000;
        List<Car> voz_park = new List<Car>();
        public void Nakup(Car car)
        {
            pokladna -= car.GetCena();
            voz_park.Add(car);
        }

        public void Prodej(Car car)
        {
            pokladna += car.GetCena();
            voz_park.Remove(car);
        }

        public override string ToString()
        {
            return $"Vozový park auto bazaru činí: \n{String.Join("\n",voz_park.Distinct())} \nNa pokladně mají v htovosti: {pokladna}";
        }

    }
}
