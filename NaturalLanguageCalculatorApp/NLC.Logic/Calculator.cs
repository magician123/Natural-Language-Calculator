using NLC.Logic.Interfaces;

namespace NLC.Logic
{
    public class Calculator : ICalculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
