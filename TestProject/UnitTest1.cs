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
            //Arrange
            int x = 0;
            string sx = "55";
            //Act
            Program.ConvertInt(ref x, sx, 0);
            //Assert
            Assert.IsTrue(x == 55);
        }
        [TestMethod]
        public void TestReturnMoney()
        {
            //Arrange
            int returnCash = 851;
            int[,] ControlArray = new int[12,2] { { 5000, 0 }, { 2000, 0 }, { 1000, 0 }, { 500, 1 }, { 200, 1 }, { 100, 1 }, { 50, 1 }, { 20, 0 }, { 10, 0 }, { 5, 0 }, { 2, 0 }, { 1, 1 } };
            //Act
            int[,] ResultArray = Program.ReturnMoney(returnCash);
            //Assert
            Assert.AreEqual(ControlArray[3, 1], ResultArray[3, 1]);
            Assert.AreEqual(ControlArray[4, 1], ResultArray[4, 1]);
            Assert.AreEqual(ControlArray[5, 1], ResultArray[5, 1]);
            Assert.AreEqual(ControlArray[6, 1], ResultArray[6, 1]);
            Assert.AreEqual(ControlArray[11, 1], ResultArray[11, 1]);
        }
    }
}
