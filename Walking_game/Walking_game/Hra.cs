using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking_game
{
    internal class Hra
    {

        public Lokace AktualniLokace;
        public string prikaz;

        public Hra()
        {
            Lokace hrad = new Lokace("Hrad", "Stojíš před okovanou branou gotického hradu, která je zřejmě jediným vchodem do pevnosti. Klíčová dírka je pokryta pavučinami, což vzbuzuje dojem, že je budova opuštěná.");
            Lokace les1 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
            Lokace les2 = new Lokace("Lesní rozcestí", "Nacházíš se na lesním rozcestí.");
            Lokace les3 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
            Lokace rybnik = new Lokace("Rybník", "Došel jsi ke břehu malého rybníka. Hladina je v bezvětří jako zrcadlo. Kousek od tebe je dřevěná plošina se stavidlem.");
            Lokace les4 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
            Lokace dum = new Lokace("Dům", "Stojíš před svým rodným domem, cítíš vůni čerstvě nasekaného dřeva, která se line z hromady vedle vstupních dveří.");
   
            hrad.vychod = les1;
            les1.zapad = hrad;
            les1.vychod = les2;
            les2.zapad = les1;
            les2.vychod = les3;
            les2.jih = les4;
            les3.zapad = les2;
            les3.vychod = rybnik;
            rybnik.zapad = les3;
            les4.sever = les2;
            les4.vychod = dum;
            dum.zapad = les4;

            AktualniLokace = dum;
        }

        public void ZacniHru()
        {
            while (prikaz != "konec")
            {
                Console.WriteLine($"{AktualniLokace.popis}");
                Console.WriteLine(AktualniLokace);
                Console.WriteLine("Na jaky smer se cheš vydat?");
                prikaz = Console.ReadLine();
                prikaz.ToLower();
                PrechodDoLokace(prikaz);
            }
        }

        public void PrechodDoLokace(string prikaz)
        {
            if(prikaz == "sever" && AktualniLokace.sever != null)
                AktualniLokace = AktualniLokace.sever;
            if (prikaz == "jih" && AktualniLokace.jih != null)
                AktualniLokace = AktualniLokace.jih;
            if (prikaz == "vychod" && AktualniLokace.vychod != null)
                AktualniLokace = AktualniLokace.vychod;
            if (prikaz == "zapad" && AktualniLokace.zapad != null)
                AktualniLokace = AktualniLokace.zapad;
        }

    }
}
