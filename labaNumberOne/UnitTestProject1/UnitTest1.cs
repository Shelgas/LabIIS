using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace labaNumberOne
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            WayStrategy way = new WayStrategy(new Bus());
            Assert.AreEqual("4 hours", way.Time());
            Assert.AreEqual("200 gold", way.Pay());
        }

        [TestMethod]
        public void TestMethod2()
        {
            WayStrategy way = new WayStrategy(new Car());
            Assert.AreEqual("2 hours", way.Time());
            Assert.AreEqual("500 gold", way.Pay());
        }

        [TestMethod]
        public void TestMethod3()
        {
            WayStrategy way = new WayStrategy(new Legs());
            Assert.AreEqual("Veryyy lonng!!!", way.Time());
            Assert.AreEqual("It's freeee!!!!", way.Pay());
        }
    }
}
