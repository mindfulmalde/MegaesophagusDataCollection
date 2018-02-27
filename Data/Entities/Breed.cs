using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Breed")]
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Dog> Dogs { get; set; }
    }
}
