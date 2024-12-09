using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cozy_House.DatabaseAdd;
using Cozy_House.models;


namespace Cozy_House.UnitTests
{
    [TestClass]
    public class DataBaseTest3
    {
        [TestMethod]
        public void Test_PasswordsShouldMatch()
        {
            var user = new User
            {
                User_name = "John Doe",
                User_Email = "john.doe@example.com",
                User_age = 30,
                User_Location = "London",
                FieldOfActivity = "Education",
                Prefer = "Hybrid Work",
                Password = "Password123",
                Password_Check = "Password123"
            };

            bool passwordsMatch = user.Password == user.Password_Check;

            Assert.IsTrue(passwordsMatch, "Паролі не співпадають!");
        }
    }
}
