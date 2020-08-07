using EWorkplaceAbsensiService.Lib.Models.Employee;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EWorkplaceAbsensiService.Lib.Services.Employee.Asset
{
    public class FormDto : IValidatableObject
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public AssetType? Type { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(IdentityNumber))
                yield return new ValidationResult("Asset Number is required", new List<string> { "IdentityNumber" });

            if (string.IsNullOrWhiteSpace(Name))
                yield return new ValidationResult("Asset Name is required", new List<string> { "Name" });

            if (!Type.HasValue)
                yield return new ValidationResult("Asset Type is required", new List<string> { "Type" });
        }
    }
}