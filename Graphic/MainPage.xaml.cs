using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Graphic
{

    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TakeAFriend_Click(object sender, MouseButtonEventArgs e)
        {
            AnimalAdoption animalAdoption = new AnimalAdoption();
            Window currentWindow = Window.GetWindow(this);
            animalAdoption.Show();
            currentWindow.Close();
        }
    }
}