using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("DogFoodBrand")]
    public class DogFoodBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<DogFood> DogFood { get; set; }
    }
}