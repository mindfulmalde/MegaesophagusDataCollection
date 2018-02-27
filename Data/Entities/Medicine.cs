using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Medicine")]
    public class Medicine
    {
        public int Id { get; set; }
        public string GenericName { get; set; }
        public string BrandName { get; set; }
        public int PillsPerDosage { get; set; }

        public ICollection<DogMedicine> DogMedicines { get; set; }
        public ICollection<MealMedicine> MealMedicines { get; set; }
    }
}