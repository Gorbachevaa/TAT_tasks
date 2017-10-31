using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dev_7;

namespace Dev_12
{
    // TestClass contains unit-tests.
    [TestClass]
    public class TriangleTest
    {
        public const string EQUALITERAL = "The triangle is equaliteral.";
        public const string ISOSCELE = "The triangle is isoscele.";
        /// <summary>
        /// Test checks Triangle's Existance. Class Checker is tested.
        /// Input data - 3 numbers.
        /// Expected result - true.
        /// Actual result - positive, value - true.
        /// </summary>
        [TestMethod]
        public void positiveTestForTriangleExistance()
        {
            double[] sides = { 2, 3, 4 };
            Checker checker = new Checker();
            bool actual = checker.IsTriangle(sides);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Test checks number's validity .Class Checker is tested.
        /// Input data - 3 numbers.
        /// Expected result - true.
        /// Actual result - positive, value - true.
        /// </summary>
        [TestMethod]
        public void positiveTestForValidTriangleSides()
        {
            double[] sides = { 2, 3, 4 };
            Checker checker = new Checker();
            bool actual = checker.IsValidSides(sides);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Test checks number's validity .Class Checker is checked.
        /// Input data - 3 numbers, one of them is negative.
        /// Expected result - false.
        /// Actual result - negative, value - false.
        /// </summary>
        [TestMethod]
        public void negativeTestForValidTriangleSides()
        {
            double[] sides = { 8, -1, 3 };
            Checker checker = new Checker();
            bool actual = checker.IsValidSides(sides);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Test checks Triangle's Existance. Class Checker is tested.
        /// Input data - 3 numbers, one of them is greater than sum of the others.
        /// Expected result - false.
        /// Actual result - negative, value - false.
        /// </summary>
        [TestMethod]
        public void negativeTestForTriangleExistance()
        {
            double[] sides = { 2, 2, 6};
            Checker checker = new Checker();
            bool actual = checker.IsTriangle(sides);;
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Test checks class Builder and the method DetemineType().
        /// Input data - 3 equal numbers. 
        /// Expected result - return Equaliteral type from enum TriangleType.
        /// Actual result - positive. Method returns Equaliteral TriangleType.
        /// </summary>
        [TestMethod]
        public void positiveTestEqualiteralTriangle()
        {
            double[] sides = { 2, 2, 2 };
            Builder builder = new Builder(sides);
            TriangleType actual = builder.DetermineType();
            TriangleType expected = TriangleType.Equaliteral;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Test checks class Builder and the method DetemineType().
        /// Input data - 3 numbers and two of them are equals. 
        /// Expected result - return Isosceles type from enum TriangleType.
        /// Actual result - positive. Method returns Isosceles TriangleType.
        /// </summary>
        [TestMethod]
        public void positiveTestIsoscelesTriangle()
        {
            double[] sides = { 2, 2, 3 };
            Builder builder = new Builder(sides);
            TriangleType actual = builder.DetermineType();
            TriangleType expected = TriangleType.Isosceles;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Test checks class Builder and the method DetemineType().
        /// Input data - 3 numbers and all are different. 
        /// Expected result - return Simple type from enum TriangleType.
        /// Actual result - positive. Method returns Simple TriangleType.
        /// </summary>
        [TestMethod]
        public void positiveTestSimpleTriangle()
        {
            double[] sides = { 2, 3, 4 };
            Builder builder = new Builder(sides);
            TriangleType actual = builder.DetermineType();
            TriangleType expected = TriangleType.Simple;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks double values.
        /// Input data - 3 equal double values.
        /// Expected result - message "The triangle is equaliteral.
        /// </summary>
        [TestMethod]
        public void positiveTestDoubleValues()
        {
            double[] sides = { 4.01, 4.01, 4.01};
            Builder builder = new Builder(sides);
            string actual = builder.Build(sides).GetTrType();
            string expected = EQUALITERAL;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///  Checks double values.
        /// Input data - 3 double values. And one of them differs by 10e-16.
        /// Expected result - message "The triangle is equaliteral.
        /// </summary>
        [TestMethod]
        public void negativeTestDoubleValues()
        {
            double[] sides = { 4.01, 4.01, 4*10e-16 };
            Builder builder = new Builder(sides);
            string actual = builder.Build(sides).GetTrType();
            string expected = ISOSCELE;
            Assert.AreEqual(expected, actual);
        }

    }
}
