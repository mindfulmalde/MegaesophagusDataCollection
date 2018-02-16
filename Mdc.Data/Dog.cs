using System;
using System.Collections.Generic;

namespace Mdc.Data
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Weight { get; set; }
        public Breed Breed { get; set; }
        public ICollection<Meal> Meals { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
    }
}
