using System.Text.Json.Serialization;
using System.Xml.Serialization;
namespace Practice.Packt.Library;

[JsonDerivedType(typeof(Circle))]
[JsonDerivedType(typeof(Rectangle))]
public class Shape
{
    [XmlAttribute("Colour")]
    public string? Colour { get; set; }

    public virtual double Area { get; }
}