using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EWorkplaceAbsensiService.Lib.Models.Employee
{
    public class EmployeeAsset : StandardEntity
    {
        public EmployeeAsset()
        {

        }

        public EmployeeAsset(int employeeProfileId, int assetId)
        {
            EmployeeProfileId = employeeProfileId;
            AssetId = assetId;
        }

        public int EmployeeProfileId { get; private set; }
        public int AssetId { get; private set; }
    }
}
