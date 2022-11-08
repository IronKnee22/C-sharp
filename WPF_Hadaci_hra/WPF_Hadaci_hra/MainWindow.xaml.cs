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

namespace WPF_Hadaci_hra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> cisla = new List<int>();
        int rozsah;
        Random random = new Random();
        int myslene_cislo=0;
        int zadane_cislo;
        int count = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            rozsah = int.Parse(Vyber_rozsahu.Text);
            myslene_cislo = random.Next(1, rozsah + 1);

        }

        private void Typ_Click(object sender, RoutedEventArgs e)
        {

            if (myslene_cislo == 0)
            {
                MessageBox.Show("Ještě jsi mi nedal příkaz k tomu abych si myslel číslo");                
                return;
            }

            zadane_cislo = int.Parse(Zadavacitxtbx.Text);
            cisla.Add(zadane_cislo);

            

            if(zadane_cislo == myslene_cislo)
            {
                MessageBox.Show( "Vyhrál jsi\n"+
                                $"Uhodl jsi na {count} pokus\n"+
                                 "Tvé tipy: " + String.Join(" ", cisla));
                                
                return;
            }

            else if(zadane_cislo>myslene_cislo)
            {
                Informace.Text = "Myslím si menší číslo";
                count++;
            }
            else
            {
                Informace.Text = "Myslím si větší číslo";
                count++;
            }

            Zadavacitxtbx.Text = " ";
        }
    }
}
