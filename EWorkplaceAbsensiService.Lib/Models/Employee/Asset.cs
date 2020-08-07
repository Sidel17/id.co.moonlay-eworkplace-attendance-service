using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EWorkplaceAbsensiService.Lib.Models.Employee
{
    public class Asset : StandardEntity
    {
        public Asset()
        {

        }

        public Asset(string identityNumber, string name, AssetType type)
        {
            IdentityNumber = identityNumber;
            Name = name;
            Type = type;
        }

        [MaxLength(128)]
        public string IdentityNumber { get; private set; }
        [MaxLength(128)]
        public string Name { get; private set; }
        public AssetType Type { get; private set; }
    }
}
