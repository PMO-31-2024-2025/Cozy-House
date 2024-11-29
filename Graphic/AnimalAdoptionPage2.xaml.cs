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
            BobPageInfo bobInfoWindow = new BobPageInfo();
            bobInfoWindow.Owner = this;
            bobInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            bobInfoWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BabyPageInfo babyInfoWindow = new BabyPageInfo();
            babyInfoWindow.Owner = this;
            babyInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            babyInfoWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NanyPageInfo nanyPageInfo = new NanyPageInfo();
            nanyPageInfo.Owner = this;
            nanyPageInfo.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            nanyPageInfo.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ChappiPageInfo chappiInfoWindow = new ChappiPageInfo();
            chappiInfoWindow.Owner = this;
            chappiInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            chappiInfoWindow.Show();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MarkPageInfo markInfoWindow = new MarkPageInfo();
            markInfoWindow.Owner = this;
            markInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            markInfoWindow.Show();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MasyaPageInfo masyaInfoWindow = new MasyaPageInfo();
            masyaInfoWindow.Owner = this;
            masyaInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            masyaInfoWindow.Show();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MikePageInfo mikeInfoWindow = new MikePageInfo();
            mikeInfoWindow.Owner = this;
            mikeInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            mikeInfoWindow.Show();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MishelPageInfo mishelInfoWindow = new MishelPageInfo();
            mishelInfoWindow.Owner = this;
            mishelInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
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
