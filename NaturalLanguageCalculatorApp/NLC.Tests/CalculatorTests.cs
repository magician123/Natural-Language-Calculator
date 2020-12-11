using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NLC.Logic
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator calculator;

        [TestInitialize]
        public void SetUp()
        {
            calculator = new Calculator();

        }

        [TestMethod]
        public void AddNumbers_GivenTwoNumbers_ReturnsTheSum()
        {
            int firstNumber = 5;
            int secondNumber = 2;

            var result = calculator.Add(firstNumber, secondNumber);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Max_GivenTwoNumbers_ReturnsGreaterNumber()
        {
            int firstNumber = 4;
            int secondnumber = 2;

            var result = calculator.Subtract(firstNumber, secondnumber);

            Assert.AreEqual(2, result);

        }


    }
}
