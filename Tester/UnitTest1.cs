using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivideSuccess()
        {
            int a = 15;
            int b = 5;
            double expected = 3.0;

            double actual = Demo.Calculator.chia(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNegativeDivideSuccess()
        {
            int a = -15;
            int b = 5;
            double expected = -3.0;

            double actual = Demo.Calculator.chia(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            int a = 15;
            int b = 0;

            Demo.Calculator.chia(a, b);
        }
    }
}
