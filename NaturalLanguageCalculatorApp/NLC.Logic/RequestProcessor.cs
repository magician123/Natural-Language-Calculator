using NLC.Logic.Utilities;
using System.Collections.Generic;

namespace NLC.Logic
{
    public class RequestProcessor
    {
        public int ProcessCalculations(List<string> numbers, List<string> operations)
        {
            var counter = numbers.Count;
            int results = NumberGenerator.GetInteger(numbers[0]);

            Calculator calculator = new Calculator();
            AddOperator addOperator = new AddOperator();
            SubtractOperator subtractOperator = new SubtractOperator();

            for (int i = 1; i < counter; i++)
            {
                if (addOperator.IsPermitedAlias(operations[i - 1]))
                    results = calculator.Add(results, NumberGenerator.GetInteger(numbers[i]));

                else if (subtractOperator.IsPermitedAlias(operations[i - 1]))
                    results = calculator.Subtract(results, NumberGenerator.GetInteger(numbers[i]));

                else
                    results = 0;


            }
            return results;
        }
    }
}
