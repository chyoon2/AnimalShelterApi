using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelterApi.Models
{
  public class  AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions< AnimalShelterApiContext> options)
        : base(options)
    {
    }
    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
      new Animal { AnimalId = 1, Name = "Matilda", Species = "Woolly Mammoth", Age = 7, Gender = "Female", Breed = "Alpine", DateOfAdmittance =DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1"},
      new Animal { AnimalId = 2, Name = "Rexie", Species = "Dinosaur", Age = 10, Gender = "Female" , Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1"},
      new Animal { AnimalId = 3, Name = "Matilda", Species = "Dinosaur", Age = 2, Gender = "Female", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Animal { AnimalId = 4, Name = "Pip", Species = "Shark", Age = 4, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
      new Animal { AnimalId = 6, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
      new Animal { AnimalId = 7, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
      new Animal { AnimalId = 8, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
      new Animal { AnimalId = 9, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
      new Animal { AnimalId = 10, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
      new Animal { AnimalId = 11, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
      new Animal { AnimalId = 12, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
      new Animal { AnimalId = 13, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
      );
    }
  }
}