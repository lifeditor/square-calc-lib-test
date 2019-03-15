using SquareCalcLib;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquareCalcLib.Tests
{
    [TestClass]
    public class SquareCalcTests
    {
        [TestMethod]
        public void GetCircleSquareTest()
        {
            //arrange
            double radius = 10;
            double expected = Math.PI * Math.Pow(radius, 2);

            //actual
            double actual = SquareCalc.GetCircleSquare(radius);

            //accert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTriangleSquareTest()
        {
            //arrange
            double a = 8;
            double b = 6;
            double c = 10;
            double p = (a + b + c) / 2;
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            

            //actual
            double actual = SquareCalc.GetTriangleSquare(a, b, c);

            //accert
            Assert.AreEqual(expected, actual);
        }
    }
}
