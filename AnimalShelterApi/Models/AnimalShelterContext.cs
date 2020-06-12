using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Charlie", Details = "Cute, but wild. Tends to bite a lot", Breed = "Mutt Tabby Cat"},
                new Animal { AnimalId = 2, Name = "Mochi", Details = "Very sweet, overall good cat.", Breed = "Mutt Tabby Cat"},
                new Animal { AnimalId = 3, Name = "Kenji", Details = "Very independent cat. ", Breed = "Mutt Black and White Cat"},
                new Animal { AnimalId = 4, Name = "Sumo", Details = "Lap cat, always needs affection.", Breed = "All Grey Cat"},
                new Animal { AnimalId = 5, Name = "Honda", Details = "Medium size dog, can be walked without leash.", Breed = "German Shepard"}
            );
        }
    }
}