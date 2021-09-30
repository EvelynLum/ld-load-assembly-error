using LaunchDarkly.Sdk.Server;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WebApp._4._5._2.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new LdClient(Configuration.Builder("sdk").Build());
            var user = LaunchDarkly.Sdk.User.Builder("x").Build();
        }
    }
}
