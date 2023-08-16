using System;
using System.Collections.Generic;
namespace OpenClosed
{
public class ShapeCalculator
{
    public double CalculateTotalArea(IEnumerable<Shape> shapes)
    {
    double totalArea = 0;
        foreach (var shape in shapes)
   {

      totalArea += shape.CalculateArea();
   }
     return totalArea;
}
}
}