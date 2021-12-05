using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringChecker;
using System;

namespace StringCheckerMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("aaaa")]
        [DataRow("aeae")]
        [DataRow("oiuoiu")]
        public void TestMethod1(string input)
        {
            Program p = new Program();
            var result = p.Checker(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("asbccc")]
        [DataRow("wewtwf")]
        [DataRow("")]
        [DataRow(null)]
        public void TestMethod2(string input)
        {
            Program p = new Program();
            var result = p.Checker(input);

            Assert.IsFalse(result);
        }
    }
}
