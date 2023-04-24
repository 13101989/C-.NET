namespace Practice.Packt.Shared;

public class Circle : Shape
{
    private double Pi = Math.PI;
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
        Height = Width = radius * 2;
    }

    public override double Area { get { return Pi * Math.Pow(Radius, 2); } }
}
