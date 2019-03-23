using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib
{
    public abstract class Shape
    {
        public readonly int UndefinedResult = -1;

        public Shape(double radius)
        {
        }

        public Shape(double aSide, double bSide, double cSide)
        {
        }

        public Shape()
        {
        }

        public abstract double CalcSquare();
    }
}
