namespace ShapeLibrary.Test;

public class ShapeTest
{
    [Fact]
    public void CircleAreaTest()
    {
        double radius = 5;
        IShape circle = new Circle(radius);
        double expectedArea = Math.PI * radius * radius;

        Assert.Equal(expectedArea, circle.CalculateArea(), 10);
    }

    [Fact]
    public void TriangleAreaTest()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        IShape triangle = new Triangle(a, b, c);
        double expectedArea = 6;

        Assert.Equal(expectedArea, triangle.CalculateArea(), 10);
    }

    [Fact]
    public void TriangleIsRightTriangleTest()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        Triangle triangle = new Triangle(a, b, c);

        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void InvalidTriangleTest()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }

    [Fact]
    public void InvalidCircleTest()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }
}