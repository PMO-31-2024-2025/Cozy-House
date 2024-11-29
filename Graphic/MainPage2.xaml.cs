using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Graphic
{
    public partial class MainPage2 : Page
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private void AboutShelter_Click(object sender, MouseButtonEventArgs e)
        {
            AboutShelter aboutWindow = new AboutShelter();
            Window currentWindow = Window.GetWindow(this);
            aboutWindow.Show();
            currentWindow.Close();
        }

        private void AnimalAdoption_Click(object sender, MouseButtonEventArgs e)
        {
            AnimalAdoption adoptionWindow = new AnimalAdoption();
            Window currentWindow = Window.GetWindow(this);
            adoptionWindow.Show();
            currentWindow.Close();
        }

        private void DonationWindow_Click(object sender, MouseButtonEventArgs e)
        {
            DonationWindow helpWindow = new DonationWindow();
            Window currentWindow = Window.GetWindow(this);
            helpWindow.Show();
            currentWindow.Close();
        }

        private void Contacts_Click(object sender, MouseButtonEventArgs e)
        {
            ContactPage contactsWindow = new ContactPage();
            Window currentWindow = Window.GetWindow(this);
            contactsWindow.Show();
            currentWindow.Close();
        }
    }
}