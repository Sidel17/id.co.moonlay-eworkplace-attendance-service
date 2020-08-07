using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EWorkplaceAbsensiService.Lib.Models.Employee
{
    public class Division : StandardEntity
    {
        public Division()
        {

        }

        public Division(string name)
        {
            Name = name;
        }

        [MaxLength(256)]
        public string Name { get; private set; }
    }
}
