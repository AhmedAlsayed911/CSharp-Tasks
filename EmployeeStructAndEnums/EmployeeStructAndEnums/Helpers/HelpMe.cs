using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeStructAndEnums.Helpers
{
    internal class HelpMe
    {
        public static string GenderValidator(string gender)
        {
            if (!new[] { "m", "f", "male", "female" }.Contains(gender))
                return "no";
            else
            {
                if (new[] { "m", "male" }.Contains(gender))
                    return "male";
                else
                    return "female";
            }
        }
    }
}
