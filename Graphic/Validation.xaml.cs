using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Graphic
{
    public partial class Validation : Window
    {
        public Validation()
        {
            InitializeComponent();
        }

        private void EmailTextBox_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Невірний формат E-mail. Введіть коректну адресу.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                EmailTextBox.Clear();
                EmailTextBox.Focus(); 
            }
        }

        private void PasswordBox_Click(object sender, RoutedEventArgs e)
        {
            string password = PasswordBox.Password;
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Пароль повинен містити принаймні 8 символів, одну велику літеру та одну цифру.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                PasswordBox.Clear(); 
                PasswordBox.Focus(); 
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 &&
                   Regex.IsMatch(password, @"[A-Z]") &&
                   Regex.IsMatch(password, @"\d");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PasswordBox_Click(sender, e);
            EmailTextBox_Click(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrationForm regisration = new RegistrationForm();
            regisration.Show();
            this.Close();
        }
    }
}
