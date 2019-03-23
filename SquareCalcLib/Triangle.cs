using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib
{
    public class Triangle: Shape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double aSide, double bSide, double cSide) : base (aSide, bSide, cSide)
        {
            _a = Math.Abs(aSide);
            _b = Math.Abs(bSide);
            _c = Math.Abs(cSide);
        }

        private bool Check(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a ? true : false;
        }

        //метод для проверки, является ли треугольник прямоугольным
        public bool CheckRightAngled()
        {
            return
                _a * _a == _b * _b + _c * _c ||
                _b * _b == _a * _a + _c * _c ||
                _c * _c == _a * _a + _b * _b
                ? true : false;
        }

        public override double CalcSquare()
        {
            if (!Check(_a, _b, _c)) return UndefinedResult;

            double p = (_a + _b + _c) / 2;

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
