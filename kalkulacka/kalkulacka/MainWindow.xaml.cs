using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace kalkulacka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        calculations calculations = new calculations();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cislo_Click(object sender, RoutedEventArgs e)
        {
            string stisknuto = ((Button)sender).Content.ToString();
            if (textBlock.Text.Contains(",") && stisknuto == ",")
                return;
            if (textBlock.Text == "0" && stisknuto != ",")
                textBlock.Text = "";
            textBlock.Text += stisknuto;
        }

        private void Resetovat_Click(object sender, RoutedEventArgs e)
        {
            calculations.Reset();
            textBlock.Text = "0";
        }

        private void Vymazat_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "0";
        }
        private void Soucet_Click(object sender, RoutedEventArgs e)
        {
            Get_operace(Operace.scitani);
        }

        private void Rozdil_Click(object sender, RoutedEventArgs e)
        {
            Get_operace(Operace.odcitani);
        }

        private void Soucin_Click(object sender, RoutedEventArgs e)
        {
            Get_operace(Operace.nasobeni);
        }

        private void Podil_Click(object sender, RoutedEventArgs e)
        {
            Get_operace(Operace.deleni);
        }

        private void RovnaSe_Click(object sender, RoutedEventArgs e)
        {
            calculations.druhe_cislo = int.Parse(textBlock.Text, CultureInfo.GetCultureInfo("cs"));
            calculations.vypocitej();
            textBlock.Text = calculations.vysledek.ToString();

        }

        private void Get_operace(Operace operace)
        {
            calculations.prvni_cislo = int.Parse(textBlock.Text, CultureInfo.GetCultureInfo("cs"));
            calculations.operace = operace;
            textBlock.Text = "0";
        }

    }
}
