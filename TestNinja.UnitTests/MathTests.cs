﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
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
        [Ignore("Need to check it later")]
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


    }
}