using System;
using System.Windows;
using Microsoft.Data.Sqlite;
using System.IO;
using Cozy_House.models;

namespace Graphic.Pets
{
    public partial class BabyPageInfo : Window
    {
        public Animal CurrentAnimal { get; set; }

        public BabyPageInfo(int animalId)
        {
            InitializeComponent();
            LoadAnimalData(animalId);
            CloseButton.Click += CloseButton_Click;

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void LoadAnimalData(int animalId)
        {
            string connectionString = @"Data Source=C:\Users\WellDone\source\repos\Cozy-House\proj\Cozy_House\DatabaseAdd\Database\mydb.db;";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM animals WHERE AnimalID = @AnimalId";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AnimalId", animalId);

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CurrentAnimal = new Animal
                            {
                                AnimalID = reader.GetInt32(reader.GetOrdinal("AnimalID")),
                                Animal_Name = reader.GetString(reader.GetOrdinal("Animal_Name")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                Species = reader.GetString(reader.GetOrdinal("Species")),
                                Breed = reader.GetString(reader.GetOrdinal("Breed")),
                                Animal_Age = reader.GetInt32(reader.GetOrdinal("Animal_Age")),
                                Vaccine = reader.GetString(reader.GetOrdinal("Vaccine")),
                                Infection = reader.GetString(reader.GetOrdinal("Infection")),
                                Parasite = reader.GetString(reader.GetOrdinal("Parasite")),
                                ImagePath = reader["ImagePath"].ToString()
                            };

                            DataContext = CurrentAnimal;
                        }
                    }
                }
            }
        }
    }
}