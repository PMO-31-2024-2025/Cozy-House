using Cozy_House.models.Cozy_House.models;
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
    /// Interaction logic for MyProfile.xaml
    /// </summary>
    public partial class MyProfile : Window
    {
        public MyProfile()
        {
            InitializeComponent();

            if (!SaveManager.IsUserLoggedIn)
            {
                MessageBox.Show("Ви не увійшли в систему!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                Validation validation = new Validation();
                validation.Show();
                this.Close();
                return;
            }

            UserNameTextBlock.Text = $"Ім'я: {SaveManager.CurrentUser.User_name}";
            UserLocationTextBlock.Text = $"Місце проживання: {SaveManager.CurrentUser.User_Location}";
            UserAgeTextBlock.Text = $"Вік: {SaveManager.CurrentUser.User_age.ToString()}";
            UserPreferTextBlock.Text = $"Надає перевагу: {SaveManager.CurrentUser.Prefer}";
            UserFieldOfActivityTextBlock.Text = $"Сфера діяльності: {SaveManager.CurrentUser.FieldOfActivity}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyPrefer myPrefer = new MyPrefer();
            Window currentWindow = Window.GetWindow(this);
            myPrefer.Show();
            currentWindow.Close();
        }


        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            SaveManager.CurrentUser = null;

            Validation validation = new Validation();
            validation.Show();
            this.Close();
        }
    }
}
    
