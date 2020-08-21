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
    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dog>()
      .HasData(
      new Dog { DogId = 1, Name = "Matilda", Species = "Woolly Mammoth", Age = 7, Gender = "Female", Breed = "Alpine", DateOfAdmittance =DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1"},
      new Dog { DogId = 2, Name = "Rexie", Species = "Dinosaur", Age = 10, Gender = "Female" , Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1"},
      new Dog { DogId = 3, Name = "Matilda", Species = "Dinosaur", Age = 2, Gender = "Female", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Dog { DogId = 4, Name = "Pip", Species = "Shark", Age = 4, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Dog { DogId = 5, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Dog { DogId = 6, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Dog { DogId = 7, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Dog { DogId = 8, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Dog { DogId = 9, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Dog { DogId = 10, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Dog { DogId = 11, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Dog { DogId = 12, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
      new Dog { DogId = 13, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", Breed = "Alpine", DateOfAdmittance = DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
      );

      builder.Entity<Cat>()
      .HasData(
      new Cat { CatId = 1, Name = "Catname", Species = "Woolly Mammoth", Age = 7, Gender = "Female", Breed = "Alpine", DateOfAdmittance =DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1"},
      new Cat { CatId = 2, Name = "Cat3name", Species = "Woolly Mammoth", Age = 7, Gender = "Female", Breed = "Alpine", DateOfAdmittance =DateTime.Now, Url = "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1"}
      );
    }
  }
}