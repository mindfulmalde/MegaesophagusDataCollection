using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mdc.Data.Entities
{
    [Table("DogFood")]
    public class DogFood
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int BrandId { get; set; }
        public DogFoodBrand Brand { get; set; }

        public ICollection<Meal> Meals { get; set; }
    }
}
