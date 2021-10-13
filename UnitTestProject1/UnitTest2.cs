using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingExample;

namespace UnitTestProject1
{
    /// <summary>
    /// to test the program.cs only
    /// not the calculator.cs
    /// 
    /// </summary>
    public class UnitTest2
    {
        Mock<ICalculator> calculatormock;
        [TestInitialize]
        public void Initialize()
        {
            Program.addResult = Program.divResult = Program.multiplyResult = Program.subResult = 0;
            calculatormock = new Mock<ICalculator>(MockBehavior.Default);
            calculatormock.CallBase = false;

            //mock set up is only for these numbers 
            //when the test runs, will only cll the method and not the original class

            calculatormock.Setup(x => x.Add(10, 15)).Returns(10);
            calculatormock.Setup(x => x.Sub(10, 15)).Returns(10);
            calculatormock.Setup(x => x.Div(10, 15)).Returns(10);
            calculatormock.Setup(x => x.Multiply(10, 15)).Returns(10);

            //instead of calling calculator method,
            //will call the mocked version of it
            Program.calc = calculatormock.Object;

        }

        [TestMethod]
        public void testAdition()
        {
            Program.CallCalculatorMethods(10,15);
            Assert.AreEqual(Program.addResult, 10);
            Assert.AreEqual(Program.divResult, 10);
            Assert.AreEqual(Program.multiplyResult, 10);
            Assert.AreEqual(Program.divResult, 10);

        }

        [TestCleanup]
        public void CleanUp()
        {
            //to ensure all the mocking exist in the code
            calculatormock.VerifyAll();
        }
    }
}
