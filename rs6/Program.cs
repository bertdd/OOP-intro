using rs6;
using System.Globalization;
using System.Text.Json;

CultureInfo.CurrentCulture = new CultureInfo("nl-NL");

var carlist = 
  (List<Car>?)JsonSerializer.Deserialize(File.ReadAllText("cars.json"),
  typeof(List<Car>));

var toei = new Driver
{
  Name = "Toei",
  Age = 20,
  Licence = "rolstoel"
};

var nordin = new Driver
{
  Name = "Nordin"
};

carlist[0].CarDriver = nordin;
carlist[1].CarDriver = nordin;
carlist[2].CarDriver = toei;

foreach (var car in carlist)
{
  Console.WriteLine(car);
}

File.WriteAllText("cars.json", JsonSerializer.Serialize(carlist));

