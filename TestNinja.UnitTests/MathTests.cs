using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {

        // SetUp
        private Math _math;
        
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }


        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Act
            var result = _math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }


        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            // Act
            var result = _math.Max(a, b);

            // Asser
            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            // A little bit too general...always will pass
            Assert.That(result, Is.Not.Empty);

            // A little bit more specific
            Assert.That(result.Count(), Is.EqualTo(3));

            // A litlle bit more general...
            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));

            // Cleaner way to write the last 3 Assertions
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            // Make you sure that is ordered
            Assert.That(result, Is.Ordered);

            // Make you sure that there are not duplicate items in the collection
            Assert.That(result, Is.Unique);
        }

    }
}
