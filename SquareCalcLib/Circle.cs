using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib
{
    public class Circle: Shape
    {
        private readonly double _radius;

        public Circle(double radius) : base(radius)
        {
            _radius = radius;
        }

        public override double CalcSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

    }
}
