using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cozy_House.DatabaseAdd;
using Cozy_House.models;

namespace Cozy_House.UnitTests
{
    [TestClass]
    public class DataBaseTest1
    {
        [TestMethod]
        public void Test_CreateUser_ShouldSetPropertiesCorrectly()
        {
            int expectedUserId = 1;
            string expectedUserName = "John Doe";
            string expectedEmail = "john.doe@example.com";
            int expectedAge = 30;
            string expectedLocation = "London";
            string expectedFieldOfActivity = "Education";
            string expectedPreference = "Hybrid Work";
            string expectedPassword = "Password123";
            string expectedPasswordCheck = "Password123";

            var user = new User
            {
                User_id = expectedUserId,
                User_name = expectedUserName,
                User_Email = expectedEmail,
                User_age = expectedAge,
                User_Location = expectedLocation,
                FieldOfActivity = expectedFieldOfActivity,
                Prefer = expectedPreference,
                Password = expectedPassword,
                Password_Check = expectedPasswordCheck
            };

            // Assert
            Assert.AreEqual(expectedUserId, user.User_id);
            Assert.AreEqual(expectedUserName, user.User_name);
            Assert.AreEqual(expectedEmail, user.User_Email);
            Assert.AreEqual(expectedAge, user.User_age);
            Assert.AreEqual(expectedLocation, user.User_Location);
            Assert.AreEqual(expectedFieldOfActivity, user.FieldOfActivity);
            Assert.AreEqual(expectedPreference, user.Prefer);
            Assert.AreEqual(expectedPassword, user.Password);
            Assert.AreEqual(expectedPasswordCheck, user.Password_Check);
        }
    }
}