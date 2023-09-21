public class Slipper
{
  public Slipper(string color)
  {
    Color = color;
  }

  public override string ToString()
  {
    return $"Het merk = {Brand} {Price}";
  }

  public string Color { get; set; }
  public string Material { get; set; }
  public float Size { get; set; }
  public decimal Price { get; set; }
  public string Brand { get; set; }
}
