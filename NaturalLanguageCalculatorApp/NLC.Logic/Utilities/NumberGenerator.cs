using System;
using System.Collections.Generic;
using System.Text;

namespace NLC.Logic.Utilities
{
    public static class NumberGenerator
    {
        public const int INVALIDNUMBER = 11;
        public static int GetInteger(string number)
        {
            int integerNumber = INVALIDNUMBER;
            Dictionary<string, int> supportedInput = new Dictionary<string, int>
            {
                { "zero",0},
                {"one",1 },
                { "two",2},
                {"three",3 },
                 { "four",4},
                {"five",5 },
                { "six",6},
                {"seven",7 },
                 { "eight",8},
                {"nine",9 },
                {"ten",10 }



            };
            foreach (var item in supportedInput)
            {
                if (item.Key == number)
                    integerNumber = item.Value;

            }

            return integerNumber;
        }
    }
}
