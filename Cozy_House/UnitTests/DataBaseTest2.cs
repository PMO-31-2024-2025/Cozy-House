using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cozy_House.models;

namespace Cozy_House.UnitTests
{
    [TestClass]
    public class DataBaseTest2
    {
        [TestMethod]
        public void Test_CreateAnimal_ShouldSetPropertiesCorrectly()
        {
            string expectedAnimalName = "Краля";
            string expectedSpecies = "Собака";
            string expectedBreed = "Метис";
            int expectedAnimalAge = 2;
            string expectedInfection = "Відсутні";
            string expectedVaccine = "Відсутні";
            string expectedParasite = "Відсутні";
            string expectedDescription = "Мила 2-річна собачка";
            string expectedImagePath = "path/to/image.png";

            var animal = new Animal
            {
                Animal_Name = expectedAnimalName,
                Species = expectedSpecies,
                Breed = expectedBreed,
                Animal_Age = expectedAnimalAge,
                Infection = expectedInfection,
                Vaccine = expectedVaccine,
                Parasite = expectedParasite,
                Description = expectedDescription,
                ImagePath = expectedImagePath
            };

            Assert.AreEqual(expectedAnimalName, animal.Animal_Name);
            Assert.AreEqual(expectedSpecies, animal.Species);
            Assert.AreEqual(expectedBreed, animal.Breed);
            Assert.AreEqual(expectedAnimalAge, animal.Animal_Age);
            Assert.AreEqual(expectedInfection, animal.Infection);
            Assert.AreEqual(expectedVaccine, animal.Vaccine);
            Assert.AreEqual(expectedParasite, animal.Parasite);
            Assert.AreEqual(expectedDescription, animal.Description);
            Assert.AreEqual(expectedImagePath, animal.ImagePath);
        }
    }
}
