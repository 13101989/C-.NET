using System.Xml.Serialization;

namespace Practice.Packt.Library;

public class Rectangle : Shape
{
    public Rectangle() { }
    public Rectangle(string colour, double height, double width) : base()
    {
        Colour = colour;
        Height = height;
        Width = width;
    }

    [XmlAttribute("Height")]
    public double Height { get; set; }

    [XmlAttribute("Width")]
    public double Width { get; set; }
    public override double Area { get { return Height * Width; } }
}
