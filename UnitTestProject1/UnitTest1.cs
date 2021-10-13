using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestingExample;

namespace UnitTestProject1
{
/// <summary>
/// will test every mothod in the calculator.cs
/// will NOT test the prog.cs
/// </summary>
    [TestClass]
    public class UnitTest1
    {
        Calculator calc; 

        [TestInitialize] //test attribute
        public void TestInitialize()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestAdd()
        {
            int result = calc.Add(10, 15);
            Assert.AreEqual(result, 25);
        }
        [TestMethod]
        public void TestSub()
        {
            int result = calc.Sub(10,15);
            Assert.AreEqual(result, -5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDivWithZero()
        {
            int result = calc.Div(10, 0);
            //Assert.ThrowsException;
        }
        [TestCleanup]
        public void CleanUp()
        {
            calc = null;
        }
    }
}
//to see how much of your program is covered by your test
//extenstion => manage extension => fine code coverage
