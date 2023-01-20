namespace National.Models
{
  public class State 
  {
    public int StateId { get; set; }
    public string Summary { get; set; }
    public int Rating { get; set; }

    public int ParkId { get; set; }
  }
}