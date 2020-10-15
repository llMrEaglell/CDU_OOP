using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;

namespace Lab3Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CreateEmpty()
        {
            TCircle test = new TCircle();
            Assert.AreEqual(1, test.Radius, "Empty constructor don't work");
        }

        [TestMethod]
        public void CopyConstruct()
        {
            TCircle test = new TCircle(15);
            TCircle test2 = new TCircle(test);
            Assert.AreEqual(test.Radius, test2.Radius, "Copy constructor don't work");
        }

        [TestMethod]
        public void DoubleConstruct()
        {
            TCircle test = new TCircle(15.26);
            Assert.AreEqual(15.26, test.Radius, "Double constructor don't work");
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new TCircle(-15));
        }

        [TestMethod]
        public void SuareAndLength()
        {
            TCircle test = new TCircle(15);
            Assert.AreEqual(Math.PI * Math.Pow(15, 2), test.GetSquare(), "Square don't work");
            Assert.AreEqual(2 * Math.PI * 15, test.GetLength(), "Square don't work");
        }

        [TestMethod]
        public void Comparison()
        {
            TCircle test = new TCircle(14);
            TCircle test1 = new TCircle(18);
            Assert.AreEqual(true, test < test1, "< don't work");
            Assert.AreEqual(false, test > test1, "> don't work");
            Assert.AreEqual(false, test == test1, "== don't work");
            Assert.AreEqual(true, test != test1, "!= don't work");
        }

        [TestMethod]
        public void Equals()
        {
            TCircle test = new TCircle(14);
            TCircle test1 = new TCircle(14);
            TCircle test2 = new TCircle(15);
            Assert.AreEqual(false, test1.Equals(test2), "Equals don't work");
            Assert.AreEqual(true, test1.Equals(test), "Equals don't work");
            Assert.AreEqual(true, test1.Equals(test1), "Equals don't work");
        }


    }
}