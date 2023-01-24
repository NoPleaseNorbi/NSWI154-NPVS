using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
namespace SortedDictionaryTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test_1_NewKey()
        {
            SortedDictionary<string, string> Dic = new SortedDictionary<string, string>();
            Dic.Add("nieco", "nieco");

            bool contains = true;
            if (Dic.ContainsKey("nieco"))
            {
                contains = false;
            }
            Assert.IsFalse(contains);

        }

        [TestMethod]
        public void Test_2_Existent_Key() 
        {
            Exception expectedException = null;
            SortedDictionary<string, string> Dic = new SortedDictionary<string, string>();
            Dic.Add("nieco", "nieco");
            try
            {
                Dic.Add("nieco", "nieco");
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void Test_3_Remove()
        {
            SortedDictionary<string, string> Dic = new SortedDictionary<string, string>();

            Dic.Add("nieco", "nieco");
            Dic.Add("ha", "yes");
            Dic.Remove("nieco");

            bool contains = false;
            if (Dic.ContainsKey("nieco")) {
                contains = true;
            }
            Assert.IsFalse(contains);
        }

        [TestMethod]
        public void Test_4_Empty()
        {
            SortedDictionary<string, string> Dic = new SortedDictionary<string, string>();
            Dic.Add("nieco", "nieco");
            Dic.Remove("nieco");

            SortedDictionary<string, string> ASD = new SortedDictionary<string, string>();

            Assert.IsTrue(Dic.Count == 0);
        }

        [TestMethod]
        public void Test_5_Key_Value()
        {
            SortedDictionary<string, string> Dic = new SortedDictionary<string, string>();
            Dic.Add("key", "value");
            string key = Dic["key"];
            StringAssert.Equals("value", key);
        }

        [TestMethod]
        public void Test_6_Non_Existent_Key()
        {
            Exception expectedException = null;
            SortedDictionary<string, string> Dic = new SortedDictionary<string, string>();
            Dic.Add("nieco", "nieco");
            try
            {
                string non_existent_value = Dic["Non"];
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void Test_7_On_Purpose_Error()
        {
            Exception expectedException = null;

            Assert.IsNotNull(expectedException, "Yeah, you should make a better program next time");
        }


    }
}
