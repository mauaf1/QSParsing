using Microsoft.VisualStudio.TestTools.UnitTesting;
using QSParsingConsoleApp;

namespace QSParsingConsoleAppTest
{
    [TestClass]
    public class QSParserTests
    {
        [TestMethod]
        public void Count_EmptyQueryString_ReturnsZero()
        {
            var parser = new QSParser("");
            Assert.AreEqual(0, parser.Count());
        }

        [TestMethod]
        public void Count_NullQueryString_ReturnsZero()
        {
            var parser = new QSParser(null);
            Assert.AreEqual(0, parser.Count());
        }

        [TestMethod]
        public void ValueOf_KeyExists_ReturnsCorrectValue()
        {
            var parser = new QSParser("name=Magnus&age=22");
            Assert.AreEqual("Magnus", parser.ValueOf("name"));
        }

        [TestMethod]
        public void ValueOf_KeyDoesNotExist_ReturnsNull()
        {
            var parser = new QSParser("name=Magnus");
            Assert.IsNull(parser.ValueOf("age"));
        }

        [TestMethod]
        public void Count_MultipleNameValuePairs_ReturnsCorrectCount()
        {
            var parser = new QSParser("name=Magnus&age=22&city=Aarhus");
            Assert.AreEqual(3, parser.Count());
        }

        [TestMethod]
        public void ValueOf_MultiplePairs_ReturnsCorrectValue()
        {
            var parser = new QSParser("name=Magnus&age=22&city=Aarhus");
            Assert.AreEqual("22", parser.ValueOf("age"));
        }
    }
}
