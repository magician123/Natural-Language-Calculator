using NLC.Logic;
using System;

namespace NLC.View
{
    class Program
    {

        static void Main(string[] args)
        {

            RequestProcessor requestProcessor = new RequestProcessor();
            Extractor extraction = new Extractor();

            Console.WriteLine("Enter your Natural language operation");
            var naturalLanguageString = Console.ReadLine();

            extraction.ExtractOperations(naturalLanguageString.ToLower().Split(" "));

            var result = requestProcessor.ProcessCalculations(extraction.Numbers, extraction.Operations);


            Console.WriteLine($"{result}");



            Console.ReadLine();
        }

    }
}

