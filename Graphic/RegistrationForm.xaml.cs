using Cozy_House.DatabaseAdd;
using Cozy_House.models;
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
    /// Interaction logic for RegistrationForm.xaml
    /// </summary>
    public partial class RegistrationForm : Window
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = FirstNameTextBox.Text;
            string email = EmailTextBox.Text;
            int age = int.Parse(AgeTextBox.Text); 
            string address = AddressTextBox.Text;
            string activity = FieldOfActivityTextBox.Text;
            string prefer = PreferTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmpassword = ConfirmPasswordTextBox.Text;

            DatabaseContext context = new DatabaseContext();
            context.users.Add(new User()
            {
                User_name = name,
                User_age = age,
                User_Email = email,
                User_Location = address,
                Password = password,
                Password_Check = confirmpassword,
                FieldOfActivity = activity,
                Prefer = prefer,
            });
            context.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Validation validation = new Validation();
            validation.Show();
            this.Close();
        }
    }
}
