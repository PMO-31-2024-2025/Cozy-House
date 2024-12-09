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

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
                FirstWindow firstWindow = new FirstWindow();
                Window currentWindow = Window.GetWindow(this);
                firstWindow.Show();
                currentWindow.Close();
        }

        private void TextBlock_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            CloseAllContextMenus();

            if (sender is TextBlock textBlock)
            {
                ContextMenu3 contextMenu = new ContextMenu3(textBlock);

                Point point = e.GetPosition(this);
                contextMenu.Left = point.X + this.PointToScreen(new Point(0, 0)).X;
                contextMenu.Top = point.Y + this.PointToScreen(new Point(0, 0)).Y;

                contextMenu.Show();
            }
        }

        private void CloseAllContextMenus()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is ContextMenu3)
                {
                    window.Close();
                }
            }
        }

        private void Validation_Click(object sender, MouseButtonEventArgs e)
        {
            if (SaveManager.IsUserLoggedIn)
            {
                MyProfile myProfile = new MyProfile();
                Window currentWindow = Window.GetWindow(this);
                myProfile.Show();
                currentWindow.Close();
            }
            else
            {
                Validation validation = new Validation();
                Window currentWindow = Window.GetWindow(this);
                validation.Show();
                currentWindow.Close();
            }
        }
    }
}