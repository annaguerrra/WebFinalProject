using System.ComponentModel.DataAnnotations;

namespace WebFinalProject.Validations;

public class IsUpperLowerCaseAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
        => value is string text && text.Any(char.IsLower) && text.Any(char.IsUpper);


    public override string FormatErrorMessage(string name)
        => $"The password must to contain at least one Upper and Lower character";
    
}