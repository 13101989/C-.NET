﻿namespace Practice.Packt.Shared;

public class Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public virtual double Area { get { return Width * Height; } }

}