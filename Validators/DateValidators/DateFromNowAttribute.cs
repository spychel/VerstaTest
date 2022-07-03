using System.ComponentModel.DataAnnotations;

namespace VerstaTest.Validators
{
    public class DateFromNowAttribute : ValidationAttribute
    {
        public DateFromNowAttribute() { }

        public override bool IsValid(object? value)
        {
            var dateNow = DateOnly.FromDateTime(DateTime.Now);
            if (dateNow.CompareTo(value) <= 0) 
                return true;
            else 
                return false;
        }
    }
}
