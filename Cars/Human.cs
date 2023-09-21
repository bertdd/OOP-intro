namespace Cars;

public class Human
{
  public string LastName { get; set; }
  public string FirstName { get; set; }
  public int License { get; set; }

  public override string ToString()
  {
    return $"{FirstName} {LastName} {License}";
  }
}
