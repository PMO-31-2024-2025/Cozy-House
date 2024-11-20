using Cozy_House.DatabaseAdd;
using Cozy_House.models;
using Microsoft.EntityFrameworkCore.Storage;
using System.Runtime.Intrinsics.X86;
using Microsoft.Data.Sqlite;


class Program
{
    public static void Main(string[] args)
    {
        FillTestData();
    }


    public static void FillTestData()
    {

        string connectionString = @"Data Source=C:\Users\WellDone\source\repos\Cozy-House\Cozy_House\DatabaseAdd\Database\mydb.db;";
        
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var random = new Random();

            for (int i = 0; i < 30; i++)
            {
                string queryShelter = $"INSERT INTO Shelter (Shelter_Name, Shelter_Location, Shelter_Number, Shelter_Email) " +
                    $"VALUES ('Shelter_{i}', 'Location_{i}', '123-456-78{i}', 'shelter_{i}@example.com');";

                using (var command = new SqliteCommand(queryShelter, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            for (int i = 0; i < 50; i++)
            {
                string queryUser = $"INSERT INTO [User] (User_name, User_age, User_Location, Prefer, FieldOfActivity, User_Email, Password, Password_Check) " +
                    $"VALUES ('User_{i}', {random.Next(18, 60)}, 'City_{i}', 'Prefer_{i}', 'Activity_{i}', 'user_{i}@example.com', 'password_{i}', 'password_{i}');";

                using (var command = new SqliteCommand(queryUser, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            for (int i = 0; i < 50; i++)
            {
                string queryAnimal = $"INSERT INTO animals (Animal_Name, Species, Breed, Animal_Age, Infection, Vaccine, Parasite, User_ID) " +
                    $"VALUES ('Animal_{i}', 'Species_{i}', 'Breed_{i}', {random.Next(1, 15)}, 'None', 'Vaccine_{i}', 'Parasite_{i}', {random.Next(1, 50)});";

                using (var command = new SqliteCommand(queryAnimal, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();


        }


    }



    //    Shelter shelter4 = new Shelter()
    //    {
    //        Shelter_ID = 1,
    //        Shelter_Name = "Cozy Shelter",
    //        Shelter_Location = "123 Main Street",
    //        Shelter_Number = "123-456-7890",
    //        Shelter_Email = "cozy@shelter.com"
    //    };

    //    User user3 = new User()
    //    {
    //        User_id = 1,
    //        User_name = "John Doe",
    //        User_age = 30,
    //        User_Location = "New York",
    //        Prefer = "Cats",
    //        FieldOfActivity = "Software Development",
    //        User_Email = "johndoe@example.com",
    //        Password = "securepassword",
    //        Password_Check = "securepassword"
    //    };

    //    Animal animal2 = new Animal()
    //    {
    //        AnimalID = 1,
    //        Animal_Name = "Fluffy",
    //        Species = "Dog",
    //        Breed = "Golden Retriever",
    //        Animal_Age = 3,
    //        Infection = "None",
    //        Vaccine = "Rabies",
    //        Parasite = "Fleas",
    //        User_ID = user3.User_id
    //    };

    //    DatabaseContext context = new DatabaseContext();
    //    context.shelters.Add(shelter4);
    //    context.users.Add(user3);
    //    context.animals.Add(animal2);
    //    context.SaveChanges();
    //}


    //Console.WriteLine("Shelter Information:");
    //Console.WriteLine($"Name: {shelter3.Shelter_Name}");
    //Console.WriteLine($"Location: {shelter3.Shelter_Location}");
    //Console.WriteLine($"Number: {shelter3.Shelter_Number}");
    //Console.WriteLine($"Email: {shelter3.Shelter_Email}");

    //Console.WriteLine();  

    //Console.WriteLine("User Information:");
    //Console.WriteLine($"ID: {user2.User_id}");
    //Console.WriteLine($"Name: {user2.User_name}");
    //Console.WriteLine($"Age: {user2.User_age}");
    //Console.WriteLine($"Location: {user2.User_Location}");
    //Console.WriteLine($"Preference: {user2.Prefer}");
    //Console.WriteLine($"Field of Activity: {user2.FieldOfActivity}");
    //Console.WriteLine($"Email: {user2.User_Email}");

    //Console.WriteLine();  

    //Console.WriteLine("Animal Information:");
    //Console.WriteLine($"ID: {animal1.AnimalID}");
    //Console.WriteLine($"Name: {animal1.Animal_Name}");
    //Console.WriteLine($"Species: {animal1.Species}");
    //Console.WriteLine($"Breed: {animal1.Breed}");
    //Console.WriteLine($"Age: {animal1.Animal_Age}");
    //Console.WriteLine($"Infection: {animal1.Infection}");
    //Console.WriteLine($"Vaccine: {animal1.Vaccine}");
    //Console.WriteLine($"Parasite: {animal1.Parasite}");
    //Console.WriteLine($"User ID: {animal1.User_ID}");  




}
