using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cozy_House.models
{
    [Table ("User")]
    public class User
    {
        [Key]
        public int User_id { get; set; }
        public string User_name { get; set; } = null!;
        public int User_age { get; set; }
        public string User_Location { get; set; } = null!;
        public string Prefer { get; set; } = null!;
        public string FieldOfActivity { get; set; } = null!;
        public string User_Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Password_Check { get; set; } = null!;

        public User? Users { get; set; } 
        public List<Animal> Animals { get; set; } = null!;
    }
}
