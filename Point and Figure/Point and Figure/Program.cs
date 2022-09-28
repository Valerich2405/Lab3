using System;
using System.Collections.Generic;

namespace Point_and_Figure
{
    class Point
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        private int x;
        public int X
        {
            get
            {
                return x;
            }
        }

        private int y;
        public int Y
        {
            get
            {
                return y;
            }
        }

        public Point(int _x, int _y, string _name)
        {
            this.x = _x;
            this.y = _y;
            this.name = _name;
        }
    }

    class Figure
    {
        private double perimeter;
        public double Perimeter 
        { 
            get 
            { 
                return perimeter; 
            } 
            set 
            { 
                this.perimeter = value; 
            } 
        }

        private string shape;
        enum Shape
        {
            Triangle,
            Quadrangle,
            Pentagon
        }

        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;

        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            shape = Shape.Triangle.ToString();
            Console.WriteLine(shape);
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            shape = Shape.Quadrangle.ToString();
            Console.WriteLine(shape);
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            shape = Shape.Pentagon.ToString();
            Console.WriteLine(shape);
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }

        public double PerimeterCalculator()
        {
            double perimeter = Perimeter;
            if (shape == Shape.Triangle.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, C) + LengthSide(B, C);
                return perimeter;
            }

            else if (shape == Shape.Quadrangle.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, D) + LengthSide(B, C) + LengthSide(C, D);
                return perimeter;
            }

            else if (shape == Shape.Pentagon.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, E) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E);
                return perimeter;
            }

            return perimeter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(3, 3, "A"));
            points.Add(new Point(5, 3, "B"));
            points.Add(new Point(5, 12, "C"));
            points.Add(new Point(2, 15, "D"));
            points.Add(new Point(7, 7, "E"));

            Console.WriteLine("The following figures are given");
            Console.WriteLine("1.Triangle.");
            Console.WriteLine("2.Quadrangle.");
            Console.WriteLine("3.Pentagon.");
            Console.Write("Select the name of the shape: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Result:");

            switch (a)
            {
                case 1:
                    Figure triangle = new Figure(points[0], points[1], points[2]);
                    double t = triangle.PerimeterCalculator();
                    Console.Write($"Perimeter of a triangle = {t}.");
                    break;
                case 2:
                    Figure rectangle = new Figure(points[0], points[1], points[2], points[3]);
                    double r = rectangle.PerimeterCalculator();
                    Console.Write($"Perimeter of a quadrangle = {r}.");
                    break;
                case 3:
                    Figure pentagon = new Figure(points[0], points[1], points[2], points[3], points[4]);
                    double p = pentagon.PerimeterCalculator();
                    Console.Write($"Perimeter of a pentagon = {p}.");
                    break;
            } 
        }
    }
}
