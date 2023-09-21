namespace rs6;

public class Car
{
  public string? Brand { get; set; }
  public string? Model { get; set; }
  public int Year { get; set; }
  public string? Colour { get; set; }
  public decimal Price { get; set; }
  public string? Picture { get; set; }
  public Driver? CarDriver { get; set; }

  public override string ToString()
  {
    return $"{Brand} {Model} kost {Price:n2} Euro, Driver = {CarDriver?.Name}";
  }
}
