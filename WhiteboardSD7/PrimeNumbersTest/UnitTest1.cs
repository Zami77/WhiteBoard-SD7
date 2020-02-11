using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsPrimeCheckSpace;

namespace IsPrimeCheckSpace
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(IsPrimeCheck.IsPrime(2));
        }
    }
}
