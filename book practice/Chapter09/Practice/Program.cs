using Practice.Packt.Library;
using System.Xml.Serialization; // XmlSerializer
using System.Text.Json;
using static System.Environment;
using static System.IO.Path;
using newtonJson = Newtonsoft.Json;

// create a list of Shapes to serialize
List<Shape> listOfShapes = new()
{
  new Circle { Colour = "Red", Radius = 2.5 },
  new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
  new Circle { Colour = "Green", Radius = 8.0 },
  new Circle { Colour = "Purple", Radius = 12.3 },
  new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
};

// serialize xml
WriteLine("* Serializing XML files");
XmlSerializer xml = new(type: listOfShapes.GetType(), new Type[] { typeof(Circle), typeof(Rectangle) }); 
string xmlPath = Combine(CurrentDirectory, "practice.xml");
using (FileStream streamXml = File.Create(xmlPath))
{
    xml.Serialize(streamXml, listOfShapes);
}
WriteLine($"{File.ReadAllText(xmlPath)}");

WriteLine();

// deserialize xml
WriteLine("* Deserializing XML files");
using (FileStream fileXml = File.Open(xmlPath, FileMode.Open))
{
    List<Shape>? loadedShapesXml = xml.Deserialize(fileXml) as List<Shape>;
    if (loadedShapesXml is not null)
    {
        foreach (Shape item in loadedShapesXml)
        {
            WriteLine("{0} is {1} and has an area of {2:N2}", item.GetType().Name, item.Colour, item.Area);
        }
    }

}

WriteLine();




//serialize json (System.Text.Json)
WriteLine("* Serializing JSON files with System.Text.Json");
JsonSerializerOptions jsonOptions = new()
{
    WriteIndented = true,
};
string jsonPath = Combine(CurrentDirectory, "practice.json");
using (FileStream streamJson = File.Create(jsonPath))
{
    JsonSerializer.Serialize<List<Shape>>(utf8Json: streamJson, value: listOfShapes, jsonOptions);
}
WriteLine($"{File.ReadAllText(jsonPath)}");

WriteLine();





//serialize json (Newtonsoft)
WriteLine("* Serializing JSON files with Newtonsoft.Json");
newtonJson.JsonSerializer json = new();
json.Formatting = newtonJson.Formatting.Indented;
string jsonPath2 = Combine(CurrentDirectory, "practice2.json");
using (StreamWriter streamJson2 = File.CreateText(jsonPath2))
{
    json.Serialize(streamJson2, listOfShapes);
}
WriteLine($"{File.ReadAllText(jsonPath2)}");

WriteLine();

//deserialize json (Newtonsoft)
WriteLine("* Deserializing JSON files with Newtonsoft.Json");

using (StreamReader fileJson2 = File.OpenText(jsonPath2))
{
    newtonJson.JsonSerializerSettings settings = new();
    settings.TypeNameHandling = newtonJson.TypeNameHandling.All;
    string strJson2 = newtonJson.JsonConvert.SerializeObject(listOfShapes, settings);
    List<Shape>? loadedShapesJson2 = newtonJson.JsonConvert.DeserializeObject<List<Shape>>(strJson2, settings);
    if (loadedShapesJson2 is not null)
    {
        foreach (Shape item in loadedShapesJson2)
        {
            WriteLine($"{item.GetType().Name} is {item.Colour} and has an area of {item.Area}");
        }
    }
}
