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
    /// Interaction logic for ContexMenu2.xaml
    /// </summary>
    public partial class ContextMenu2 : Window
    {
        private UIElement sourceElement;
        private string selectedText;
        public ContextMenu2()
        {
            InitializeComponent();
        }

        public void Show(Point position, UIElement source, string text = "")
        {
            this.sourceElement = source;
            this.selectedText = text;

            this.Left = position.X;
            this.Top = position.Y;

            this.Show();
        }
        private void CopyText_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedText))
            {
                Clipboard.SetText(selectedText);
            }
            this.Close();
        }

        private void Navigate_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Навігація");
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (sourceElement is TextBlock textBlock)
            {
                textBlock.Text = "";
            }
            this.Close();
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
