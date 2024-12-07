using Cozy_House.models.Cozy_House.models;
using Microsoft.Data.Sqlite;
using System;
using System.Data.SqlClient;
using System.Text;
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

        private const string V = "SELECT * FROM User WHERE User_Email = @Email AND Password = @Password";
        private string connectionString = @"Data Source=C:\Users\WellDone\source\repos\Cozy-House\proj\Cozy_House\DatabaseAdd\Database\mydb.db;";

        private User GetUserDetails(string email, string password)
        {
            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM User WHERE User_Email = @Email AND Password = @Password";
                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", HashPassword(password));

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                return new User
                                {
                                    User_Email = reader["User_Email"].ToString(),
                                    User_name = reader["User_name"].ToString(),
                                    FieldOfActivity = reader["FieldOfActivity"].ToString(),
                                    User_age = Convert.ToInt32(reader["User_age"]),
                                    Prefer = reader["Prefer"].ToString(),
                                    User_Location = reader["User_Location"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    Password_Check = reader["Password_Check"]?.ToString() 
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка підключення до бази даних: {ex.Message}",
                    "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return null;
        }

        private string HashPassword(string password)
        {
            return password;
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
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            if (IsValidEmail(email) && IsValidPassword(password))
            {
                User user = GetUserDetails(email, password);
                if (user != null)
                {
                    SaveManager.CurrentUser = user;

                    MyProfile myProfile = new MyProfile();
                    myProfile.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Невірний email або пароль", "Помилка входу", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Перевірте правильність введених даних", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrationForm regisration = new RegistrationForm();
            regisration.Show();
            this.Close();
        }
    }
}
