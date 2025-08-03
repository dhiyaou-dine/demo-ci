using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoApp;

namespace DemoApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ReturnsCorrectSum()
        {
            int result = Program.Add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}
