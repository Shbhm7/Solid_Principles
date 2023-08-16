using OpenClosed;
using System;
using System.Collections.Generic;

class Program
{  
      public static void Main()
{
List<Shape> shapes = new List<Shape>
{
       new Rectangle { Width = 5, Height = 10 },
       new Circle { Radius = 7 }
};

   ShapeCalculator calculator1 = new ShapeCalculator();
   double totalArea = calculator1.CalculateTotalArea(shapes);
   Console.WriteLine($"Total Area: {totalArea}");
   Console.ReadLine();
 }
}