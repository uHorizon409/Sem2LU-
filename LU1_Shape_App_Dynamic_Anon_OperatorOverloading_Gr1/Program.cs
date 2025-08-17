// Import your namespace
using System;
using LU1_Shape_App_Dynamic_Anon_OperatorOverloading_Gr1; 

class Program
{
    static void Main(string[] args)
    {
        // Create Circle objects
        Circle circle1 = new Circle(3);  
        Circle circle2 = new Circle(4);  

        // Add Circles using overloaded +
        Circle combinedCircle = circle1 + circle2;

        Console.WriteLine("CIRCLE");
        Console.WriteLine($"Circle 1 Area: {circle1.GetArea():F2}");
        Console.WriteLine($"Circle 2 Area: {circle2.GetArea():F2}");
        Console.WriteLine($"Combined Circle Radius: {combinedCircle.Radius:F2}");
        Console.WriteLine($"Combined Circle Area: {combinedCircle.GetArea():F2}");

        Console.WriteLine();

        // Create Rectangle objects
        Rectangle rect1 = new Rectangle(5, 10); // width = 5, height = 10
        Rectangle rect2 = new Rectangle(3, 6);  // width = 3, height = 6

        // Add Rectangles using overloaded +
        Rectangle combinedRect = rect1 + rect2;

        Console.WriteLine("RECTANGLE");
        Console.WriteLine($"Rectangle 1 Area: {rect1.GetArea():F2}");
        Console.WriteLine($"Rectangle 2 Area: {rect2.GetArea():F2}");
        Console.WriteLine($"Combined Rectangle Width: {combinedRect.Width}");
        Console.WriteLine($"Combined Rectangle Height: {combinedRect.Height}");
        Console.WriteLine($"Combined Rectangle Area: {combinedRect.GetArea():F2}");
    }
}
