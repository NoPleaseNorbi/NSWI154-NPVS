using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DateTimeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1_Constructor()
        {
            var date = new DateTime(2008, 3, 1, 7, 0, 0);
            Assert.AreEqual("01/03/2008 07:00:00", date.ToString());
        }

        [TestMethod]
        public void Test_2_String_Parse()
        {
            string date = "2018/01/12";
            Assert.AreEqual("01/12/2018 00:00:00", DateTime.ParseExact(date, "yyyy/dd/MM", null).ToString());
        }

        [TestMethod]
        public void Test_3_Date_Form()
        {
            var date = new DateTime();
            date = date.AddDays(40);
            date = date.AddMonths(23);
            date = date.AddYears(1231);
            Assert.AreEqual("10/01/1234 00:00:00", date.ToString());
        }
    }
}
