﻿using Cars;
using System.Text.Json;

var carInfo = File.ReadAllText("car.json");
var carList = (List<Car>?) JsonSerializer.Deserialize(carInfo, typeof(List<Car>));

foreach (var car in carList)
{
  Console.WriteLine(car);
}

var data = JsonSerializer.Serialize(carList);
File.WriteAllText("car.json", data);
