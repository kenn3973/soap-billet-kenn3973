using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfBilletService1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfBilletService1.Tests
{
    [TestClass()]
    public class Service1Tests
    {

        [TestMethod()]
        public void GetMCPrisUdenBroBizzTest()
        {
            var mc = new Service1();

            var testmc = mc.GetMCPris(false);

            Assert.AreEqual(125, testmc);
        }

        [TestMethod()]
        public void GetMCPrisMedBroBizzTest()
        {
            var mc = new Service1();

            var testmc = mc.GetMCPris(true);

            Assert.AreEqual(118, testmc);
        }

        [TestMethod()]
        public void GetPrisBilUdenBroBizzTest()
        {
            var bil = new Service1();

            var test = bil.GetPrisBil(false);

            Assert.AreEqual(240, test);
        }

        [TestMethod()]
        public void GetPrisBilMedBroBizzTest()
        {
            var bil = new Service1();

            var test = bil.GetPrisBil(true);

            Assert.AreEqual(228, test);
        }
    }
}