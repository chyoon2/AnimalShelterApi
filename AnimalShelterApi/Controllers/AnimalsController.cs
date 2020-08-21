using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }
    // GET api/animals "read"
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string name, string species)
    {
      var query = _db.Animals.AsQueryable();
      if(name != null)
      {
        query = query.Where(x => x.Name == name);
      }
      if(species != null)
      {
        query = query.Where(x => x.Species == species);
      }
      return query.ToList();
    }
    // POST api/animals "create"
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }
    //api/animals/1  "details"
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
        return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }
    //PUT api/animals/5 "edit/update"
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }
    //DELETE api/animals/5  "delete"
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry =>entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }
}