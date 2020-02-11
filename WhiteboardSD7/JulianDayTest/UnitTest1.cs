using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JulianDay
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, JulianDay.GetJulian(1, 1));
        }
        public void TestMethod2()
        {
            Assert.AreEqual(64, JulianDay.GetJulian(3, 5));
        }
    }
}
