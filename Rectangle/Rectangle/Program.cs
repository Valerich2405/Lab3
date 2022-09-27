using System;

namespace Rectangle
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double Side1, double Side2)
        {
            this.side1 = Side1;
            this.side2 = Side2;
        }

        private double perimeter;
        public double Perimeter 
        {
            get
            {
                return perimeter;
            }
        }

        private double area;
        public double Area
        {
            get
            {
                return area;
            }
        }

        public double PerimeterCalculator()
        {
            perimeter = 2 * (side1 + side2);
            Console.WriteLine($"Perimeter = {perimeter}");
            return perimeter;
        }
        public double AreaCalculator()
        {
            area = side1 * side2;
            Console.WriteLine($"Area = {area}");
            return area;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a rectangle:");

            Console.Write("Enter the first side: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second side: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle(a, b);
            rectangle.PerimeterCalculator();
            rectangle.AreaCalculator();
        }
    }
}
