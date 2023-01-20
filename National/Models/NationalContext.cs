using Microsoft.EntityFrameworkCore;

namespace National.Models
{
  public class NationalContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }
    public DbSet<State> States { get; set; }

    public NationalContext(DbContextOptions<NationalContext> options) : base(options)
    {
    }
  }
}