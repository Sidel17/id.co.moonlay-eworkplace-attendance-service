using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EWorkplaceAbsensiService.Lib.Models.Employee
{
    public class EmploymentRole : StandardEntity
    {
        public EmploymentRole()
        {

        }

        public EmploymentRole(string name)
        {
            Name = name;
        }

        [MaxLength(256)]
        public string Name { get; private set; }
    }
}
