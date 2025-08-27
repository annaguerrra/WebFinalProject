using System.ComponentModel.DataAnnotations;

namespace WebFinalProject.Validations;

public class SpecialCharAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
        => value is string charac && charac.Any(char.IsSymbol) && charac.Any(char.IsPunctuation);

    public override string FormatErrorMessage(string password)
        => $"The password must to contain at least one special character.";
}