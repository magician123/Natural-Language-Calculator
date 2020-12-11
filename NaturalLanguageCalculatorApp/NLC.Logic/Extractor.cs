using NLC.Logic.Utilities;
using System.Collections.Generic;

namespace NLC.Logic
{
    public class Extractor
    {
        List<string> operations;
        List<string> numbers;
        public Extractor()
        {
            operations = new List<string>();
            numbers = new List<string>();

        }

        public  List<string> Operations { get => operations; set => operations = value; }
        public List<string> Numbers { get => numbers; set => numbers = value; }

        public void ExtractOperations(string[] naturalLanguageString)
        {
            EvenNumberEvaluator index = new EvenNumberEvaluator();

            for (int i = 0; i < naturalLanguageString.Length; i++)
            {
                if (index.IsEvenNumber(i))
                    numbers.Add(naturalLanguageString[i]);
                else
                    operations.Add(naturalLanguageString[i]);


            }
        }
    }
}
