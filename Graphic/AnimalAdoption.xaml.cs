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
            ZhenyaPageInfo zenyaInfoWindow = new ZhenyaPageInfo(16);
            zenyaInfoWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BasyaPageInfo basyaInfoWindow = new BasyaPageInfo(3);
            basyaInfoWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FufaPageInfo fufaInfoWindow = new FufaPageInfo(7);
            fufaInfoWindow.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            BarsikPageInfo barsikInfoWindow = new BarsikPageInfo(2);
            barsikInfoWindow.Show();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SonyaPageInfo sonyaInfoWindow = new SonyaPageInfo(14);
            sonyaInfoWindow.Show();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TimofiyPageInfo timofiyInfoWindow = new TimofiyPageInfo(13);
            timofiyInfoWindow.Show();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            CharlyPageInfo charlyInfoWindow = new CharlyPageInfo(6);
            charlyInfoWindow.Show();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            HrystyaPageInfo hrystyaInfoWindow = new HrystyaPageInfo(8);
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
