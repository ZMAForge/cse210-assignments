using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();

        Square mySquare = new Square("yellow", 15);
        Rectangle myRectangle = new Rectangle("red", 15, 10);
        Circle myCircle = new Circle("blue", 5);

        _shapes.Add(mySquare);
        _shapes.Add(myRectangle);
        _shapes.Add(myCircle);

        foreach (Shape shape in _shapes)
        {
            shape.GetColor();
            shape.GetArea();
        }
    }
}