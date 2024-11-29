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
            ZhenyaPageInfo zenyaInfoWindow = new ZhenyaPageInfo();
            zenyaInfoWindow.Owner = this;
            zenyaInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            zenyaInfoWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BasyaPageInfo basyaInfoWindow = new BasyaPageInfo();
            basyaInfoWindow.Owner = this;
            basyaInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            basyaInfoWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FufaPageInfo fufaInfoWindow = new FufaPageInfo();
            fufaInfoWindow.Owner = this;
            fufaInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            fufaInfoWindow.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            BarsikPageInfo barsikInfoWindow = new BarsikPageInfo();
            barsikInfoWindow.Owner = this;
            barsikInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            barsikInfoWindow.Show();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SonyaPageInfo sonyaInfoWindow = new SonyaPageInfo();
            sonyaInfoWindow.Owner = this;
            sonyaInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            sonyaInfoWindow.Show();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TimofiyPageInfo timofiyInfoWindow = new TimofiyPageInfo();
            timofiyInfoWindow.Owner = this;
            timofiyInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            timofiyInfoWindow.Show();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            CharlyPageInfo charlyInfoWindow = new CharlyPageInfo();
            charlyInfoWindow.Owner = this;
            charlyInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            charlyInfoWindow.Show();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            HrystyaPageInfo hrystyaInfoWindow = new HrystyaPageInfo();
            hrystyaInfoWindow.Owner = this;
            hrystyaInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            hrystyaInfoWindow.Show();

        }

        private void Button_Click_Next2(object sender, RoutedEventArgs e)
        {
            AnimalAdoptionPage2 adoptionWindowPage2 = new AnimalAdoptionPage2();
            Window currentWindow = Window.GetWindow(this);
            adoptionWindowPage2.Show();
            currentWindow.Close();
        }

    }
}
