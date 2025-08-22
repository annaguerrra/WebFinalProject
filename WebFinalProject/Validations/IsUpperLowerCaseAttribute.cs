namespace WebFinalProject.Validations;

public class IsUpperLowerCaseAttribute : ValidationsAttribute
{
    public override bool IsValid(object value)
        => value is string character && character.Any(c => c is c.IsLower() && c.IsUpper());

    public override string FormatErrorMessage()
        => $"Password must to contain at least one Upper and Lower letter.";
}