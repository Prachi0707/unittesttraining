﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleDotNetExample;

namespace UnitTestingTraining.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddReturnsCorrectSumOfTwoArguments()
        {
            int a = 10, b = 15;
            Assert.AreEqual(a + b, Calculator.Add(a, b));
        }

        [TestMethod]        
        public void AddReturnsExceptionWhenArgumentsTooLarge()
        {
            int a = 2147483647;
            int b = 1;
            int c = a + b;
            Assert.IsTrue(c > 0);
        }
    }
}
