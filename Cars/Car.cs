namespace Cars;

public class Car
{
  public string Brand { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }
  public string Color { get; set; }
  public Human Driver { get; set; }
  public List<Human> Passengers { get; set; } = new List<Human>();

  public override string ToString()
  {
    return $"{Brand} {Model} uit {Year} driver: {Driver}, passengers {Passengers.Count}";
  }
}
