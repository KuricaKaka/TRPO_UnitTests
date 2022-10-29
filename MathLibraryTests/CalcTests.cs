using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;
using System;

namespace MathLibraryTests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Add_5and3_expected8()
        {
            //arrange
            int a = 5;
            int b = 3;
            int expected = 8;
            //act
            Calc calc = new Calc();
            int actual = calc.Add(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Max_10and20_expected20()
        {
            double a = 10, b = 20;
            double expected = 20;
            Calc calc = new Calc();
            double actual = calc.Max(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sum_10and20_30returbed()
        {
            //arrange
            int x = 10, y = 20;
            int expected = 30;

            //act
            Calc c = new Calc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Log_5and25_05returbed()
        {
            //arrange
            double x = 5, y = 25;
            double expected = 0.5;

            //act
            Calc c = new Calc();
            double actual = c.Log(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Min_5and25_5returbed()
        {
            //arrange
            double x = 25, y = 5;
            double expected = 5;

            //act
            Calc c = new Calc();
            double actual = c.Min(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sqrt_25_5returbed()
        {
            //arrange
            double x = 25;
            double expected = 5;

            //act
            Calc c = new Calc();
            double actual = c.Sqrt(x);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
