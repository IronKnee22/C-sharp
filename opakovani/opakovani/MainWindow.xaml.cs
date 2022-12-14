using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace opakovani
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int myslene_cislo;
        Random random = new Random();
        int typ;
        List<int> list = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            
            myslene_cislo = random.Next(int.Parse(Vyber_rozsahu.Text));
        }

        private void Typ_Click(object sender, RoutedEventArgs e)
        {
            typ = int.Parse(Zadavacitxtbx.Text);
            if(typ > myslene_cislo)
            {
                Informace.Text = "Myslené číslo je menší";
                list.Add(typ);
            }
            else if (typ < myslene_cislo)
            {
                Informace.Text = "Myslené číslo je větší";
                list.Add(typ);
            }
            else
            {
                MessageBox.Show("Vyhrál jsi",
                                $"{string.Join(" ", list.Distinct())}");
            }
        }
    }
}
