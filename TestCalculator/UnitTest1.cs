using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator2;

namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;

        [TestInitialize]
        public void SetUp()
        {
            cal = new Calculation(10, 5);
        }

        [TestMethod]
        public void TestAddOperator()
        {
           //ab= 10,5/15
            
            Assert.AreEqual(15, cal.Execute("+"));//15
        }
        [TestMethod]
        public void TestSubOperator()
        {
            //ab= 10,5/15
            //Calculation cal = new Calculation(10, 5);
            Assert.AreEqual(5, cal.Execute("-"));//15
        }
        [TestMethod]
        public void TestMulOperator()
        {
            //ab= 10,5/15
            //Calculation cal = new Calculation(10, 5);
            Assert.AreEqual(50, cal.Execute("*"));//15
        }
        [TestMethod]
        public void TestDivOperator()
        {
            //ab= 10,5/15
            //Calculation cal = new Calculation(10, 5);
            Assert.AreEqual(2, cal.Execute("/"));//15
        }

        [TestMethod]
        [ExpectedException (typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            //ab= 10,5/15
            Calculation c = new Calculation(10, 0);
            c.Execute("/");//15
        }
    }
}
