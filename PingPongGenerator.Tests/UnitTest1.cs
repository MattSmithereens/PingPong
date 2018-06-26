using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGenerator;

namespace PingPongGenerator.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void DivBy3and5()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("ping pong", testPingPong.PingPongCheck(15));
        }

        [TestMethod]
        public void DivBy5()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("pong", testPingPong.PongCheck(5));
        }

        [TestMethod]
        public void DivBy3()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("ping", testPingPong.PingCheck(3));
        }

    }
}
