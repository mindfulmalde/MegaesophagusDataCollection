using Mdc.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Entities
{
    [Table("VomitEpisode")]
    public class VomitEpisode
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeOfDay TimeOfDay { get; set; }

        public int DogId { get; set; }
        public Dog Dog { get; set; }
    }
}
