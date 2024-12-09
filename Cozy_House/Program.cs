//using Cozy_House.DatabaseAdd;
//using Cozy_House.models;
//using Microsoft.EntityFrameworkCore.Storage;
//using System.Runtime.Intrinsics.X86;
//using Microsoft.Data.Sqlite;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;

//namespace Cozy_House
//{
//    public class Program
//    {
        //public static void Main(string[] args)
        //{
        //FillTestData();
        //}

        //        public static void FillTestData()
        //        {
        //            string connectionString = @"Data Source=C:\Users\WellDone\source\repos\Cozy-House\Cozy_House\DatabaseAdd\Database\mydb.db;";

        //            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        //            optionsBuilder.UseSqlite(connectionString);

        //            using (var context = new ApplicationDbContext(optionsBuilder.Options))
        //            {
        //                if (context.Animals.Any())
        //                {
        //                    Console.WriteLine("База даних вже містить дані. Нічого додавати не потрібно.");
        //                    return;
        //                }

        //                var animals = new List<Animal>
        //                {
        //                    new Animal { Animal_Name = "Краля", Species = "Собака", Breed = "Англійський кокер-спанієль", Animal_Age = 2, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Барсік", Species = "Собака", Breed = "Ретривер", Animal_Age = 11, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Бася", Species = "Кицька", Breed = "Шотланська", Animal_Age = 9, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Бобі", Species = "Собака", Breed = "Бігль", Animal_Age = 11, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Чаппі", Species = "Собака", Breed = "Брюссельський грифон", Animal_Age = 5, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Чарлі", Species = "Собака", Breed = "Грифон", Animal_Age = 4, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Фуфа", Species = "Кицька", Breed = "Сіамська кицька", Animal_Age = 7, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Христя", Species = "Собака", Breed = "Джек Рассел тер'єр", Animal_Age = 3, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Марк", Species = "Собака", Breed = "Ши-тцу", Animal_Age = 8, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Мася", Species = "Кіт", Breed = "Британська короткошерста", Animal_Age = 2, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Майк", Species = "Кіт", Breed = "Домашній кіт", Animal_Age = 3, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Мішель", Species = "Кішка", Breed = "Мейн-кун", Animal_Age = 11, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Тимофій", Species = "Кіт", Breed = "Британська короткошерста", Animal_Age = 1, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Соня", Species = "Собака", Breed = "Бішон-фрізе", Animal_Age = 2, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Нані", Species = "Собака", Breed = "Американський кокер-спанієль", Animal_Age = 12, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" },
        //                    new Animal { Animal_Name = "Женя", Species = "Собака", Breed = "Лабрадор", Animal_Age = 4, Infection = "відсутні", Vaccine = "відсутні", Parasite = "відсутні" }
        //                };

        //            context.Animals.AddRange(animals);
        //            context.SaveChanges();

        //            Console.WriteLine("Тестові дані успішно додані до бази даних.");
        //        }
//    }
//}

//public class ApplicationDbContext : DbContext
//{
//    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

//    public DbSet<Animal> Animals { get; set; } = null!;
//}
//}



//using (var connection = new SqliteConnection(connectionString))
//{
//    connection.Open();

//    var random = new Random();

//    for (int i = 0; i < 30; i++)
//    {
//        string queryShelter = $"INSERT INTO Shelter (Shelter_Name, Shelter_Location, Shelter_Number, Shelter_Email) " +
//            $"VALUES ('Shelter_{i}', 'Location_{i}', '123-456-78{i}', 'shelter_{i}@example.com');";

//        using (var command = new SqliteCommand(queryShelter, connection))
//        {
//            command.ExecuteNonQuery();
//        }
//    }

//    for (int i = 0; i < 50; i++)
//    {
//        string queryUser = $"INSERT INTO [User] (User_name, User_age, User_Location, Prefer, FieldOfActivity, User_Email, Password, Password_Check) " +
//            $"VALUES ('User_{i}', {random.Next(18, 60)}, 'City_{i}', 'Prefer_{i}', 'Activity_{i}', 'user_{i}@example.com', 'password_{i}', 'password_{i}');";

//        using (var command = new SqliteCommand(queryUser, connection))
//        {
//            command.ExecuteNonQuery();
//        }
//    }

//    for (int i = 0; i < 50; i++)
//    {
//        string queryAnimal = $"INSERT INTO animals (Animal_Name, Species, Breed, Animal_Age, Infection, Vaccine, Parasite, User_ID) " +
//            $"VALUES ('Animal_{i}', 'Species_{i}', 'Breed_{i}', {random.Next(1, 15)}, 'None', 'Vaccine_{i}', 'Parasite_{i}', {random.Next(1, 50)});";

//        using (var command = new SqliteCommand(queryAnimal, connection))
//        {
//            command.ExecuteNonQuery();
//        }
//    }

//    connection.Close();


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




//}
