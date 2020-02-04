using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace StringReversal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringReversalSuperBowl()
        {
        Assert.AreEqual("lwoB repuS",StringReversal.Program.Reversal("Super Bowl"));
        }
        public void StringReversalDogIsGod()
        {
            Assert.AreEqual("doG sI goD", StringReversal.Program.Reversal("Dog Is God"));
        }
    }
}
