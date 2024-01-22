using System;


namespace vecka_3_ovning
{
    internal class Program
    {

        static double area_calc(double radius)
        {

            double area = Math.Pow(radius, 2) * Math.PI;

            return area;
        }

        static void Main(string[] args)
        {


            // uppgift 1

            double value_1 = 3.5;
            double value_2 = 2.5;
            double value_3 = value_1*value_2;

            int value_4 = Math.Max(5, 10);

            Console.WriteLine(value_4);

            double value_5 = Math.Max(value_1, value_2);

            Console.WriteLine(value_5);


            // uppgift 2

            double circle_radius;
            double circle_area;


            Console.Write("Circle radius: ");
            circle_radius = Convert.ToDouble(Console.ReadLine());


            circle_area = area_calc(circle_radius);

            Console.WriteLine($"The radius {circle_radius} gives the area {circle_area}");

        }
    }
}
