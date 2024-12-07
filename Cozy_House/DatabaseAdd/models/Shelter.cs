using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Cozy_House.models.Cozy_House.models;


namespace Cozy_House.models
{
    [Table("Shelter")]
    public class Shelter
    {
        [Key]
        public int Shelter_ID { get; set; }
        public string Shelter_Name { get; set; } = null!;
        public string Shelter_Location {  get; set; } = null!;
        public string Shelter_Number { get; set; } = null!;
        public string Shelter_Email { get; set; } = null!;

        public List<User>? Users { get; set; }
    }
}
