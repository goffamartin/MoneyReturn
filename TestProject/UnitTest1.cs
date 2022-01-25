using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyReturn;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConvert()
        {
            int x = 0;
            string sx = "55";
            Program.ConvertInt(ref x, sx, 0);
            Assert.IsTrue(x == 55);
        }
    }
}
