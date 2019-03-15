using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib
{
    public class SquareCalc
    {
        private readonly static int _undefineResult = -1;

        //метод, вычисляющий площадь круга
        public static double GetCircleSquare(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        //метод, вычисляющий площадь треугольника
        public static double GetTriangleSquare(double a, double b, double c)
        {
            double square = _undefineResult;

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);

            try
            {
                //определяем, является ли треугольник прямоугольным и находим гипотенузу
                double hуpotenuse = GetHypotenuse(a, b, c);

                //если треугольник является прямоугольным
                if (hуpotenuse > 0)
                {
                    double[] sides = { a, b, c };
                    //исключаем гипотенузу
                    var result = sides.Where(side => side != hуpotenuse).ToArray();
                    //находим площадь прямоугольного треугольника
                    square = result[0] * result[1] / 2;
                }
                else if (CheckTriangle(a, b, c))
                {
                    //опредяляем значение полупериметра треугольника
                    double p = (a + b + c) / 2;
                    //находим площадь треугольника
                    square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
            }
            catch
            {

            }

            return square;
        }

        //метод, проверяющий существование треугольника по 3-м заданным сторонам
        private static bool CheckTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a ? true : false;
        }

        //метод для проверки, является ли треугольник прямоугольным
        public static bool CheckRightAngled(double a, double b, double c)
        {
            return 
                a * a== b * b + c * c ||
                b * b == a * a + c * c || 
                c * c == a * a + b * b 
                ? true : false;
        }
        
        //метод для проверки, является ли треугольник прямоугольным и находим гипотенузу
        private static double GetHypotenuse(double a, double b, double c)
        {
            double hуpotenuse = _undefineResult;

            if (a * a == b * b + c * c)
                hуpotenuse = a;
            else if (b * b == a * a + c * c)
                hуpotenuse = b;
            else if (c * c == b * b + a * a)
                hуpotenuse = c;

            return hуpotenuse;
        }

        //метод, вычисляющий площадь без указания типа фигуры
        public static double GetAutoSquare(double a = 0, double b = 0, double c = 0)
        {
            double square;
            double[] sides = { a, b, c };
            var result = sides.Where(side => side != 0).ToArray();

            switch (result.Count())
            {
                case 1:
                    square = GetCircleSquare(result[0]);
                    break;
                case 3:
                    square = GetTriangleSquare(result[0], result[1], result[2]);
                    break;
                default:
                    square = _undefineResult;
                    break;
            }

            return square;
        }
    }
}
