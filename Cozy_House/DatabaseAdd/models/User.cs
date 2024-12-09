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
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_id { get; set; }

        public required string User_name { get; set; }

        public byte[] ProfileImage { get; set; } = Array.Empty<byte>();
        [EmailAddress]
        public required string User_Email { get; set; }

        public required int User_age { get; set; }

        public required string User_Location { get; set; }
        public required string FieldOfActivity { get; set; }
        public required string Prefer { get; set; }
        public required string Password { get; set; }
        public required string Password_Check { get; set; }
    }
}
