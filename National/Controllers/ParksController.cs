using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using National.Models;

namespace National.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParkController : ControllerBase
  {
    private readonly NationalContext _db;

    public ParkController(NationalContext db)
    {
      _db = db;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetParkrec(int id)
    {
      Park park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }
      return park;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      return await query.Include(state => state.States).ToListAsync();
    }
  }
}


//dotnet dev-certs https
//dotnet dev-certs https --trust

//dotnet dev-certs https --clean 1
//dotnet dev-certs https 2
//dotnet dev-certs https --trust 3

//what i get in return after i submit these commands in 
//the terminal is A valid HTTPS certificate is already present.
//sudo security add-trusted-cert -d -r trustRoot -k /Library/Keychains/System.keychain <<certificate>> next option