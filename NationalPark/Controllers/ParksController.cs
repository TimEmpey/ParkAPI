using System;
using System.Collections.Generic;
using System.Linq; 
// using System.Data.Entity;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using National.Models;

namespace National.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly NationalContext _db;

    public ParksController(NationalContext db)
    {
      _db = db;
    }

    // GET api/parks/
    [HttpGet]
    public async Task<List<Park>> Get(string name, string state, string camping)
    {
      IQueryable<Park> query = _db.Parks.Include(entry => entry.Activities).AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name).Include(entry => entry.Activities);
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State == state).Include(entry => entry.Activities);
      }

      if (camping != null)
      {
        query = query.Where(entry => entry.Camping == camping).Include(entry => entry.Activities);
      }

      return await query.ToListAsync();
    }

    [HttpGet("random")]
    public async Task<ActionResult<IEnumerable<Park>>> GetRandom()
    {
      int lower = 1;
      int upper = _db.Parks.Count() + 1;
      Random rnd = new Random();
      int id = rnd.Next(lower, upper);
      IQueryable<Park> quer = _db.Parks.Include(entry => entry.Activities).AsQueryable();
      quer = quer.Where(entry => entry.ParkId == id).Include(entry => entry.Activities);
      return await quer.ToListAsync();
    }
  
    // GET api/parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<Park>>> GetPark(int id)
    {
      IQueryable<Park> park = _db.Parks.Include(entry => entry.Activities).AsQueryable();
      park = park.Where(entry => entry.ParkId == id).Include(entry => entry.Activities);
      if (id > _db.Parks.Count())
      {
        return NotFound();
      }
      return await park.ToListAsync();
    }

    // POST api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      // return CreatedAtAction("Post", new { id = park.ParkId }, park);
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    // PUT: api/Parks/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }
    // DELETE: api/Parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    
    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    
  }
}