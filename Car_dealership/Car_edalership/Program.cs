using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_edalership
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> Auta = new List<Car>();
            Auta.Add(new Car("Škoda 120", 10000));
            Auta.Add(new Car("Škoda Fabia", 120000));
            Auta.Add(new Car("Ferrari FF", 3000000));
            Auta.Add(new Car("Škoda", 10000));
            Auta.Add(new Truck("Tatra 811", 50000, 20));
            Auta.Add(new Truck("Renault", 100000, 30));


            Dealership dealership = new Dealership();

            dealership.Nakup(Auta[0]);
            dealership.Nakup(Auta[1]);
            dealership.Nakup(Auta[2]);
            dealership.Nakup(Auta[3]);
            dealership.Nakup(Auta[4]);
            dealership.Nakup(Auta[5]);

            dealership.Prodej(Auta[2]);

            Car car = new Car("a", 1);
            car.cena = 20;



            Console.WriteLine(dealership);

            Console.ReadKey();



        }
    }
}
