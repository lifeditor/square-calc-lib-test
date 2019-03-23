using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib
{
    public class CommonShape : Shape
    {
        public double[] Dimentions { get; set; } = new double[] { };

        public override double CalcSquare()
        {
            var result = Dimentions.Where(c => c > 0).ToArray();

            double square;

            switch (result.Count())
            {
                case 1:
                    Circle circle = new Circle(result[0]);
                    square = circle.CalcSquare();
                    break;
                case 3:
                    Triangle triangle = new Triangle(result[0], result[1], result[2]);
                    square = triangle.CalcSquare();
                    break;
                default:
                    square = UndefinedResult;
                    break;
            }

            return square;
        }
    }
}
