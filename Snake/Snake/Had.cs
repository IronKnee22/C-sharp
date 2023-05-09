using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Had
    {
        public bool Zivy { get; set; } = true;
        public int Smer { get; set; }

        Pozice pozice;
        Pozice HlavaHada;
        Pozice Pomocna;
        Pozice Jidlo;

        bool OdstraneniOcasu = true;
        bool JidloSebrano = false;

        /// <summary>
        /// Zde je uchováné celé hadovo tělo
        /// </summary>
        List<Pozice> TeloHada = new List<Pozice>();
        List<Pozice> PomocneTelo;
 
        /// <summary>
        /// Tato proměná slouží jako základní stavební prvek
        /// </summary>
        string Kostka = "██";

        public Had()
        {
            //Pocatecni poloha hada (Potom upravit aby to nějak vypadalo)
            TeloHada.Add(pozice = new Pozice(24, 10));
            TeloHada.Add(pozice = new Pozice(22, 10));
            TeloHada.Add(pozice = new Pozice(20, 10));

            //Zde se mi generuje první jídlo
            NoveJidlo();
        }


        /// <summary>
        /// Zde se vykresluje celé tělo hada
        /// </summary>
        public void VykresliHad()
        {
            foreach (var item in TeloHada)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(item.X, item.Y);
                Console.WriteLine(Kostka);
            }
        }

        public void VykresliJidlo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(Jidlo.X, Jidlo.Y);
            Console.WriteLine(Kostka);
        }

        public void Zvetsit()
        {
            if (Jidlo.X == TeloHada.First().X && Jidlo.Y == TeloHada.First().Y)
            {
                OdstraneniOcasu = false;
            }
        }

        public void NoveJidlo()
        {
            int X = Random.Shared.Next(5, 45);
            if (X % 2 == 1)
            {
                X++;
            }
            int Y = Random.Shared.Next(2, 13);

            Jidlo = new Pozice(X, Y);
        }

        public void Lez()
        {
            HlavaHada = TeloHada.First();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(18, 17);
            int skore = TeloHada.Count * 10;
            Console.WriteLine("Tvoje skóre je: " + skore);
            

            PomocneTelo = new List<Pozice>(TeloHada);
            PomocneTelo.RemoveAt(0);

            foreach (var item in PomocneTelo)
            {
                if(HlavaHada.X == item.X && HlavaHada.Y == item.Y)
                {
                    Zivy = false;
                }
            }

            if (HlavaHada.X == 50 || HlavaHada.Y == 15)
            {
                Zivy = false;
            }
            else
            {

                switch (Smer)
                {
                    case 0:
                        /*do Pomocna musím vytvořit novou pozici abych poze neměl dvě
                         * proměné které ukazují na tu sampu pozici a tu novou pozici
                         * vytvořím tak že pouze do parametrů dám tu starou pozici*/
                        Pomocna = new Pozice(HlavaHada.X, HlavaHada.Y);
                        Pomocna.X = Pomocna.X + 2; //souradnice nové hlavy
                        TeloHada.Insert(0, Pomocna); //vložení nové hlavy do listu
                        if (OdstraneniOcasu)
                        {
                            TeloHada.Remove(TeloHada.Last());//odstranění ocasu
                        }
                        else
                        {
                            NoveJidlo();
                            OdstraneniOcasu = true;
                        }


                        break;

                    case 180:
                        Pomocna = new Pozice(HlavaHada.X, HlavaHada.Y);
                        Pomocna.X = Pomocna.X - 2; //souradnice nové hlavy
                        TeloHada.Insert(0, Pomocna); //vložení nové hlavy do listu
                        if (OdstraneniOcasu)
                        {
                            TeloHada.Remove(TeloHada.Last());//odstranění ocasu
                        }
                        else
                        {
                            NoveJidlo();
                            OdstraneniOcasu = true;
                        }
                        break;

                    case 90:
                        Pomocna = new Pozice(HlavaHada.X, HlavaHada.Y);
                        Pomocna.Y = Pomocna.Y - 1; //souradnice nové hlavy
                        TeloHada.Insert(0, Pomocna); //vložení nové hlavy do listu
                        if (OdstraneniOcasu)
                        {
                            TeloHada.Remove(TeloHada.Last());//odstranění ocasu
                        }
                        else
                        {
                            NoveJidlo();
                            OdstraneniOcasu = true;
                        }
                        break;

                    case 270:
                        Pomocna = new Pozice(HlavaHada.X, HlavaHada.Y);
                        Pomocna.Y = Pomocna.Y + 1; //souradnice nové hlavy
                        TeloHada.Insert(0, Pomocna); //vložení nové hlavy do listu
                        if (OdstraneniOcasu)
                        {
                            TeloHada.Remove(TeloHada.Last());//odstranění ocasu
                        }
                        else
                        {
                            NoveJidlo();
                            OdstraneniOcasu = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
