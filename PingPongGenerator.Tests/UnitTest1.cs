using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGenerator;
using System.Collections.Generic;

namespace PingPongGenerator.Tests
{
    [TestClass]
    public class UnitTest1
    {


        //[TestMethod]
        //public void ThisIsOurTest()
        //{
        //    PingPong testPingPong = new PingPong();
        //    //public List<string> testList = new List( "1", "2", "ping" );
        //    Assert.AreEqual(true, true);
        //}

        [TestMethod]
        public void DivBy3and5()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(true, testPingPong.PingPongCheck(15));
        }

        [TestMethod]
        public void DivBy5()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(true, testPingPong.PongCheck(5));
        }

        [TestMethod]
        public void DivBy3()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(true, testPingPong.PingCheck(3));
        }

        [TestMethod]
        public void ThisIsOurTest()
        {
            PingPong testPingPong = new PingPong();
            List<string> testList = new List<string>(new string [] { "1", "2", "ping" });
            //List<int> list = new List<int>(new int[] { 2, 3, 7 });
            CollectionAssert.AreEqual(testList, testPingPong.CreateList(3));
        }
    }

}