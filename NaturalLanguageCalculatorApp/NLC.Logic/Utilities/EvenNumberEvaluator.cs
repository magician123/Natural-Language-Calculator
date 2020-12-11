using System;
using System.Collections.Generic;
using System.Text;

namespace NLC.Logic.Utilities
{
    public class EvenNumberEvaluator
    {
        public bool IsEvenNumber(int number)
        {
            return (number % 2 == 0) ? true : false;

        }
    }
}
