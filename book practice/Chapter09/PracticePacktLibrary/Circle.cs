using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Practice.Packt.Library;

public class Circle : Shape
{
    public Circle() { }
    public Circle(string colour, double radius)
    {
        Colour = colour;
        Radius = radius;
    }

    private double Pi = Math.PI;

    [XmlAttribute("Radius")]
    [JsonInclude]
    public double Radius;
    public override double Area { get { return Math.Round(Pi * Math.Pow(Radius, 2), 2); } }
}
