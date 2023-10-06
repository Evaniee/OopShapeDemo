using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OopShapeDemo;

namespace OopShapeTest
{


    [TestClass]
    public class UnitTest1
    {
        [TestCategory("Icosagon.cs")]

        [TestMethod]
        // Test Icosagons can calculate area correctly.
        public void IcosagonAreaTest()
        {
            Regular2DShape myShape = new Icosagon(5);
            double area = myShape.Area();
            Assert.AreEqual(789.22, Math.Round(area, 2, MidpointRounding.AwayFromZero)); // Google checker only does to 2 D.P.
        }

        [TestMethod]
        // Test Icosagons throw error when sent 0 as an arguement for length.
        public void IcosagonConstructorZeroTest()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Icosagon(0); }, "Shape did not throw expected arguement when zero passed to constructor.");
        }

        [TestMethod]
        // Test Icosagons throw error when sent a negative number as an arguement for length.
        public void IcosagonConstructorNegativeTest()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Icosagon(-1); }, "Shape did not throw expected arguement when negative value passed to constructor..");
        }

        [TestCategory("Circle.cs")]
        [TestMethod]
        // Test Circle can calculate area correctly.
        public void CircleAreaTest()
        {
            double area = new Circle(30).Area();
            Assert.AreEqual(706.86, Math.Round(area, 2, MidpointRounding.AwayFromZero));
        }
        
        [TestMethod]
        // Test Circle throw error when sent 0 as an arguement for length.
        public void CircleConstructorZeroTest()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Circle(0); }, "Shape did not throw expected arguement when zero passed to constructor.");
        }

        [TestMethod]
        // Test Circle throw error when sent a negative number as an arguement for length.
        public void CircleConstructorNegativeTest()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Circle(-1); }, "Shape did not throw expected arguement when negative value passed to constructor..");
        }
    }
}
