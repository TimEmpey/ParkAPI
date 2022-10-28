
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using National.Models;

namespace National.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ActivitiesController : ControllerBase
  {
    private readonly NationalContext _db;

    public ActivitiesController(NationalContext db)
    {
      _db = db;
    }

    // GET api/activities/
    [HttpGet]
    public async Task<List<Activity>> Get(string name, string type, int size)
    {
      IQueryable<Activity> query = _db.Activities.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      return await query.ToListAsync();
    }
    // GET api/activities/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(int id)
    {
        var activity = await _db.Activities.FindAsync(id);

        if (activity == null)
        {
            return NotFound();
        }

        return activity;
    }

    // POST api/activities
    [HttpPost]
    public async Task<ActionResult<Activity>> Post(Activity activity)
    {
      _db.Activities.Add(activity);
      await _db.SaveChangesAsync();

      // return CreatedAtAction("Post", new { id = activity.ActivityId }, activity);
      return CreatedAtAction(nameof(GetActivity), new { id = activity.ActivityId }, activity);
    }

    // PUT: api/activities/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Activity activity)
    {
      if (id != activity.ActivityId)
      {
        return BadRequest();
      }

      _db.Entry(activity).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ActivityExists(id))
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

    // DELETE: api/activities/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteActivity(int id)
    {
      var activity = await _db.Activities.FindAsync(id);
      if (activity == null)
      {
        return NotFound();
      }

      _db.Activities.Remove(activity);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    
    private bool ActivityExists(int id)
    {
      return _db.Activities.Any(e => e.ActivityId == id);
    }
  }
}