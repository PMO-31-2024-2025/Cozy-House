using Graphic.Pets;
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
using System.Windows.Shapes;

namespace Graphic
{
    /// <summary>
    /// Interaction logic for AnimalAdoptionPage2.xaml
    /// </summary>
    public partial class AnimalAdoptionPage2 : Window
    {
        public AnimalAdoptionPage2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BobPageInfo bobInfoWindow = new BobPageInfo(4);
            bobInfoWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BabyPageInfo babyInfoWindow = new BabyPageInfo(1);
            babyInfoWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NanyPageInfo nanyInfoWindow = new NanyPageInfo(15);
            nanyInfoWindow.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ChappiPageInfo chappiInfoWindow = new ChappiPageInfo(5);
            chappiInfoWindow.Show();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MarkPageInfo markInfoWindow = new MarkPageInfo(9);
            markInfoWindow.Show();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MasyaPageInfo masyaInfoWindow = new MasyaPageInfo(10);
            masyaInfoWindow.Show();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MikePageInfo mikeInfoWindow = new MikePageInfo(11);
            mikeInfoWindow.Show();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MishelPageInfo mishelInfoWindow = new MishelPageInfo(12);
            mishelInfoWindow.Show();

        }


        private void Button_Click_Back1(object sender, RoutedEventArgs e)
        {
            AnimalAdoption adoptionWindow = new AnimalAdoption();
            Window currentWindow = Window.GetWindow(this);
            adoptionWindow.Show();
            currentWindow.Close();
        }
    }
}
