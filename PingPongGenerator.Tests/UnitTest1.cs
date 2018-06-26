using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGenerator;

namespace PingPongGenerator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsIntConvertedToList()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(true, testPingPong.CreateList());
        }
    }
}
