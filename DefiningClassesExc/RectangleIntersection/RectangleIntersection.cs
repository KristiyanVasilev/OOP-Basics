using System;
using System.Collections.Generic;

namespace RectangleIntersection
{
    public class RectangleIntersection
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var recNum = int.Parse(input[0]);
            var intersectionChecks = int.Parse(input[1]);
            var rectangles = new Dictionary<string, Rectangle>();
            for (int i = 0; i < recNum; i++)
            {
                var rectangleInfo = Console.ReadLine().Split();
                var id = rectangleInfo[0];
                var width = double.Parse(rectangleInfo[1]);
                var height = double.Parse(rectangleInfo[2]);
                var x = double.Parse(rectangleInfo[3]);
                var y = double.Parse(rectangleInfo[4]);

                var rectangle = new Rectangle(id, width, height, x, y);
                rectangles[id] = rectangle;
            }

            for (int i = 0; i < intersectionChecks; i++)
            {
                var listOfPairs = Console.ReadLine().Split();
                var firstId = listOfPairs[0];
                var secondId = listOfPairs[1];
                var result = rectangles[firstId].Intersects(rectangles[secondId]);
                Console.WriteLine(result.ToString().ToLower());        
            }            
        }
    }
}
