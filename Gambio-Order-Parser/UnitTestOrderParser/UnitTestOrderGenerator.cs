using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderParser;
using JSONnamespace;
using TestOrderGenerator;
using Google.Apis.Sheets.v4;

namespace UnitTestOrderParser
{
    [TestClass]
    public class UnitTestOrderGenerator
    {
        [TestMethod]
        public void TestTryCatch()
        {
            //arange
            string ApplicationName = "Google Sheets API .NET Quickstart";
            string sheet = "Out Europe";
            string SpreadsheetId = "14PIciWVGf6igDu7viXuWI0L8L5gvFtfe3kKWkSwau5U";
            //act
            GoogleSheets googleSheets = new GoogleSheets(ApplicationName, sheet, SpreadsheetId);
            googleSheets.Init(out SheetsService sheetsService);
            //assert
            Assert.IsNotNull(sheetsService);
        }
    }
}
