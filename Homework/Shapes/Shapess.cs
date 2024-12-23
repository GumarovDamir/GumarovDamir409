using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Shapes
{
    abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }


    class Circle : Shape
    {
        public required double Radius { get; init; }

        public override double CalculateArea() => Math.PI * Radius * Radius;

        public override double CalculatePerimeter() => 2 * Math.PI * Radius;
    }

    class Rectangle : Shape
    {
        public required double A { get; init; }
        public required double B { get; init; }


        public override double CalculateArea() => A * B;

        public override double CalculatePerimeter() => 2 * (A + B);
    }

    class Triangle : Shape
    {
        public required double A { get; init; }
        public required double B { get; init; }
        public required double C { get; init; }


        public override double CalculateArea()
        {
            return 0.5 * A * B;
        }

        public override double CalculatePerimeter()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }


    internal class Program
    {
        static void PrintShapeInfo(Shape shape)
        {
            Console.WriteLine("Площадь фигуры: " + shape.CalculateArea());
        }

        static void Main(string[] args)
        {
            Circle c = new Circle { Radius = 1 };
            Console.WriteLine($"Круг. Его периметр: {c.CalculatePerimeter()}, площадь: {c.CalculateArea()}");

            var r = new Rectangle { A = 2, B = 3 };
            Console.WriteLine($"Четырёхугольник. Его периметр: {r.CalculatePerimeter()}, площадь: {r.CalculateArea()}");

            Triangle t = new() { A = 3, B = 4, C = 5 };
            Console.WriteLine($"Треугольник. Его периметр: {r.CalculatePerimeter()}, площадь: {r.CalculateArea()}");

            PrintShapeInfo(c);
            PrintShapeInfo(r);
            PrintShapeInfo(t);
        }
    }
}
