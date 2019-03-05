using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountOccurences
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindingChar()
        {
            var stringToCheck = "mysterious";

            var stringToFind = "y";

            var expectedResult = 1;

            var classUnderTest = new StringUtilities();

            var actucalResult = classUnderTest.CountOccurences(stringToCheck, stringToFind[0]);

            Assert.AreEqual(expectedResult, actucalResult);
        }

        [TestMethod]
        public void FindingMultipleChar()
        {
            var stringToCheck = "mysterious";

            var stringToFind = "s";

            var expectedResult = 2;

            var classUnderTest = new StringUtilities();

            var actucalResult = classUnderTest.CountOccurences(stringToCheck, stringToFind[0]);

            Assert.AreEqual(expectedResult, actucalResult);
        }

        [TestMethod]
        public void CaseSenstiveTest()
        {
            var stringToCheck = "mySterious";

            var stringToFind = "s";

            var expectedResult = 2;

            var classUnderTest = new StringUtilities();

            var actucalResult = classUnderTest.CountOccurences(stringToCheck, stringToFind[0]);

            Assert.AreEqual(expectedResult, actucalResult);
        }

        [TestMethod]
        public void NullTesting()
        {
            string stringToCheck = null;

            var stringToFind = "s";

            var expectedResult = -1;

            var classUnderTest = new StringUtilities();

            var actucalResult = classUnderTest.CountOccurences(stringToCheck, stringToFind[0]);

            Assert.AreEqual(expectedResult, actucalResult);
        }
    }
}
