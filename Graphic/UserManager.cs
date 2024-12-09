using Cozy_House.DatabaseAdd;
using Cozy_House.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public class UserManager
    {
        private readonly DatabaseContext _context;

        public UserManager(DatabaseContext context)
        {
            _context = context;
        }

        public void RegisterUser(string email, string password, string password_check, string name, int age, string location, string fieldOfActivity, string preference)
        {
            var user = new User
            {
                User_Email = email,
                Password = password,
                Password_Check = password_check,
                User_name = name,
                User_age = age,
                User_Location = location,
                FieldOfActivity = fieldOfActivity,
                Prefer = preference
            };

            _context.user.Add(user);
            _context.SaveChanges();
        }

    }
}
