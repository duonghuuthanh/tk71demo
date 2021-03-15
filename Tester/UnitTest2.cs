using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tester
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestN0()
        {
            double x = 3;
            int n = 0;
            double expected = 1;
            double actual = Demo.MyPower.Power(x, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNEven1()
        {
            double x = 3;
            int n = 2;
            double expected = 9;
            double actual = Demo.MyPower.Power(x, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNEven2()
        {
            double x = -3;
            int n = 2;
            double expected = 9;
            double actual = Demo.MyPower.Power(x, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNOdd1()
        {
            double x = 3;
            int n = 3;
            double expected = 27;
            double actual = Demo.MyPower.Power(x, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNOdd2()
        {
            double x = -3;
            int n = 3;
            double expected = -27;
            double actual = Demo.MyPower.Power(x, n);

            Assert.AreEqual(expected, actual);
        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Tester\\Data.csv"), TestMethod]
        public void TestFile()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());

            Assert.AreEqual(expected, Demo.MyPower.Power(a, b));
        }
    }
}
