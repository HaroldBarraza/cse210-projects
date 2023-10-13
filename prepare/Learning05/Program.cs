using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square A1 =new Square("Blue", 3);
        shapes.Add(A1);

        Rectangle A2 = new Rectangle(2, 3, "Red");
        shapes.Add(A2);

        Circle A3 = new Circle("Skyblue", 3);
        shapes.Add(A3);

        foreach (Shape s in shapes)
        {
            string Color = s.GetColor();
            double Area = s.GetArea();

            Console.WriteLine($"The color {Color}, shape has an area of {Area}.");
        }

    }
}