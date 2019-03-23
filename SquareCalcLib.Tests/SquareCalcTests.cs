using SquareCalcLib;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquareCalcLib.Tests
{
    [TestClass]
    public class SquareCalcTests
    {
        [TestMethod()]
        public void CalcSquareTest()
        {
            //arrange
            double radius = 10;
            double expected = Math.PI * Math.Pow(radius, 2);

            //actual
            Circle circle = new Circle(radius);
            double actual = circle.CalcSquare();

            //accert
            Assert.AreEqual(expected, actual);
        }
    }
}
