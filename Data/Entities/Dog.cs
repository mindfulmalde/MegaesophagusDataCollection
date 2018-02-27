using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Dog")]
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Weight { get; set; }

        public int BreedId { get; set; }
        public Breed Breed { get; set; }

        public ICollection<Meal> Meals { get; set; }
        public ICollection<DogMedicine> DogMedicines { get; set; }
        public ICollection<VomitEpisode> GetVomitEpisodes { get; set; }
    }
}
