using Cozy_House.models.Cozy_House.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public static class SaveManager
    {
        public static User CurrentUser { get; set; } = null;

        public static bool IsUserLoggedIn => CurrentUser != null;
    }
}
