using System;
using System.Collections.Generic;
using System.Text;

namespace Mdc.Data.Entities
{
    public class MealMedicine
    {
        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
    }
}
