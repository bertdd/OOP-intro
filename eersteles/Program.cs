using eersteles;
using System.Text.Json;

//var slippers = new SlipperList();
// slippers.Print();

//var jsonString = JsonSerializer.Serialize(slippers);
//File.WriteAllText("slippers.json", jsonString);

var jsonTerug = File.ReadAllText("slippers.json");
var slippersTerug = JsonSerializer.Deserialize(jsonTerug, typeof(SlipperList)) as SlipperList;

slippersTerug.Print();
