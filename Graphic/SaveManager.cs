using Cozy_House.DatabaseAdd;
using Cozy_House.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public static class SaveManager
    {
        private static DatabaseContext _context = new DatabaseContext();

        public static User CurrentUser { get; set; }

        public static bool IsUserLoggedIn => CurrentUser != null;

        public static void LoadCurrentUser(int userId)
        {
            CurrentUser = _context.user.Find(userId);
        }

        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }


    }
}
