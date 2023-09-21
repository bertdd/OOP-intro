
namespace eersteles;

public class SlipperList : List<Slipper>
{
  public SlipperList()
  {

  }

  public void Print()
  {
    foreach (var slipper in this)
    {
      Console.WriteLine(slipper);
    }
  }
}
