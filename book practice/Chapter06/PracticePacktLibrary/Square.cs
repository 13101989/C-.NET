namespace Practice.Packt.Shared;

public class Square : Shape
{
    public Square(double heightOrWidth)
    {
        Width = Height = heightOrWidth;
    }
}
