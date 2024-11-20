using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Graphic
{
    /// <summary>
    /// Interaction logic for AnimalAdoption.xaml
    /// </summary>
    public partial class AnimalAdoption : Window
    {
        public AnimalAdoption()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnimalPageInfo animalInfoWindow = new AnimalPageInfo();
            animalInfoWindow.Owner = this; 
            animalInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            animalInfoWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
