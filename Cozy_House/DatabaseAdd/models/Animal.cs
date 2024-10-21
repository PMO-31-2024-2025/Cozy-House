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
    public class Animal
    {
        [Key]
        public int AnimalID {  get; set; }
        public string Animal_Name { get; set; } = null!;
        public string Species { get; set; } = null!;
        public string Breed { get; set; } = null!;
        public int Animal_Age { get; set; }
        public string Infection { get; set; } = null!;
        public string Vaccine { get; set; } = null!;
        public string Parasite { get; set; } = null!;

        [ForeignKey("User")]
        public int User_ID { get; set; }

        public User User { get; set; } = null!;
    }
}
