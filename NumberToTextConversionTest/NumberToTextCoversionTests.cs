using System;
using NumberToTextConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberToTextConversionTest
{
    [TestClass]
    public class NumberToTextCoversionTests
    {
        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual("ten", NumberToTextConversion.NumberTranslator.GetTranslation(10));
        }
        [TestMethod]
        public void Test100()
        {

            Assert.AreEqual("one hundred", NumberToTextConversion.NumberTranslator.GetTranslation(100));
        }
        [TestMethod]
        public void Test111()
        {

            Assert.AreEqual("one hundred and eleven", NumberToTextConversion.NumberTranslator.GetTranslation(111));
        }
        [TestMethod]
        public void Test1000()
        {
            Assert.AreEqual("one thousand", NumberToTextConversion.NumberTranslator.GetTranslation(1000));
        }
        [TestMethod]
        public void Test12()
        {
            Assert.AreEqual("twelve",NumberToTextConversion.NumberTranslator.GetTranslation(12));
        }
        [TestMethod]
        public void Test21()
        {
            Assert.AreEqual("twenty one", NumberToTextConversion.NumberTranslator.GetTranslation(21));
        }
        [TestMethod]
        public void Test115()
        {
            Assert.AreEqual("one hundred and fifteen", NumberToTextConversion.NumberTranslator.GetTranslation(115));
        }
        [TestMethod]
        public void Test206()
        {
            Assert.AreEqual("two hundred and six", NumberToTextConversion.NumberTranslator.GetTranslation(206));
        }
        [TestMethod]
        public void Test342()
        {
            Assert.AreEqual("three hundred and forty two", NumberToTextConversion.NumberTranslator.GetTranslation(342));
        }
        [TestMethod]
        public void Test999()
        {
            Assert.AreEqual("nine hundred and ninety nine", NumberToTextConversion.NumberTranslator.GetTranslation(999));
        }
    }
}
