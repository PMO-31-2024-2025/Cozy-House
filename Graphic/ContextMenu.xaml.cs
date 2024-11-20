using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Graphic
{
    public partial class ContextMenu : Window
    {
        private UIElement sourceElement;
        private string selectedText;

        public ContextMenu()
        {
            InitializeComponent();

        }

        public void Show(Point position, UIElement source, string text = "")
        {
            this.sourceElement = source;
            this.selectedText = text;

            // Позиціонуємо меню в точці кліку
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
            // Додайте логіку навігації
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

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // Додайте логіку редагування
            MessageBox.Show("Редагування");
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}