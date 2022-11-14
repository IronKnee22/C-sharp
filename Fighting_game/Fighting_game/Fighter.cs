using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_game
{
    internal class Fighter
    {
        public string jmeno { get; private set; }
        public int zivoty {get; private set; }
        public int utok { get; private set; }
        public int obrana { get; private set; }

        Random random = new Random();

        public Fighter(string jmeno, int zivoty, int utok, int obrana)
        {
            this.jmeno = jmeno;
            this.zivoty = zivoty;
            this.utok = utok;
            this.obrana = obrana;
        }

        public int Zautoc()
        {
            return random.Next(utok);
        }

        public int BranSe()
        {
            return random.Next(obrana);
        }

        public void Zraneni(int zraneni)
        {
            zivoty -= zraneni;
        }

        public int Zivoty()
        {
            return zivoty;
        }


        public override string ToString()
        {
            return $"{jmeno} "; 
        }
    }
}
