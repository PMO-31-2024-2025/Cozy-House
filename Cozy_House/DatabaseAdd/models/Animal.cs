using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozy_House.models
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }
        public string Animal_Name { get; set; } = null!;
        public string Species { get; set; } = null!;
        public string Breed { get; set; } = null!;
        public int Animal_Age { get; set; }
        public string Infection { get; set; } = null!;
        public string Vaccine { get; set; } = null!;
        public string Parasite { get; set; } = null!;
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
    }
}