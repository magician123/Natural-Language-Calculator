using System.Collections.Generic;

namespace NLC.Logic
{
    public class SubtractOperator : Operator
    {
        List<string> permitedAliases;
        public SubtractOperator()
        {
            permitedAliases = new List<string>
            {
                "subtract","minus","less"
            };
        }
        public override bool IsPermitedAlias(string allias)
        {
            bool permited = false;
            foreach (var item in permitedAliases)
            {
                if (item == allias)
                    permited = true;
            }

            return permited;
        }
    }
}
