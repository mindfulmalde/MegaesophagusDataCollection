using Mdc.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mdc.Data
{
    public class MegaContext : DbContext
    {
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Medicine> Medicines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealMedicine>()
                .HasKey(mm => new { mm.MealId, mm.MedicineId });

            modelBuilder.Entity<MealMedicine>()
                .HasOne(mm => mm.Meal)
                .WithMany(meal => meal.MealMedicines)
                .HasForeignKey(mm => mm.MealId);

            modelBuilder.Entity<MealMedicine>()
                .HasOne(mm => mm.Medicine)
                .WithMany(med => med.MealMedicines)
                .HasForeignKey(mm => mm.MedicineId);
        }
    }
}
