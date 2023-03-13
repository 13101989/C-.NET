interface IShape 
{
    double Area();
    double Perimeter();
}

abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();

    public void Print()
    {
        Console.WriteLine("This is a test");
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double Area()
    {
        return 3.14 * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * 3.14 * radius;
    }
}

class Rectangle : IShape 
{
    private double length;
    private double width;
    public Rectangle(double l, double w)
    {
        length = l; 
        width = w;
    }

    public double Area()
    {
        return length * width;
    }

    public double Perimeter()
    {
        return 2 * (length + width);
    }
}

class Test 
{
    static void Main(string[] args) 
    {
        Circle circle = new Circle(5.0);
        Console.WriteLine("Circle area = {0}", circle.Area());
        Console.WriteLine("Circle Perimeter = {0}", circle.Perimeter());
        circle.Print();

        Rectangle rectangle = new Rectangle(7.5, 2.5);
        Console.WriteLine("Rectangle area = {0}", rectangle.Area());
        Console.WriteLine("Rectangle perimeter = {0}", rectangle.Perimeter());

        Console.ReadKey();
    }
}
