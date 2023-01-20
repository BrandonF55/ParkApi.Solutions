using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using National.Models;

namespace National.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StateController : ControllerBase
  {
    private readonly NationalContext _db;

    public StateController(NationalContext db)
    {
      _db = db;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<State>> GetTipe(int id)
    {
      State state = await _db.States.FindAsync(id);

      if (state == null)
      {
        return NotFound();
      }
      return state;
    }

    [HttpGet]
    public async Task<List<State>> Get(int rating)
    {
      IQueryable<State> query = _db.States.AsQueryable();

      if (rating > 0 && rating < 6)
      {
        query = query.Where(entry => entry.Rating == rating);
      }

      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<State>> Post(State state)
    {
      _db.States.Add(state);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetTipe), new { id = state.StateId }, state);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, State state)
    {
      if (id != state.StateId)
      {
        return BadRequest();
      }
      _db.States.Update(state);


      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!StateExists(id))
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

    private bool StateExists(int id)
    {
      return _db.States.Any(e => e.StateId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteState(int id)
    {
      State state = await _db.States.FindAsync(id);
      if (state == null)
      {
        return NotFound();
      }

      _db.States.Remove(state);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}