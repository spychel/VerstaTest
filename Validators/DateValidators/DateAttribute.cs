using System.ComponentModel.DataAnnotations;

namespace VerstaTest.Validators
{
    public class DateAttribute : ValidationAttribute
    {
        public DateAttribute() { }

        public override bool IsValid(object? value)
        {
            bool result = value is DateOnly;
            return result;
        }
    }
}