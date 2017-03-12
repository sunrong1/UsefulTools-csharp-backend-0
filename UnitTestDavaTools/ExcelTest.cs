using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageFeatures;

namespace UnitTestDavaTools
{
    [TestClass]
    public class ExcelTest
    {
        [TestMethod]
        public void WriteExcelTest()
        {
            string filePath = @"d:\testdata\test.xlsx";
            ExcelOperate ExlSave = new ExcelOperate();
            ExlSave.OledbRead(filePath);
            bool result =ExlSave.OledbWrite(filePath);
            Assert.IsTrue(result);
        }
    }
}
