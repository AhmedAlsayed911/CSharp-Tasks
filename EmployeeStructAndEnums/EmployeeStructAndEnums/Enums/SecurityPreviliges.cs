using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeStructAndEnums.Enums
{
    [Flags]
    internal enum SecurityPreviliges : Byte
    {
        None = 0,
        Guest = 1,
        Develpoer = 2,
        Secretary = 4,
        DBA = 8
    }
}
