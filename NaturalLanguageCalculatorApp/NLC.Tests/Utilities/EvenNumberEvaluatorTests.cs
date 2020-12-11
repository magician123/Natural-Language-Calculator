using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLC.Logic.Utilities;

namespace NLC.Tests.Utilities
{
    [TestClass]
    public class EvenNumberEvaluatorTests
    {
        EvenNumberEvaluator evenNumberEvaluator;

        [TestInitialize]
        public void SetUp()
        {
            evenNumberEvaluator = new EvenNumberEvaluator();
        }


        [TestMethod]
        public void IsEvenNumber_WhenNumberEvenNumber_ReturnsTrue()
        {
            var result = evenNumberEvaluator.IsEvenNumber(2);

            Assert.AreEqual(result, true);

        }

        [TestMethod]
        public void IsEvenNumber_WhenNumberOddNumber_ReturnsFalse()
        {
            var result = evenNumberEvaluator.IsEvenNumber(3);

            Assert.AreEqual(result, false);

        }
    }
}
