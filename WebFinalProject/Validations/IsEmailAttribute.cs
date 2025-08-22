namespace WebFinalProject.Validations;

public class IsEmailAttribute : ValidationsAttribute
{
    public override bool IsValid(object value)
        => value is string email && email.Any(e => e is == "@gmail.com" or == "@hotmail.com" or == "@outlook.com" or == "@yahoo.com");

    public override string FormatErrorMessage()
        => $"This e-mail is invalid.";
}