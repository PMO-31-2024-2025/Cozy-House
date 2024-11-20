using System;
using System.Windows;
using System.Windows.Controls;

namespace Graphic
{
    public partial class AnimalPageInfo : Window
    {
        public AnimalPageInfo()
        {
            InitializeComponent();

            CloseButton.Click += CloseButton_Click;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}