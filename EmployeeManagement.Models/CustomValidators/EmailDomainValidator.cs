using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models.CustomValidators
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomain { get; set; } = "PRAGIMTECH.COM";

       protected  override ValidationResult IsValid(object value, ValidationContext validationContext){
          string[] strings = value.ToString().Split('@');
          if (strings[1].ToUpper() == AllowedDomain.ToUpper())
          {
              return null;
          } else
          return new ValidationResult(ErrorMessage, new[] {validationContext.MemberName});
       }
    }
}