using System.Collections.Generic;

namespace NLC.Logic
{


    public class AddOperator : Operator
    {
        List<string> permitedAliases;
        public AddOperator()
        {
            permitedAliases = new List<string>
            {
                "Add","plus"
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
