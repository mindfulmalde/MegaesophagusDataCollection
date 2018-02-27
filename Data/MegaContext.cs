using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class MegaContext : DbContext
    {
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<DogFood> DogFoods { get; set; }
        public DbSet<DogFoodBrand> DogFoodBrands { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<VomitEpisode> VomitEpisodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MegasophDC;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Meal Medicine

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

            #endregion

            #region Dog Medicine

            modelBuilder.Entity<DogMedicine>()
                .HasKey(dm => new { dm.DogId, dm.MedicineId });

            modelBuilder.Entity<DogMedicine>()
                .HasOne(dm => dm.Dog)
                .WithMany(d => d.DogMedicines)
                .HasForeignKey(dm => dm.DogId);

            modelBuilder.Entity<DogMedicine>()
                .HasOne(dm => dm.Medicine)
                .WithMany(m => m.DogMedicines)
                .HasForeignKey(dm => dm.MedicineId);

            #endregion
        }
    }
}
