using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareCalcLib;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine(circle.CalcSquare().ToString());

            Triangle triangle = new Triangle(8, 6, 10);
            Console.WriteLine(triangle.CalcSquare().ToString());

            CommonShape common = new CommonShape();
            common.Dimentions = new double[] { 10 };
            Console.WriteLine(common.CalcSquare().ToString());

            common.Dimentions = new double[] { 8, 6, 10 };
            Console.WriteLine(common.CalcSquare().ToString());
        }
    }
}
