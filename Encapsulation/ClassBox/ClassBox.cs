namespace ClassBox
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class ClassBox
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            try
            {
                var lenght = double.Parse(Console.ReadLine());
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var box = new Box(lenght, width, height);
                box.PrintSurfaceArea();
                box.PritnLaterlSurfaceArea();
                box.PrintVolume();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
