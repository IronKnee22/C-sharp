using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Clovek Abe = new Clovek("Abraham Simpson");
            Clovek Pen = new Clovek("Penelope Olsen");
            Clovek Pan = new Clovek("Pan Bouvier");
            Clovek Jackie = new Clovek("Jackie Bouvier");
            Clovek Herb = new Clovek("herb Powers", Abe, Pen);
            Clovek Homer = new Clovek("Homer Simpson", Abe, Pen);
            Clovek Marge = new Clovek("Marge Simpson", Pan, Jackie);
            Clovek Bart = new Clovek("Bart Simpson", Homer, Marge);

            Rodokmen rodokmen = new Rodokmen();
            rodokmen.VypisRodokmen(Bart);

            Console.ReadKey();

        }
    }
}
