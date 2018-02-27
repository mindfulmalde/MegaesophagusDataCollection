using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class DogMedicine
    {
        public int DogId { get; set; }
        public Dog Dog { get; set; }

        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
    }
}
