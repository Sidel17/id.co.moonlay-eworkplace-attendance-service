using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EWorkplaceAbsensiService.Lib.Models.Employee
{
    public class Religion : StandardEntity
    {
        public Religion()
        {

        }

        public Religion(string name)
        {
            Name = name;
        }

        [MaxLength(128)]
        public string Name { get; private set; }
    }
}
