using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mdc.Data.Entities
{
    [Table("Meal")]
    public class Meal
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }

        // Dog
        public int DogId { get; set; }
        public Dog Dog { get; set; }

        // Food
        public int FoodId { get; set; }
        public DogFood Food { get; set; }
        public double GramsOfFood { get; set; }
        public bool WasBlended { get; set; }
        public double? GramsOfWater { get; set; }

        // Bailey Chair
        public bool WasBaileyChairUsed { get; set; }
        public DateTime? TimePutInBaileyChair { get; set; }
        public DateTime? TimeLeftBaileyChair { get; set; }

        // Medicine
        public bool WasMedicineGiven { get; set; }
        public ICollection<MealMedicine> MealMedicines { get; set; }
        public DateTime? TimeMedicineGiven { get; set; }
    }
}