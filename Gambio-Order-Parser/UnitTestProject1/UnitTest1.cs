using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderParser;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int numberDate = 1;
            int month = 1;
            int year = 1;
            //act
            bool changer = Program.ChangeDate(numberDate, month, year);
            //assert
            Assert.IsTrue(changer);
        }
    }
}
