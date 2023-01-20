namespace National.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }

    public List<State> States { get; set; }
  }
}