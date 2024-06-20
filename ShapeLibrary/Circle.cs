﻿namespace ShapeLibrary;

public class Circle: IShape
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("radius cannot be negative or null");
        }
        Radius = radius;
    }
    
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}