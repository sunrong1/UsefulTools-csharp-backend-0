using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageFeatures;
using System.Threading;

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

        [TestClass()]
        public class TimeKeeperTests
        {
            [TestMethod()]
            public void SecondSleepTest()
            {
                TimeKeeper time = new TimeKeeper(5);
                time.SecondSleep();
                time.Start();
                Thread.Sleep(5);
                Assert.IsTrue(time.TimeOut);
            }
        }
    }
}
