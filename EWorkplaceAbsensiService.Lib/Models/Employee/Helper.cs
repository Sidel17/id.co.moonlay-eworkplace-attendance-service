using System;
using System.Collections.Generic;
using System.Text;

namespace EWorkplaceAbsensiService.Lib.Models.Employee
{
    public enum Gender
    {
        Male = 1,
        Female,
        Others
    }

    public enum EmploymentStatus
    {
        Internship = 1,
        Probation,
        FullTime,
        Resigned
    }

    public enum AssetType
    {
        Card = 1,
        Locker,
        Laptop
    }
}
