using System;
using System.Globalization;
using System.Text.Json;
using rs6;

CultureInfo.CurrentCulture = new("nl-NL");
Console.WriteLine(DateTime.Now);

var list = new List<Car>
{
  new Car
  {
    Brand = "Audi",
    Model = "RS-6",
    Price = 300000
  },
  new Car
  {
    Brand = "Volkswagen",
    Model = "Golf GTI",
    Year = 2002,
    Price = 12000
  },
  new Car
  {
    Year = 2016,
    Price = 32000,
    Model = "G classes",
    Brand = "mercedes"
  }
};

foreach (var car in list)
{
  Console.WriteLine(car);
}

var data = JsonSerializer.Serialize(list);

File.WriteAllText(@"c:\temp\mijn.json", data);

