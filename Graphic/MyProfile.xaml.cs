using Cozy_House.DatabaseAdd;
using Cozy_House.models;
using Graphic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

            LoadUserProfileImage();
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

        private void LoadUserProfileImage()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var currentUser = context.user.FirstOrDefault(u => u.User_Email == SaveManager.CurrentUser.User_Email);
                    if (currentUser?.ProfileImage != null)
                    {
                        BitmapImage bitmap = new BitmapImage();
                        using (var ms = new MemoryStream(currentUser.ProfileImage))
                        {
                            bitmap.BeginInit();
                            bitmap.StreamSource = ms;
                            bitmap.CacheOption = BitmapCacheOption.OnLoad;
                            bitmap.EndInit();
                            bitmap.Freeze();
                        }

                        ProfilePictureEllipse.Stretch = Stretch.Uniform;
                        ProfilePictureEllipse.Fill = new ImageBrush(bitmap);
                    }
                    else
                    {
                        ProfilePictureEllipse.Stretch = Stretch.Uniform;
                        ProfilePictureEllipse.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/zhenya.png")));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження зображення: {ex.Message}",
                    "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ValidateImageFile(string filePath)
        {
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            string extension = System.IO.Path.GetExtension(filePath).ToLower();
            if (!allowedExtensions.Contains(extension))
            {
                MessageBox.Show("Невірний формат файлу!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Length > 5 * 1024 * 1024)
            {
                MessageBox.Show("Розмір файлу занадто великий (до 5 МБ)", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

        private void ChangeProfilePicture_Click(object sender, MouseButtonEventArgs e)
        {
            if (SaveManager.CurrentUser == null)
            {
                MessageBox.Show("Поточний користувач не встановлений", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Виберіть зображення для профілю"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                if (!ValidateImageFile(openFileDialog.FileName))
                {
                    return;
                }

                try
                {
                    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);

                    using (var context = new DatabaseContext())
                    {
                        var currentUser = context.user.FirstOrDefault(u => u.User_Email == SaveManager.CurrentUser.User_Email);

                        if (currentUser != null)
                        {
                            currentUser.ProfileImage = imageBytes;
                            context.SaveChanges();

                            BitmapImage bitmap = new BitmapImage();
                            using (var ms = new MemoryStream(imageBytes))
                            {
                                bitmap.BeginInit();
                                bitmap.StreamSource = ms;
                                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                                bitmap.EndInit();
                                bitmap.Freeze();
                            }

                            ProfilePictureEllipse.Fill = new ImageBrush(bitmap);

                            MessageBox.Show("Фото профілю успішно змінено!", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                                $"Користувача не знайдено за електронною поштою: {SaveManager.CurrentUser.User_Email}",
                                "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при зміні фото: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}


