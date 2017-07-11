using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            var height = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var radius = double.Parse(Console.ReadLine());
            Shape rectangle = new Rectangle(height, width);
            Shape circle = new Circle(radius);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
