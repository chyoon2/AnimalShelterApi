using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using PaginationRequirements;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private AnimalShelterApiContext _db;
    private readonly IUriService uriService;
    
    public DogsController( AnimalShelterApiContext db, IUriService uriService)
    {
      _db = db;
      this.uriService = uriService;
    }

    [HttpGet("pages")]
    public async Task<IActionResult> GetPages([FromQuery] PaginationFilter filter)
    {
      var route = Request.Path.Value;
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize); //probably want to use a mapper here.
      var pagedData = await _db.Dogs
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToListAsync();
        var totalRecords = await _db.Dogs.CountAsync();      
        var pagedReponse = PaginationHelper.CreatePagedReponse<Dog>(pagedData, validFilter, totalRecords, uriService, route);
        return Ok(pagedReponse);
    }

    // GET api/dogs "read"
    [HttpGet]
    public ActionResult<IEnumerable<Dog>> Get(string name, string species)
    {
      var query = _db.Dogs.AsQueryable();
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
    // POST api/dogs "create"
    [HttpPost]
    public void Post([FromBody] Dog dog)
    {
      _db.Dogs.Add(dog);
      _db.SaveChanges();
    }
    //api/dogs/1  
    [HttpGet("{id}")]
    // public ActionResult<Dog> Get(int id)
    public async Task<IActionResult> Get(int id)
    {
        var dog = await _db.Dogs.Where(a => a.DogId == id).FirstOrDefaultAsync();
        return Ok(new Response<Dog>(dog)); 
    }
    //PUT api/dogs/5 "edit/update"
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Dog dog)
    {
      dog.DogId = id;
      _db.Entry(dog).State = EntityState.Modified;
      _db.SaveChanges();
    }
    //DELETE api/dogs/5  "delete"
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var dogToDelete = _db.Dogs.FirstOrDefault(entry =>entry.DogId == id);
      _db.Dogs.Remove(dogToDelete);
      _db.SaveChanges();
    }
  }
}