using Cozy_House.DatabaseAdd;
using Cozy_House.models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Graphic
{
    public partial class RegistrationForm : Window
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                using (var context = new DatabaseContext())
                {
                    context.EnsureDatabaseCreated();

                    var existingUser = context.user.FirstOrDefault(u => u.User_Email == EmailTextBox.Text);
                    if (existingUser != null)
                    {
                        MessageBox.Show("Користувач з такою електронною поштою вже існує.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    string fieldOfActivity = (FieldOfActivityTextBox.SelectedItem as ComboBoxItem)?.Content.ToString();
                    string prefer = (PreferTextBox.SelectedItem as ComboBoxItem)?.Content.ToString();

                    var newUser = new User
                    {
                        User_name = FirstNameTextBox.Text,
                        User_Email = EmailTextBox.Text,
                        User_age = int.Parse(AgeTextBox.Text),
                        User_Location = AddressTextBox.Text,
                        FieldOfActivity = fieldOfActivity,
                        Prefer = prefer,                   
                        Password = HashPassword(PasswordTextBox.Text),
                        Password_Check = HashPassword(ConfirmPasswordTextBox.Text)
                    };

                    context.user.Add(newUser);

                    int savedChanges = context.SaveChanges();
                    Debug.WriteLine($"Кількість змін: {savedChanges}");

                    if (savedChanges > 0)
                    {
                        MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);

                        new Validation().Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося зберегти дані.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Помилка реєстрації: {ex}");
                MessageBox.Show($"Помилка реєстрації: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                MessageBox.Show("Введіть ім'я.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (!IsValidEmail(EmailTextBox.Text))
            {
                MessageBox.Show("Введіть коректну електронну пошту.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (!int.TryParse(AgeTextBox.Text, out int age) || age < 18 ||  age > 120)
            {
                MessageBox.Show("Введіть коректний вік (18-120).", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text) || PasswordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Пароль повинен містити принаймні 8 символів, одну велику літеру та одну цифру.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Паролі не збігаються.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private string HashPassword(string password)
        {
            return password;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Validation().Show();
            Close();
        }
    }
}