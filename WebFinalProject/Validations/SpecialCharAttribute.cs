namespace WebFinalProject.Validations;

public class SpecialCharAttribute : ValidationsAttribute
{
    public override bool IsValid(object value)
        => value is string charac && charac.Any(c => c is == "." or == "#" or == "&" or == "%" or == "$");
    public override string FormatErrorMessage()
        => $"The password must to contain at least one special character.";
}