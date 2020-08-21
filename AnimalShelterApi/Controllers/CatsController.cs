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
  public class CatsController : ControllerBase
  {
    private AnimalShelterApiContext _db;
    private readonly IUriService uriService;
    
    public CatsController( AnimalShelterApiContext db, IUriService uriService)
    {
      _db = db;
      this.uriService = uriService;
    }

    [HttpGet("pages")]
    public async Task<IActionResult> GetPages([FromQuery] PaginationFilter filter)
    {
      var route = Request.Path.Value;
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize); 
      var pagedData = await _db.Cats
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToListAsync();
        var totalRecords = await _db.Cats.CountAsync();      
        var pagedReponse = PaginationHelper.CreatePagedReponse<Cat>(pagedData, validFilter, totalRecords, uriService, route);
        return Ok(pagedReponse);
    }

    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get(string name, string species)
    {
      var query = _db.Cats.AsQueryable();
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
    
    [HttpPost]
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }
    //api/cats/1  
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var cat = await _db.Cats.Where(a => a.CatId == id).FirstOrDefaultAsync();
        return Ok(new Response<Cat>(cat)); 
    }
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Cat cat)
    {
      cat.CatId = id;
      _db.Entry(cat).State = EntityState.Modified;
      _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var catToDelete = _db.Cats.FirstOrDefault(entry =>entry.CatId == id);
      _db.Cats.Remove(catToDelete);
      _db.SaveChanges();
    }
  }
}