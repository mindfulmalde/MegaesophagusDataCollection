using System;
using System.Collections;
using System.Collections.Generic;

namespace Mdc.Data
{
    public class Meal
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public double GramsOfFood { get; set; }
        public bool WasBlended { get; set; }
        public double? GramsOfWater { get; set; }

        // Bailey Chair
        public bool WasBaileyChairUsed { get; set; }
        public DateTime? TimePutInBaileyChair { get; set; }
        public DateTime? TimeLeftBaileyChair { get; set; }

        // Medicine
        public bool WasMedicineGiven { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        public DateTime? TimeMedicineGiven { get; set; }
    }
}