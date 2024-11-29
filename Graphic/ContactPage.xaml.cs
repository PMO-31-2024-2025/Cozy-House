using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;

namespace Graphic
{
    public partial class ContactPage : Window
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = e.Uri.AbsoluteUri,
                UseShellExecute = true
            });
            e.Handled = true;
        }
    }
}