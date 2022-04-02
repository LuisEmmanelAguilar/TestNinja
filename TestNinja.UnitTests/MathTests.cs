using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Arrange
            var math = new Math();

            // Act
            var result = math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }


        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            // Arrange
            var math = new Math();

            // Act
            var result = math.Max(2, 1);

            // Asser
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            // Arrange
            var math = new Math();

            // Act
            var result = math.Max(2, 3);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            // Arrange
            var math = new Math();

            // Act
            var result = math.Max(4, 4);

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }

    }
}
