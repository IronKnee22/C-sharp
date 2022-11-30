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

namespace StarField
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            
            int height = 400;
            int width = 400;
            for (int i = 0; i < 100; i++)
            {
                Ellipse ellipse = new Ellipse();
                ellipse.Height = 4;
                ellipse.Width = 4;
                ellipse.Fill = new SolidColorBrush(Colors.White);
                


                Canvas.SetLeft(ellipse, random.Next(height-(int)ellipse.Height));
                Canvas.SetTop(ellipse, random.Next(width - (int)ellipse.Height));

                canvas.Children.Add(ellipse);
            }

            



        }

        


    }
}
