using System.Windows;
using System.Windows.Controls;

namespace Graphic
{
    public partial class ContextMenu3 : Window
    {
        private FrameworkElement _sourceElement;

        public ContextMenu3(FrameworkElement sourceElement)
        {
            InitializeComponent();
            _sourceElement = sourceElement;
        }

        private void CopyText_Click(object sender, RoutedEventArgs e)
        {
            if (_sourceElement is TextBlock textBlock)
            {
                Clipboard.SetText(textBlock.Text);
            }
            Close();
        }

        private void Navigate_Click(object sender, RoutedEventArgs e)
        {
            if (_sourceElement is TextBlock textBlock)
            {
                NavigateBasedOnText(textBlock.Text);
            }
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow firstWindow = new FirstWindow();
            firstWindow.Show();
            Application.Current.Windows[0].Close();
            Close();
        }

        private void NavigateBasedOnText(string text)
        {
            Window currentWindow = Application.Current.Windows[0];

            switch (text)
            {
                case "Про притулок":
                    NavigateToPage(new AboutShelter(), currentWindow);
                    break;
                case "Улюбленці":
                    NavigateToPage(new AnimalAdoption(), currentWindow);
                    break;
                case "Допомога притулку":
                    NavigateToPage(new DonationWindow(), currentWindow);
                    break;
                case "Контакти":
                    NavigateToPage(new ContactPage(), currentWindow);
                    break;
            }
        }

        private void NavigateToPage(Window newWindow, Window currentWindow)
        {
            newWindow.Show();
            currentWindow.Close();
        }
    }
}