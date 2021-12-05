using IPaddressCheck;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IpAddressMsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_returnTrue()
        {
            Program p = new Program();
            var result = p.Check("192.168.1.1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_returnFalse()
        {
            Program p = new Program();
            var result = p.Check("192,abc.0");
            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow("192.9,dew")]
        [DataRow("000,897,554")]
        public void Check_returnFalse_MuiltpleData(string input)
        {
            Program p = new Program();
            var result = p.Check(input);
            Assert.IsTrue(result);
        }
    }
}
