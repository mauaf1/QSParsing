using Microsoft.VisualStudio.TestTools.UnitTesting;
using QSParsingConsoleApp;

namespace QSParsingConsoleAppTest
{
    [TestClass]
    public class QSParserTests
    {
        [TestMethod]
        public void Count_ShouldReturnCorrectNumberOfParameters()
        {
            // Arrange
            var parser = new QSParser();
            string queryString = "?name=Magnus&age=22&city=Aarhus";

            // Act
            int result = parser.Count(queryString);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Count_ShouldReturnZeroForEmptyString()
        {
            var parser = new QSParser();

            Assert.AreEqual(0, parser.Count(""));
            Assert.AreEqual(0, parser.Count("?"));
        }
    }
}
