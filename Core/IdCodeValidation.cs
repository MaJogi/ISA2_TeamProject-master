using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class IdCodeValidation : ValidationAttribute
    {
        //Todo
        //Add complex logic to validate idcode and get birthdate and gender from idcode.

        protected const string requiredField = "Required field";
        protected const string wrongLength = "Wrong length";
        protected const string useOnlyNumbers = "Use only numbers";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return error(requiredField);
            var s = value.ToString();
            if (s.Trim().Length != 11) return error(wrongLength);
            if (!onlyNumbers(s)) return error(useOnlyNumbers);
            return ValidationResult.Success;
        }

        protected static bool onlyNumbers(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            if (string.IsNullOrEmpty(s.Trim())) return false;
            return s.Trim().All(char.IsDigit);
        }
        protected static ValidationResult error(string s)
        {
            return new ValidationResult(s);
        }
    }
}
