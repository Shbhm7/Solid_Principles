using LiskovSubstitution;
class Program
{
       static void Main(string[] args)

    {
        Shape shape1 = new Rectangle { Width = 5, Height = 10 };
        Shape shape2 = new Rectangle { Width = 8, Height = 4 };
        CalculateAndPrintArea(shape1);
        CalculateAndPrintArea(shape2);
    }
   static void CalculateAndPrintArea(Shape shape)
    {
       double area = shape.CalculateArea();
       Console.WriteLine($"Area: {area}");
    }
}